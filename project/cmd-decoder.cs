using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Buffers.Binary;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace CommandDecoder 
{
    public class MessageDecoder(List<CommandSpec> CommandSpecs, Dictionary<string, EnumSpec> enumSpecs)
    {
        // to find the correct XML 
        public const string requieredType = "cmd-decoder";
        public const string requieredVersion = "1.0";

        private readonly Dictionary<(string, string), CommandSpec> _specs = CommandSpecs.ToDictionary( cmd => (cmd.Id, cmd.Version), cmd => cmd);
        private readonly Dictionary<string, EnumSpec> _enums = enumSpecs;

        public string Dump_Version(string input)
        {
            return input[..2];
        }
        public string Dump_Command(string input)
        {
            return input[2..4]; 
        }
        public string Dump_Datalen(string input)
        {
            return input[4..8];
        }
        public string Dump_Data(string input)
        {
            return input[8..(8+2*Convert.ToInt32(input[4..8], 16))];
        }
        public string Dump_Checksum(string input)
        {
            return input[(2*Convert.ToInt32(input[4..8], 16))..];
        }
        public Dictionary<string, object> Decode(string input)
        {
            const int VersCmdSize = 4;
            const int DataLenSize = 4;

            var result = new Dictionary<string, object>();
            string version = Convert.ToInt32(input[..2], 16).ToString(); // Erste zwei Zeichen als Version
            string cmd = Convert.ToInt32(input[2..4], 16).ToString(); // Nächsten zwei Zeichen als Command
            int DataLenReal = Convert.ToInt32(input[4..8], 16) * 2;
            int DynDataLen = 0;
            int NextPosition = 0;
            var valueStr = "";
            var key = ( cmd, version );

            if (!_specs.TryGetValue(key, out CommandSpec? gotSpec))
            {
                throw new ArgumentException($"Unknown Command Specification: {key}");
            }

            var spec = gotSpec;
            result["CommandName"] = spec.Name;

            // Pointer to data
            NextPosition = VersCmdSize;
            DynDataLen = DataLenReal;
            foreach (var specItem in spec.Items)
            {
                if (specItem.IsVariableLength)
                {
                    valueStr = input.Substring(VersCmdSize + specItem.Position, DynDataLen);
                    NextPosition += DynDataLen;
                    DynDataLen -= DynDataLen;
                }
                else if (specItem.IsVariablePos)
                {
                    valueStr = input.Substring(NextPosition, specItem.Length);
                    NextPosition += specItem.Length;
                    DynDataLen -= specItem.Length;
                }
                else
                {
                    valueStr = input.Substring(VersCmdSize + specItem.Position, specItem.Length);
                    NextPosition += specItem.Length;
                    if (specItem.Id != "DataLength")
                    {
                        DynDataLen -= specItem.Length;
                    }
                }
                object value = DecodeValue(valueStr, specItem);
                result[specItem.Id] = value;
            }

            if (spec.Block != null)
            {
                int blockSize = spec.Block.Items.Sum(item => Convert.ToInt16(item.Length));
                int blockStartPos = 4 + spec.Items.Max(item => item.Position + item.Length);
                int blockCount = (input.Length - blockStartPos) / blockSize;

                for (int i = 0; i < blockCount; i++)
                {
                    var blockResult = new Dictionary<string, object>();
                    foreach (var blockItem in spec.Block.Items)
                    {
                        if (blockItem.IsVariableLength)
                        {
                            valueStr = input.Substring(VersCmdSize + blockItem.Position, DynDataLen);
                            NextPosition += DynDataLen;
                            DynDataLen -= DynDataLen;
                        }
                        else if (blockItem.IsVariablePos)
                        {
                            valueStr = input.Substring(NextPosition, blockItem.Length);
                            NextPosition += blockItem.Length;
                            DynDataLen -= blockItem.Length;
                        }
                        else
                        {
                            valueStr = input.Substring(VersCmdSize + blockItem.Position, blockItem.Length);
                            NextPosition += blockItem.Length;
                            if (blockItem.Id != "DataLength")
                            {
                                DynDataLen -= blockItem.Length;
                            }
                        }
                        object value = DecodeValue(valueStr, blockItem);
                        blockResult[blockItem.Id] = value;
                    }
                    result[$"Block_{i}"] = blockResult;
                }
            }

            return result;
        }
        private object DecodeValue(string valueStr, SpecItem specItem)
        {

            object value = "";

            switch (specItem.Type)
            {
                case "raw":
                    value = valueStr;
                    break;
                case "boolean":
                    if (valueStr == "00")
                    {
                        value = "false";
                    }
                    if (valueStr == "01")
                    {
                        value = "true";
                    }
                    break;
                case "dow_bitfield":
                    byte ByteValue = Convert.ToByte(valueStr, 16);
                    if ((ByteValue & 0b_0000_0001) == 0b_0000_0001)
                        value += "\n\tSunday";
                    if ((ByteValue & 0b_0000_0010) == 0b_0000_0010)
                        value += "\n\tMonday ";
                    if ((ByteValue & 0b_0000_0100) == 0b_0000_0100)
                        value += "\n\tTuesday ";
                    if ((ByteValue & 0b_0000_1000) == 0b_0000_1000)
                        value += "\n\tWednesday ";
                    if ((ByteValue & 0b_0001_0000) == 0b_0001_0000)
                        value += "\n\tThursday ";
                    if ((ByteValue & 0b_0010_0000) == 0b_0010_0000)
                        value += "\n\tFriday ";
                    if ((ByteValue & 0b_0100_0000) == 0b_0100_0000)
                        value += "\n\tSaturday ";
                    if ((ByteValue & 0b_1000_0000) == 0b_1000_0000)
                        value += "\n\treserved ";
                    break;
                case "value":
                    value = valueStr;
                    break;
                case "year":
                    value = 2000 + Convert.ToInt32(valueStr, 16);
                    break;
                case "int8":
                    value = Convert.ToInt16(valueStr, 16) % 256;
                    break;
                case "int16":
                    value = Convert.ToInt16(valueStr, 16);
                    break;
                case "int32":
                    value = Convert.ToInt32(valueStr, 16);
                    break;
                case "bigEndian":
                    value = BinaryPrimitives.ReverseEndianness(Convert.ToInt32(valueStr, 16));
                    break;
                case "string":
                    StringBuilder ascii = new StringBuilder();
                    for (int i = 0; i < valueStr.Length; i += 2)
                    {
                        // Nimmt zwei Hex-Zeichen (1 Byte), konvertiert sie in eine Zahl, und dann in ein ASCII-Zeichen
                        string hexChar = valueStr.Substring(i, 2);
                        int tempValue = Convert.ToInt32(hexChar, 16);
                        ascii.Append((char)tempValue);
                    }
                    value = ascii;
                    break;
                case "enum":
                    var intValue = Convert.ToInt32(valueStr, 16);
                    if (_enums.TryGetValue(key: specItem.EnumType, out EnumSpec enumSpec))
                    {
                        var enumValue = enumSpec.Values.FirstOrDefault(e => e.Value == intValue);
                        if (enumValue != null)
                        {
                            value = enumValue.Name;
                        }
                        else
                        {
                            value = $"Unknown Enum Value: {intValue}";
                        }
                    }
                    else
                    {
                        value = $"Unknown Enum Type: {specItem.EnumType}";
                    }
                    break;
                case "timeGMT":
                    value = valueStr;
                    break;
                case "bitmap":
                    value = valueStr;
                    break;
                default:
                    throw new ArgumentException($"Unknown type: {specItem.Type}");
            }
            
            return value;
        }
    }
}