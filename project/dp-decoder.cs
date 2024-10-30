using System;
using System.Collections.Generic;
using System.Linq;

namespace DatapointDecoder
{
    public class MessageDecoder(List<DatapointSpec> datapointSpecs, Dictionary<string, EnumSpec> enumSpecs)
    {
        // to find the correct XML 
        public const string requieredType = "dp-decoder";
        public const string requieredVersion = "1.0";

        private readonly Dictionary<string, DatapointSpec> _specs = datapointSpecs.ToDictionary(dp => dp.Id);
        private readonly Dictionary<string, EnumSpec> _enums = enumSpecs;

        public Dictionary<string, object> Decode(string input)
        {
            var result = new Dictionary<string, object>();
            string dpId = Convert.ToInt32(input[..2], 16).ToString();  // Erste zwei Zeichen als Datapoint-ID

            if (!_specs.TryGetValue(dpId, out var gotvalue))
            {
                throw new ArgumentException($"Unknown Datapoint ID: {dpId}");
            }

            var spec = gotvalue;
            result["DatapointName"] = spec.Name;

            foreach (var specItem in spec.Items)
            {
                var valueStr = input.Substring(2 + specItem.Position, specItem.Length);
                object value = DecodeValue(valueStr, specItem);
                result[specItem.Id] = value;
            }

            if (spec.Block != null)
            {
                int blockSize = spec.Block.Items.Sum(item => item.Length);
                int blockStartPos = 2 + spec.Items.Max(item => item.Position + item.Length);
                int blockCount = (input.Length - blockStartPos) / blockSize;

                for (int i = 0; i < blockCount; i++)
                {
                    var blockResult = new Dictionary<string, object>();
                    foreach (var blockItem in spec.Block.Items)
                    {
                        int itemPos = blockStartPos + i * blockSize + blockItem.Position;
                        var valueStr = input.Substring(itemPos, blockItem.Length);
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
                case "string":
                    value = valueStr;
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