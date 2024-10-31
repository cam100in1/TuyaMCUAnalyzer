using DatapointDecoder;
using CommandDecoder;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace TuyaMCUAnalyzer
{
    public partial class FormTuyaMCUAnalyzer : Form
    {
        private bool refreshingComparer;
        private bool bUseVarsForVer0Cmd6InsteadOfDate = true;
        //private byte special_marker_recv = 0x72;
        //private byte special_marker_sent = 0x73;
        private byte special_marker_recv = (byte)'r';
        private byte special_marker_sent = (byte)'s';
        private int specialMarkerCount = 10;
        private string[] allPorts;
        private enum cellNames
        {
            Direction,      // 0
            Header,         // 1
            Version,        // 2
            Command,        // 3
            Length,         // 4
            CMDData,        // 5
            CMDInfo,        // 6
            DPid,           // 7
            DPType,         // 8
            DPDataLength,   // 9
            DPData,         // 10
            DPInfo,         // 11
            Checksum,       // 12
        }
        Dictionary<int, string> cmdNamesMap = new Dictionary<int, string>
        {
            { 0, "Heartbeat" },
            { 1, "Product" },
            { 2, "McuConf" },
            { 3, "Network status" },
            { 4, "Reset Wi-Fi connection" },
            { 5, "Reset Wi-Fi init pairing mode" },
            { 6, "Send commands" },
            { 8, "Query DP Status" },
            { 10, "Update MCU firmware" },
            { 12, "Get GMT time" },
            { 28, "Get local time" },
            { 34, "Report status" }
        };
        private SinglePort portRX, portTX;

        private Dictionary<int, IDTracker> vars = [];
        private IDsTracker tracker;
        private DataGridViewRow DGPrintLineHex = new();
        private DatapointDecoder.MessageDecoder dpDecoder;
        private CommandDecoder.MessageDecoder cmdDecoder;

        public FormTuyaMCUAnalyzer()
        {
            InitializeComponent();
        }

        private string getSpecialMarker(ref List<byte> p)
        {
            if (p.Count < specialMarkerCount)
                return "";
            for (int i = 0; i < specialMarkerCount; i++)
            {
                if (p[0] != p[i])
                    return "";
            }
            string r = "";
            if (p[0] == special_marker_recv)
                r = "IN";
            else if (p[0] == special_marker_sent)
                r = "OUT";
            if (r.Length > 0)
            {
                p.RemoveRange(0, specialMarkerCount);
                return r;
            }
            return "";
        }
        //
        //
        //
        private List<byte> getNextPacket(ref List<byte> p)
        {
            for (int i = 0; i < p.Count - 6; i++)
            {
                if (p[i] == 0x55 && p[i + 1] == 0xAA)
                {
                    byte ver = p[i + 2];
                    byte cmd = p[i + 3];
                    byte lenA = p[i + 4];
                    byte lenB = p[i + 5];
                    byte dataOrSum = p[i + 6];
                    int end = lenB + 7;
                    if (i + end > p.Count)
                    {
                        // futher part of packet is missing
                        break;
                    }
                    int maxToGet = p.Count - i;
                    if (end > maxToGet)
                        end = maxToGet;
                    List<byte> ret = p.GetRange(i, end);
                    p.RemoveRange(0, end + i);
                    return ret;
                }

            }
            p.Clear();
            return null;
        }
        //
        //
        //
        private string JoinDecodedInfo(Dictionary<string, Object> decodedMessage)
        {
            string result = "";
            foreach (var item in decodedMessage)
            {
                result += item.Key + " " + item.Value + "\n";
            }
            return (result);
        }
        //
        //
        //

        private void parseDPData(List<byte> p, Dictionary<int, IDTracker> vars, int ofs = 6)
        {
            bool bHasColor = false;
            Color col = Color.Black;
            string messageString = string.Join("", p.Skip(ofs).Select(b => b.ToString("X2")));
            string contentString = "";
            Dictionary<string, Object> decodedMessage = [];

            // With loaded datapoint engine
            if (dpDecoder != null)
            {
                try
                {
                    decodedMessage = dpDecoder.Decode(messageString);
                }
                catch (ArgumentException e)
                {
                    contentString = e.Message;
                }
                contentString = JoinDecodedInfo(decodedMessage);
            }
            else
            {
                while (ofs + 4 < p.Count)
                {
                    int sectorLen = p[ofs + 2] << 8 | p[ofs + 3];
                    int dpId = p[ofs];
                    TuyaType dataType = (TuyaType)p[ofs + 1];

                    if (contentString.Length > 0)
                        contentString += ",";
                    contentString += "dpId=" + dpId;
                    contentString += " ";
                    contentString += dataType.ToString();
                    contentString += " ";
                    if (sectorLen == 1)
                    {
                        int iVal = (int)p[ofs + 4];
                        contentString += "V=" + iVal;
                        tracker.addValueInt(dpId, dataType, iVal, vars);
                    }
                    else if (sectorLen == 4)
                    {
                        int iVal = p[ofs + 4] << 24 | p[ofs + 5] << 16 | p[ofs + 6] << 8 | p[ofs + 7];
                        contentString += "V=" + iVal;
                        tracker.addValueInt(dpId, dataType, iVal, vars);
                    }
                    else
                    {
                        string varStr = "";
                        string strDataForColor = "";
                        for (int si = 0; si < sectorLen; si++)
                        {
                            byte b = p[ofs + si + 4];
                            strDataForColor += Convert.ToChar(b);
                            if (dataType == TuyaType.Str && checkBoxStrTypeAsBytes.Checked == false)
                            {
                                // ascii string
                                varStr += Convert.ToChar(p[ofs + si + 4]);
                            }
                            else
                            {
                                if (si != 0)
                                    varStr += " ";
                                varStr += p[ofs + si + 4].ToString("X2");
                            }
                        }
                        tracker.addValueStr(dpId, dataType, varStr.Replace(" ", ""), vars);
                        contentString += "V=" + varStr;
                        if (checkBoxDecodeColors.Checked && parseTuyaColor(strDataForColor, out col))
                        {
                            bHasColor = true;
                        }
                    }
                    ofs += (4 + sectorLen);
                }
            }
            if (bHasColor)
            {
                bHasColor = false;
                DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = contentString + " Col: ■";
                DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = col;
            }
            else
            {
                DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = contentString;
                DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = Color.Black;
            }
        }
        //
        //
        //

        private void displayPacket(List<byte> p, Dictionary<int, IDTracker> vars)
        {
            string messageString = string.Join("", p.Skip(2).Select(b => b.ToString("X2")));
            string contentString = "";
            Dictionary<string, Object> decodedMessage = [];
            // cmd decoder engine loaded
            byte ver = p[2];
            byte cmd = p[3];
            byte lenA = p[4];
            byte lenB = p[5];
            string s = "";
            int baseOfs = 6;
            int bDateValid = p[baseOfs + 0]; // bDateValid

            if (cmdDecoder != null)
            {
                DGPrintLineHex.Cells[(int)cellNames.Header].Value = p[0].ToString("X2") + " " + p[1].ToString("X2");
                DGPrintLineHex.Cells[(int)cellNames.Header].Style.ForeColor = Color.Black;
                DGPrintLineHex.Cells[(int)cellNames.Version].Value = cmdDecoder.Dump_Version(messageString);
                DGPrintLineHex.Cells[(int)cellNames.Version].Style.ForeColor = Color.Magenta;
                DGPrintLineHex.Cells[(int)cellNames.Command].Value = cmdDecoder.Dump_Command(messageString);
                DGPrintLineHex.Cells[(int)cellNames.Command].Style.ForeColor = Color.Red;
                DGPrintLineHex.Cells[(int)cellNames.Length].Value = cmdDecoder.Dump_Datalen(messageString);
                DGPrintLineHex.Cells[(int)cellNames.Length].Style.ForeColor = Color.Green;
                DGPrintLineHex.Cells[(int)cellNames.CMDData].Value = cmdDecoder.Dump_Data(messageString);
                DGPrintLineHex.Cells[(int)cellNames.CMDData].Style.ForeColor = Color.DarkGray;
                try
                {
                    decodedMessage = cmdDecoder.Decode(messageString);
                    DGPrintLineHex.Cells[(int)cellNames.CMDInfo].Value = JoinDecodedInfo(decodedMessage);
                }
                catch (Exception e)
                {
                    DGPrintLineHex.Cells[(int)cellNames.CMDInfo].Value = "Unknown Cmd. " + e.Message + " Check XML";
                }

                // If Datapoints present
                if (decodedMessage.TryGetValue("Datapoints", out var value))
                {
                    string dp_value = value.ToString();
                    DGPrintLineHex.Cells[(int)cellNames.DPid].Value = dp_value[0..2] + " (" + Convert.ToInt16(dp_value[0..2], 16).ToString() + ")";
                    DGPrintLineHex.Cells[(int)cellNames.DPType].Value = dp_value[2..4];
                    DGPrintLineHex.Cells[(int)cellNames.DPDataLength].Value = dp_value[4..8];
                    DGPrintLineHex.Cells[(int)cellNames.DPData].Value = dp_value.Substring(8, 2 * Convert.ToInt16(dp_value[4..8], 16));

                    try
                    {
                        var dp_decodedMessage = dpDecoder.Decode(dp_value);

                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = JoinDecodedInfo(dp_decodedMessage);
                    }
                    catch (ArgumentException fex)
                    {
                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = fex.Message + " Check XML";
                    }
                }
            }
            else // old Version
            {
                DGPrintLineHex.Cells[(int)cellNames.Header].Value = p[0].ToString("X2") + " " + p[1].ToString("X2");
                DGPrintLineHex.Cells[(int)cellNames.Header].Style.ForeColor = Color.Black;
                DGPrintLineHex.Cells[(int)cellNames.Version].Value = p[2].ToString("X2");
                DGPrintLineHex.Cells[(int)cellNames.Version].Style.ForeColor = Color.Magenta;
                DGPrintLineHex.Cells[(int)cellNames.Command].Value = p[3].ToString("X2");
                DGPrintLineHex.Cells[(int)cellNames.Command].Style.ForeColor = Color.Red;
                DGPrintLineHex.Cells[(int)cellNames.Length].Value = p[4].ToString("X2") + " " + p[5].ToString("X2");
                DGPrintLineHex.Cells[(int)cellNames.Length].Style.ForeColor = Color.Green;
                // https://images.tuyacn.com/smart/aircondition/Guide-to-Interworking-with-the-Tuya-MCU.pdf
                switch (cmd)
                {
                    case 1:
                        string str = ASCIIEncoding.ASCII.GetString(p.ToArray(), 6, p.Count - 7);
                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = str;
                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = Color.Gray;
                        break;

                    case 0x05:
                    case 0x06:
                    case 0x08:
                    case 0x10:
                    case 0x1c:
                        if (cmd == 0x10 && ver == 0)
                        {
                            baseOfs += 2;
                        }
                        if (bDateValid == 1)
                        {
                            int year = p[baseOfs + 1]; //  year
                            int month = p[baseOfs + 2]; //  month
                            int day = p[baseOfs + 3]; //  day
                            int hour = p[baseOfs + 4]; //  hour
                            int minute = p[baseOfs + 5]; //  minute
                                                         // NOTE: some packets don't have second here?
                            int second = p[baseOfs + 6]; //  second

                            DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = "bOk=" + bDateValid + " " + year + "/" + month + "/" + day + " " + hour + ":" + minute + ":" + second;
                            DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = Color.Gray;
                        }
                        else
                        {
                            DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = "INVALID date";
                            DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = Color.Gray;
                        }
                        break;

                    // Handle Command with Datapoint in payload. Dump data

                    case 7:
                    case 0x22:
                        int ofs = 6;
                        while (ofs + 4 < p.Count)
                        {
                            int sectorLen = p[ofs + 2] << 8 | p[ofs + 3];
                            int dpId = p[ofs];

                            DGPrintLineHex.Cells[(int)cellNames.DPid].Value = p[ofs].ToString("X2");
                            DGPrintLineHex.Cells[(int)cellNames.DPid].Style.ForeColor = Color.Black;
                            DGPrintLineHex.Cells[(int)cellNames.DPType].Value = p[ofs + 1].ToString("X2");
                            DGPrintLineHex.Cells[(int)cellNames.DPType].Style.ForeColor = Color.Green;
                            DGPrintLineHex.Cells[(int)cellNames.DPDataLength].Value = p[ofs + 2].ToString("X2") + " " + p[ofs + 3].ToString("X2");
                            DGPrintLineHex.Cells[(int)cellNames.DPDataLength].Style.ForeColor = Color.Black;
                            int dataType = p[ofs + 1];

                            if (sectorLen == 1)
                            {
                                int iVal = (int)p[ofs + 4];
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Value = iVal.ToString("X2");
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Style.ForeColor = Color.Orange;
                            }
                            else if (sectorLen == 4)
                            {
                                int iVal = p[ofs + 4] << 24 | p[ofs + 5] << 16 | p[ofs + 6] << 8 | p[ofs + 7];
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Value = iVal.ToString("X8");
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Style.ForeColor = Color.Orange;
                            }
                            else
                            {
                                string varStr = "";
                                for (int si = 0; si < sectorLen; si++)
                                {
                                    if (si != 0)
                                        varStr += "";
                                    varStr += p[ofs + si + 4].ToString("X2");
                                }
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Value = varStr;
                                DGPrintLineHex.Cells[(int)cellNames.DPData].Style.ForeColor = Color.Orange;
                            }
                            ofs += (4 + sectorLen);
                        }
                        parseDPData(p, vars);
                        break;
                    default:
                        for (int i = 6; i < p.Count - 1; i++)
                        {
                            s += p[i].ToString("X2");
                            s += "";
                        }
                        DGPrintLineHex.Cells[(int)cellNames.DPData].Value = s;
                        DGPrintLineHex.Cells[(int)cellNames.DPData].Style.ForeColor = Color.Gray;
                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Value = GetStringForNumber(cmd, cmdNamesMap);
                        DGPrintLineHex.Cells[(int)cellNames.DPInfo].Style.ForeColor = Color.Red;
                        break;
                }
                // 
            }

            DGPrintLineHex.Cells[(int)cellNames.Checksum].Value = p[p.Count - 1].ToString("X2");
            DGPrintLineHex.Cells[(int)cellNames.Checksum].Style.ForeColor = Color.Black;

            dataGridViewDecoded.Rows.AddRange(new DataGridViewRow[] { DGPrintLineHex });
        }


        // Handle Command with Datapoint in payload. Decode them

        //
        //
        //


        // 1. Step: Fill Hex Dump Window (Textbox)
        //
        //
        private void refresh()
        {
            int cursorPosition = richTextBoxSrc.SelectionStart;
            int currentLineIndex = richTextBoxSrc.GetLineFromCharIndex(cursorPosition);
            tracker = new IDsTracker();
            string[] lines = richTextBoxSrc.Lines;
            string text = "";
            List<byte> r = new List<byte>();
            List<byte> packet = null;
            string ch;
            byte value;
            string comment;

            // Fetch 2 Textlines from Dump window
            if (lines.Length > 2)
            {
                text = lines[currentLineIndex - 2] + '\n' + lines[currentLineIndex - 1];
            }
            // Analyse text
            for (int i = 0; i < text.Length;)
            {
                // "//" detection in text -- comment analyse regarding direction
                if (text[i] == '/' && i < text.Length - 1 && text[i + 1] == '/')
                {
                    // wait for 2 complete lines
                    if (i < text.Length - 2)
                    {
                        if (text[i + 2] == 'S')
                        {
                            for (int j = 0; j < specialMarkerCount; j++)
                            {
                                r.Add(special_marker_sent);
                            }
                        }
                        if (text[i + 2] == 'R')
                        {
                            for (int j = 0; j < specialMarkerCount; j++)
                            {
                                r.Add(special_marker_recv);
                            }
                        }
                    }
                    // ignore all other char in comment line until CR
                    while (i < text.Length)
                    {
                        if (text[i] == '\n')
                        {
                            break;
                        }
                        i++;
                    }
                    continue;
                }
                // ignore space, CR, tabs
                if (text[i] == ' ' || text[i] == '\n' || text[i] == '\r' || text[i] == '\t')
                {
                    i++;
                    continue;
                }
                // Convert text line into byte message
                try
                {
                    ch = text.Substring(i, 2);
                    value = Convert.ToByte(ch, 16);
                    r.Add(value);
                    i += 2;
                }
                catch (Exception)
                {
                    i++;
                }
            }

            // Recieve Loop....
            while (true)
            {
                comment = getSpecialMarker(ref r);
                packet = getNextPacket(ref r);
                if (packet == null)
                {
                    break;
                }
                if (checkBoxHIdeHeartbeat.Checked)
                {
                    if (packet[3] == 0)
                    {
                        continue;
                    }
                }
                if (checkBoxHideWiFiState.Checked)
                {
                    if (packet[3] == 3)
                    {
                        continue;
                    }
                }
                if (checkBoxHideDate.Checked)
                {
                    if (packet[3] == 0x1C)
                    {
                        continue;
                    }
                }
                if (comment.Length > 0)
                {
                    DGPrintLineHex = new DataGridViewRow();
                    DGPrintLineHex.CreateCells(dataGridViewDecoded, "", "", "", "", "", "", "", "", "", "", "");
                    DGPrintLineHex.Cells[(int)cellNames.Direction].Value = comment;
                    if (comment == "IN")
                    {
                        DGPrintLineHex.Cells[(int)cellNames.Direction].Style.BackColor = Color.Blue;
                        DGPrintLineHex.Cells[(int)cellNames.Direction].Style.ForeColor = Color.White;
                    }
                    if (comment == "OUT")
                    {
                        DGPrintLineHex.Cells[(int)cellNames.Direction].Style.BackColor = Color.Red;
                        DGPrintLineHex.Cells[(int)cellNames.Direction].Style.ForeColor = Color.White;
                    }
                }
                // 2. Step: Show decoded Informaation in dataGridView 
                dataGridViewDecoded.SuspendLayout(); // Anti flicker

                // Handle packets 
                displayPacket(packet, vars);

                // Scroll to the newly added item (last item in the list)
                dataGridViewDecoded.FirstDisplayedScrollingRowIndex = dataGridViewDecoded.Rows.Count - 1;

                dataGridViewDecoded.ResumeLayout(); // Anti flicker
            }
            tracker.display(listViewAvailableIDs, vars);
        }
        //
        //
        //
        private string findSamplesPath()
        {
            string[] paths = new string[]
            {
                "./samples",
                "../samples",
                "../../samples",
            };
            foreach (string s in paths)
            {
                if (Directory.Exists(s))
                    return s;
            }
            return "";
        }

        static string GetStringForNumber(int number, Dictionary<int, string> map)
        {
            // Prüfen, ob der int-Wert im Dictionary existiert
            if (map.TryGetValue(number, out string value))
            {
                return value; // Gibt den zugeordneten String zurück
            }
            else
            {
                return "Kein zugeordneter String"; // Standardmeldung oder Standardwert
            }
        }

        private string formatByteSize(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private string formatByteSize(string fname)
        {
            long filelen = new FileInfo(fname).Length;
            return formatByteSize(filelen);
        }

        private void scanForExamplesCaptures()
        {
            try
            {
                string samplesDir = findSamplesPath();
                string[] samples = Directory.GetFiles(samplesDir);
                for (int i = 0; i < samples.Length; i++)
                {
                    string path = samples[i];
                    path = path.Replace('/', '\\');
                    string lenStr = formatByteSize(path);
                    var item2 = new ToolStripMenuItem()
                    {
                        Name = "Test",
                        Text = path + "    " + lenStr,
                        Tag = path
                    };
                    item2.Click += exampleClickListener;
                    examplesToolStripMenuItem.DropDownItems.Add(item2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No examples found? Get sample captures from Github!");
            }
        }

        private bool parseTuyaColor(string s, out Color c)
        {
            try
            {
                if (s.Length == 12)
                {
                    string[] substrings = new string[3];
                    for (int i = 0; i < 3; i++)
                    {
                        substrings[i] = s.Substring(i * 4, 4);
                    }
                    int hue = int.Parse(substrings[0], System.Globalization.NumberStyles.HexNumber);
                    int sat1000 = int.Parse(substrings[1], System.Globalization.NumberStyles.HexNumber);
                    int val1000 = int.Parse(substrings[2], System.Globalization.NumberStyles.HexNumber);
                    c = HsvToRgb(hue, sat1000 * 0.001, val1000 * 0.001);
                    return true;
                }
            }
            catch (Exception)
            {
                // TODO: show
            }
            c = Color.Black;
            return false;
        }

        private static Color HsvToRgb(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        // Method to export ListView data to CSV format
        private string ExportListViewToCsv(System.Windows.Forms.DataGridView dataGridView)
        {
            StringBuilder csvBuilder = new StringBuilder();

            // Export header (column names)
            for (int col = 0; col < dataGridView.Columns.Count; col++)
            {
                csvBuilder.Append(EscapeCsvValue(dataGridView.Columns[col].HeaderText));
                if (col < dataGridView.Columns.Count - 1)
                {
                    csvBuilder.Append(",");  // Add comma between columns
                }
            }
            csvBuilder.AppendLine();  // New line after header

            // Export rows
            // foreach (DataGridViewRow row in dataGridView.Rows)
            for (int rowcounter = 0; rowcounter < dataGridView.Rows.Count - 1; rowcounter++) // Letzte Zeile ignorieren wg. NULL
            {
                // Add the first cell value
                csvBuilder.Append(EscapeCsvValue(dataGridView.Rows[rowcounter].Cells[0].Value.ToString()));
                for (int cell = 1; cell < dataGridView.Rows[rowcounter].Cells.Count; cell++)
                {
                    csvBuilder.Append(",");
                    if (dataGridView.Rows[rowcounter].Cells[cell].Value != null)
                    {
                        csvBuilder.Append(EscapeCsvValue(dataGridView.Rows[rowcounter].Cells[cell].Value.ToString()));
                    }
                }
                csvBuilder.AppendLine();  // New line after each row
            }

            return csvBuilder.ToString();
        }

        // Method to escape CSV values (in case they contain commas, quotes, etc.)
        private string EscapeCsvValue(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                // Ersetze alle doppelten Anführungszeichen
                value = value.Replace("\"", "\"\"");

                // Alle Arten von Zeilenumbrüchen entfernen/ersetzen
                value = value.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ");

                // Den Text in doppelte Anführungszeichen einschließen
                return $"\"{value}\"";
            }
            return value;
        }

        private void LoadFileBinary(string fname)
        {
            byte[] bytes = File.ReadAllBytes(fname);
            string data;
            data = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                data += bytes[i].ToString("X2");
            }
            SplitAndProcessString(data, "55AA", "File");
        }

        private void SplitAndProcessString(string inputString, string marker, string origin)
        {
            // Use a regex to find all matches of the pattern including the marker
            string pattern = $"({Regex.Escape(marker)}.*?)(?={marker}|$)"; // Match marker and following content
            MatchCollection matches = Regex.Matches(inputString, pattern);

            // Process each match
            foreach (Match match in matches)
            {
                SetData("//R by " + origin + " ...\n" + match.Value + "\n");
            }
        }

        private void SetData(string data)
        {
            richTextBoxSrc.AppendText(data);
            // refresh();
        }

        private void LoadFileText(string fname)
        {
            string data;
            data = File.ReadAllText(fname);
            SplitAndProcessString(data, "55AA", "File");
        }

        private void LoadFile(string fname)
        {
            string ext = Path.GetExtension(fname);
            if (ext == ".bin")
            {
                LoadFileBinary(fname);
            }
            else
            {
                LoadFileText(fname);
            }
        }

        private bool isTheSame(string[] lines, int ofs)
        {
            if (lines[0].Length - 2 < ofs)
            {
                return false;
            }
            string baseText = lines[0].Substring(ofs, 2);
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i].Length - 2 < ofs)
                {
                    return false;
                }
                if (lines[i].Substring(ofs, 2).CompareTo(baseText) != 0)
                    return false;
            }
            return true;
        }

        private void setDualCaptureEnabled(bool b)
        {
            comboBoxPortRX.Enabled = b;
            comboBoxPortTX.Enabled = b;
            comboBoxBaud.Enabled = b;
            buttonOpenCloseRX.Enabled = b;
            buttonOpenCloseTX.Enabled = b;
            checkBoxPauseUART.Enabled = b;
            if (checkBoxRealtimeDual.Checked != b)
            {
                checkBoxRealtimeDual.Checked = b;
            }
            if (b)
            {
                portRX = new SinglePort(buttonOpenCloseRX, comboBoxPortRX, labelRXStats, addPacketRX, comboBoxBaud);
                portTX = new SinglePort(buttonOpenCloseTX, comboBoxPortTX, labelTXStats, addPacketTX, comboBoxBaud);
            }
        }

        private void addPacket(byte[] data, string comment, string marker, Color c)
        {
            if (checkBoxPauseUART.Checked)
            {
                // ignore
                return;
            }
            string s;
            s = "";
            for (int i = 0; i < data.Length; i++)
            {
                s += data[i].ToString("X2");
            }
            string final = "//" + marker + " " + DateTime.Now + " " + comment + Environment.NewLine
                + s + Environment.NewLine;
            RichTextBoxExtensions.AppendText(richTextBoxSrc, final, c);
            // autoscroll to last line
            richTextBoxSrc.SelectionStart = richTextBoxSrc.Text.Length;
            richTextBoxSrc.ScrollToCaret();
        }

        // called from SinglePort
        private void addPacketRX(byte[] data)
        {
            addPacket(data, "WiFi received:", "R", Color.Blue);
        }

        // called from SinglePort
        private void addPacketTX(byte[] data)
        {
            addPacket(data, "WiFi sent:", "S", Color.Red);
        }

        private void setPorts(string[] newPorts)
        {
            if (allPorts != null)
            {
                if (allPorts.Length == newPorts.Length)
                {
                    bool bChange = false;
                    for (int i = 0; i < allPorts.Length; i++)
                    {
                        if (allPorts[i] != newPorts[i])
                        {
                            bChange = true;
                            break;
                        }
                    }
                    if (bChange == false)
                    {
                        return;
                    }
                }
            }
            allPorts = newPorts;
            updateComboBox(comboBoxPortRX);
            updateComboBox(comboBoxPortTX);
        }

        private void updateComboBox(System.Windows.Forms.ComboBox comboBoxUART)
        {
            string prevPort = "";
            if (comboBoxUART.SelectedIndex != -1)
            {
                prevPort = comboBoxUART.SelectedItem.ToString();
            }
            comboBoxUART.Items.Clear();
            int newIndex = allPorts.Length - 1;
            for (int i = 0; i < allPorts.Length; i++)
            {
                if (prevPort == allPorts[i])
                    newIndex = i;
                comboBoxUART.Items.Add(allPorts[i]);
            }
            if (newIndex != -1)
            {
                comboBoxUART.SelectedIndex = newIndex;
            }
        }

        private void scanForCOMPorts()
        {
            string[] newPorts = SerialPort.GetPortNames();
            setPorts(newPorts);
        }
        //
        // Event handler below
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            DGPrintLineHex.CreateCells(dataGridViewDecoded, "", "", "", "", "", "", "", "", "", "", "");
            dataGridViewDecoded.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDecoded.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridViewDecoded.Update();
            comboBoxBaud.SelectedIndex = 0;
            scanForExamplesCaptures();
            setDualCaptureEnabled(false);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(dataGridViewDecoded, true, null);
            refresh();
        }

        private void exampleClickListener(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            string path = it.Tag as string;
            LoadFile(path);
        }

        private void richTextBoxComparer_TextChanged(object sender, EventArgs e)
        {
            if (refreshingComparer)
                return;
            refreshingComparer = true;
            string text = richTextBoxComparer.Text;
            int at = richTextBoxComparer.SelectionStart;
            richTextBoxComparer.Text = "";
            string[] lines = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int j = 0;
                while (j < line.Length)
                {
                    if (line[j] == ' ')
                    {
                        RichTextBoxExtensions.AppendText(richTextBoxComparer, " ", Color.White);
                        j++;
                        continue;
                    }
                    bool same = isTheSame(lines, j);
                    Color c;
                    if (same)
                    {
                        c = Color.Green;
                    }
                    else
                    {
                        c = Color.Red;
                    }
                    int max = line.Length - j;
                    if (max > 2)
                        max = 2;
                    RichTextBoxExtensions.AppendText(richTextBoxComparer, line.Substring(j, max), c);
                    j += 2;
                }
                RichTextBoxExtensions.AppendText(richTextBoxComparer, Environment.NewLine);
            }
            richTextBoxComparer.SelectionStart = at;
            refreshingComparer = false;
        }

        private void richTextBoxSrcChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void ourForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://elektroda.com");
        }

        private void ourTutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.elektroda.com/rtvforum/forum517.html");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                LoadFileBinary(fileName);
            }
        }

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.bin|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                LoadFileText(fileName);
            }
        }

        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRealtimeDual_CheckedChanged(object sender, EventArgs e)
        {
            setDualCaptureEnabled(checkBoxRealtimeDual.Checked);
            if (!checkBoxRealtimeDual.Checked)
            {
                portRX.closePort();
                portTX.closePort();
            }
        }

        private void checkBoxStrTypeAsBytes_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBoxHIdeHeartbeat_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBoxDecodeColors_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBoxHideWiFiState_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBoxHideDate_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxSrc.Text = "";
            textBox_decode.Text = "";
            dataGridViewDecoded.Rows.Clear();
            if (checkBoxRealtimeDual.Checked)
            {
                portRX.totalBytesReceived = 0;
                portTX.totalBytesReceived = 0;
            }
            vars.Clear();
        }

        private void buttonCopyDecodedToClipboard_Click(object sender, EventArgs e)
        {
            string csv = ExportListViewToCsv(dataGridViewDecoded);

            // Copy the CSV to the clipboard
            Clipboard.SetText(csv);

            MessageBox.Show("Data copied to clipboard.");
        }

        private void buttonCopyRawToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBoxSrc.Text);
                MessageBox.Show("Data copied to clipboard.");
            }
            catch (Exception)
            {
                MessageBox.Show("No data available");
            }
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            string entry = textBox_decode.Text.ToUpper();
            SplitAndProcessString(entry.Replace(" ", string.Empty), "55AA", "Decode entry");
        }

        private void Load_DP_XML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;

                if (Load_DP_XML.BackColor == Color.Green)
                {
                    cmdDecoder = null;
                    Load_DP_XML.BackColor = Color.OrangeRed;
                }
                else
                {
                    (List<DatapointSpec> datapointSpecs, Dictionary<string, DatapointDecoder.EnumSpec> enumSpecs, string name) = DatapointDecoder.SpecificationReader.ReadSpecification(filePath);
                    dpDecoder = new DatapointDecoder.MessageDecoder(datapointSpecs, enumSpecs);
                    if (dpDecoder != null)
                    {
                        Load_DP_XML.BackColor = Color.Green;
                        label_dp_decoder.Text = name;
                    }
                }
            }
        }

        private void Load_CMD_XML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;

                if (Load_CMD_XML.BackColor == Color.Green)
                {
                    cmdDecoder = null;
                    Load_CMD_XML.BackColor = Color.OrangeRed;
                }
                else
                {
                    (List<CommandSpec> cmdSpecs, Dictionary<string, CommandDecoder.EnumSpec> enumSpecs, string name) = CommandDecoder.SpecificationReader.ReadSpecification(filePath);
                    cmdDecoder = new CommandDecoder.MessageDecoder(cmdSpecs, enumSpecs);
                    if (cmdDecoder != null)
                    {
                        Load_CMD_XML.BackColor = Color.Green;
                        label_cmd_decoder.Text = name;
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            scanForCOMPorts();

            portRX?.runFrame();
            portTX?.runFrame();
        }

    }
}

