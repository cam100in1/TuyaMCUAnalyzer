namespace TuyaMCUAnalyzer
{
    partial class FormTuyaMCUAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTuyaMCUAnalyzer));
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ourForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ourTutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ourYoutubeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            LoadXML = new System.Windows.Forms.Button();
            textBox_decode = new System.Windows.Forms.TextBox();
            cb_decode = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            richTextBoxSrc = new System.Windows.Forms.RichTextBox();
            dataGridViewDecoded = new System.Windows.Forms.DataGridView();
            checkBoxHideDate = new System.Windows.Forms.CheckBox();
            buttonCopyRawToClipboard = new System.Windows.Forms.Button();
            buttonCopyDecodedToClipboard = new System.Windows.Forms.Button();
            checkBoxHideWiFiState = new System.Windows.Forms.CheckBox();
            checkBoxDecodeColors = new System.Windows.Forms.CheckBox();
            checkBoxHIdeHeartbeat = new System.Windows.Forms.CheckBox();
            checkBoxStrTypeAsBytes = new System.Windows.Forms.CheckBox();
            buttonClear = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            checkBoxPauseUART = new System.Windows.Forms.CheckBox();
            labelTXStats = new System.Windows.Forms.Label();
            labelRXStats = new System.Windows.Forms.Label();
            buttonOpenCloseTX = new System.Windows.Forms.Button();
            comboBoxBaud = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            buttonOpenCloseRX = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            comboBoxPortTX = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            comboBoxPortRX = new System.Windows.Forms.ComboBox();
            checkBoxRealtimeDual = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            listViewAvailableIDs = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            type = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            tabPage2 = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            richTextBoxComparer = new System.Windows.Forms.RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            DGCDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDataLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDecoded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCChecksum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDecoded).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(957, 758);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(222, 15);
            label1.TabIndex = 3;
            label1.Text = "VCnt is a number of unique vals received";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, examplesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(1638, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, openTextToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            openToolStripMenuItem.Text = "Open binary..";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openTextToolStripMenuItem
            // 
            openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            openTextToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            openTextToolStripMenuItem.Text = "Open text...";
            openTextToolStripMenuItem.Click += openTextToolStripMenuItem_Click;
            // 
            // examplesToolStripMenuItem
            // 
            examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            examplesToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            examplesToolStripMenuItem.Text = "Examples";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ourForumToolStripMenuItem, ourTutorialsToolStripMenuItem, ourYoutubeChannelToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // ourForumToolStripMenuItem
            // 
            ourForumToolStripMenuItem.Name = "ourForumToolStripMenuItem";
            ourForumToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            ourForumToolStripMenuItem.Text = "Our forum";
            ourForumToolStripMenuItem.Click += ourForumToolStripMenuItem_Click;
            // 
            // ourTutorialsToolStripMenuItem
            // 
            ourTutorialsToolStripMenuItem.Name = "ourTutorialsToolStripMenuItem";
            ourTutorialsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            ourTutorialsToolStripMenuItem.Text = "Our tutorials";
            ourTutorialsToolStripMenuItem.Click += ourTutorialsToolStripMenuItem_Click;
            // 
            // ourYoutubeChannelToolStripMenuItem
            // 
            ourYoutubeChannelToolStripMenuItem.Name = "ourYoutubeChannelToolStripMenuItem";
            ourYoutubeChannelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            ourYoutubeChannelToolStripMenuItem.Text = "Our Youtube Channel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Raw packets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 725);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(273, 15);
            label3.TabIndex = 6;
            label3.Text = "Tuya packets display. Dump  / Decoded in one line";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 24);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1638, 767);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LoadXML);
            tabPage1.Controls.Add(textBox_decode);
            tabPage1.Controls.Add(cb_decode);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(checkBoxHideDate);
            tabPage1.Controls.Add(buttonCopyRawToClipboard);
            tabPage1.Controls.Add(buttonCopyDecodedToClipboard);
            tabPage1.Controls.Add(checkBoxHideWiFiState);
            tabPage1.Controls.Add(checkBoxDecodeColors);
            tabPage1.Controls.Add(checkBoxHIdeHeartbeat);
            tabPage1.Controls.Add(checkBoxStrTypeAsBytes);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(1630, 739);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Decode tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LoadXML
            // 
            LoadXML.Location = new System.Drawing.Point(760, 7);
            LoadXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            LoadXML.Name = "LoadXML";
            LoadXML.Size = new System.Drawing.Size(87, 26);
            LoadXML.TabIndex = 23;
            LoadXML.Text = "Load XML";
            LoadXML.UseVisualStyleBackColor = true;
            LoadXML.Click += LoadXML_Click;
            // 
            // textBox_decode
            // 
            textBox_decode.Font = new System.Drawing.Font("Courier New", 8F);
            textBox_decode.Location = new System.Drawing.Point(99, 36);
            textBox_decode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            textBox_decode.Name = "textBox_decode";
            textBox_decode.Size = new System.Drawing.Size(748, 20);
            textBox_decode.TabIndex = 22;
            // 
            // cb_decode
            // 
            cb_decode.Location = new System.Drawing.Point(853, 39);
            cb_decode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cb_decode.Name = "cb_decode";
            cb_decode.Size = new System.Drawing.Size(87, 24);
            cb_decode.TabIndex = 21;
            cb_decode.Text = "Decode";
            cb_decode.UseVisualStyleBackColor = true;
            cb_decode.Click += cb_decode_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            splitContainer1.Location = new System.Drawing.Point(2, 67);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBoxSrc);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewDecoded);
            splitContainer1.Size = new System.Drawing.Size(1197, 643);
            splitContainer1.SplitterDistance = 316;
            splitContainer1.TabIndex = 19;
            // 
            // richTextBoxSrc
            // 
            richTextBoxSrc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxSrc.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBoxSrc.Location = new System.Drawing.Point(0, 0);
            richTextBoxSrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBoxSrc.Name = "richTextBoxSrc";
            richTextBoxSrc.ReadOnly = true;
            richTextBoxSrc.Size = new System.Drawing.Size(1192, 314);
            richTextBoxSrc.TabIndex = 10;
            richTextBoxSrc.Text = "";
            richTextBoxSrc.TextChanged += richTextBoxSrcChanged;
            // 
            // dataGridViewDecoded
            // 
            dataGridViewDecoded.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewDecoded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDecoded.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewDecoded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewDecoded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDecoded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DGCDirection, DGCHeader, DGCVersion, DGCCommand, DGCLenght, DGCDPid, DGCType, DGCDataLen, DGCData, DGCDecoded, DGCChecksum });
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDecoded.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDecoded.Location = new System.Drawing.Point(-2, 5);
            dataGridViewDecoded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewDecoded.Name = "dataGridViewDecoded";
            dataGridViewDecoded.RowHeadersVisible = false;
            dataGridViewDecoded.RowHeadersWidth = 62;
            dataGridViewDecoded.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDecoded.Size = new System.Drawing.Size(1191, 305);
            dataGridViewDecoded.TabIndex = 23;
            // 
            // checkBoxHideDate
            // 
            checkBoxHideDate.AutoSize = true;
            checkBoxHideDate.Location = new System.Drawing.Point(405, 11);
            checkBoxHideDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxHideDate.Name = "checkBoxHideDate";
            checkBoxHideDate.Size = new System.Drawing.Size(78, 19);
            checkBoxHideDate.TabIndex = 18;
            checkBoxHideDate.Text = "Hide Date";
            checkBoxHideDate.UseVisualStyleBackColor = true;
            checkBoxHideDate.CheckedChanged += checkBoxHideDate_CheckedChanged;
            // 
            // buttonCopyRawToClipboard
            // 
            buttonCopyRawToClipboard.Location = new System.Drawing.Point(946, 7);
            buttonCopyRawToClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonCopyRawToClipboard.Name = "buttonCopyRawToClipboard";
            buttonCopyRawToClipboard.Size = new System.Drawing.Size(235, 26);
            buttonCopyRawToClipboard.TabIndex = 17;
            buttonCopyRawToClipboard.Text = "Copy raw to clipboard";
            buttonCopyRawToClipboard.UseVisualStyleBackColor = true;
            buttonCopyRawToClipboard.Click += buttonCopyRawToClipboard_Click;
            // 
            // buttonCopyDecodedToClipboard
            // 
            buttonCopyDecodedToClipboard.Location = new System.Drawing.Point(946, 38);
            buttonCopyDecodedToClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonCopyDecodedToClipboard.Name = "buttonCopyDecodedToClipboard";
            buttonCopyDecodedToClipboard.Size = new System.Drawing.Size(235, 26);
            buttonCopyDecodedToClipboard.TabIndex = 16;
            buttonCopyDecodedToClipboard.Text = "Copy decoded to clipboard CSV";
            buttonCopyDecodedToClipboard.UseVisualStyleBackColor = true;
            buttonCopyDecodedToClipboard.Click += buttonCopyDecodedToClipboard_Click;
            // 
            // checkBoxHideWiFiState
            // 
            checkBoxHideWiFiState.AutoSize = true;
            checkBoxHideWiFiState.Location = new System.Drawing.Point(288, 11);
            checkBoxHideWiFiState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxHideWiFiState.Name = "checkBoxHideWiFiState";
            checkBoxHideWiFiState.Size = new System.Drawing.Size(101, 19);
            checkBoxHideWiFiState.TabIndex = 15;
            checkBoxHideWiFiState.Text = "Hide Net state";
            checkBoxHideWiFiState.UseVisualStyleBackColor = true;
            checkBoxHideWiFiState.CheckedChanged += checkBoxHideWiFiState_CheckedChanged;
            // 
            // checkBoxDecodeColors
            // 
            checkBoxDecodeColors.AutoSize = true;
            checkBoxDecodeColors.Checked = true;
            checkBoxDecodeColors.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxDecodeColors.Location = new System.Drawing.Point(495, 11);
            checkBoxDecodeColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxDecodeColors.Name = "checkBoxDecodeColors";
            checkBoxDecodeColors.Size = new System.Drawing.Size(131, 19);
            checkBoxDecodeColors.TabIndex = 14;
            checkBoxDecodeColors.Text = "Decode Tuya Colors";
            checkBoxDecodeColors.UseVisualStyleBackColor = true;
            checkBoxDecodeColors.CheckedChanged += checkBoxDecodeColors_CheckedChanged;
            // 
            // checkBoxHIdeHeartbeat
            // 
            checkBoxHIdeHeartbeat.AutoSize = true;
            checkBoxHIdeHeartbeat.Location = new System.Drawing.Point(169, 11);
            checkBoxHIdeHeartbeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxHIdeHeartbeat.Name = "checkBoxHIdeHeartbeat";
            checkBoxHIdeHeartbeat.Size = new System.Drawing.Size(104, 19);
            checkBoxHIdeHeartbeat.TabIndex = 13;
            checkBoxHIdeHeartbeat.Text = "Hide heartbeat";
            checkBoxHIdeHeartbeat.UseVisualStyleBackColor = true;
            checkBoxHIdeHeartbeat.CheckedChanged += checkBoxHIdeHeartbeat_CheckedChanged;
            // 
            // checkBoxStrTypeAsBytes
            // 
            checkBoxStrTypeAsBytes.AutoSize = true;
            checkBoxStrTypeAsBytes.Location = new System.Drawing.Point(9, 11);
            checkBoxStrTypeAsBytes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxStrTypeAsBytes.Name = "checkBoxStrTypeAsBytes";
            checkBoxStrTypeAsBytes.Size = new System.Drawing.Size(151, 19);
            checkBoxStrTypeAsBytes.TabIndex = 12;
            checkBoxStrTypeAsBytes.Text = "Display STR type as hex ";
            checkBoxStrTypeAsBytes.UseVisualStyleBackColor = true;
            checkBoxStrTypeAsBytes.CheckedChanged += checkBoxStrTypeAsBytes_CheckedChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new System.Drawing.Point(853, 7);
            buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(87, 26);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(checkBoxRealtimeDual);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(listViewAvailableIDs);
            groupBox1.Location = new System.Drawing.Point(1207, 4);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Size = new System.Drawing.Size(408, 711);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "COM and Statistic";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(checkBoxPauseUART);
            panel1.Controls.Add(labelTXStats);
            panel1.Controls.Add(labelRXStats);
            panel1.Controls.Add(buttonOpenCloseTX);
            panel1.Controls.Add(comboBoxBaud);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonOpenCloseRX);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBoxPortTX);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxPortRX);
            panel1.Location = new System.Drawing.Point(21, 47);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(358, 178);
            panel1.TabIndex = 9;
            // 
            // checkBoxPauseUART
            // 
            checkBoxPauseUART.AutoSize = true;
            checkBoxPauseUART.Location = new System.Drawing.Point(8, 154);
            checkBoxPauseUART.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxPauseUART.Name = "checkBoxPauseUART";
            checkBoxPauseUART.Size = new System.Drawing.Size(213, 19);
            checkBoxPauseUART.TabIndex = 10;
            checkBoxPauseUART.Text = "Pause capture (but keep port inuse)";
            checkBoxPauseUART.UseVisualStyleBackColor = true;
            // 
            // labelTXStats
            // 
            labelTXStats.AutoSize = true;
            labelTXStats.Location = new System.Drawing.Point(5, 99);
            labelTXStats.Name = "labelTXStats";
            labelTXStats.Size = new System.Drawing.Size(47, 15);
            labelTXStats.TabIndex = 9;
            labelTXStats.Text = "TX stats";
            // 
            // labelRXStats
            // 
            labelRXStats.AutoSize = true;
            labelRXStats.Location = new System.Drawing.Point(5, 43);
            labelRXStats.Name = "labelRXStats";
            labelRXStats.Size = new System.Drawing.Size(48, 15);
            labelRXStats.TabIndex = 8;
            labelRXStats.Text = "RX stats";
            // 
            // buttonOpenCloseTX
            // 
            buttonOpenCloseTX.Location = new System.Drawing.Point(181, 64);
            buttonOpenCloseTX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonOpenCloseTX.Name = "buttonOpenCloseTX";
            buttonOpenCloseTX.Size = new System.Drawing.Size(87, 26);
            buttonOpenCloseTX.TabIndex = 7;
            buttonOpenCloseTX.Text = "Open";
            buttonOpenCloseTX.UseVisualStyleBackColor = true;
            // 
            // comboBoxBaud
            // 
            comboBoxBaud.FormattingEnabled = true;
            comboBoxBaud.Items.AddRange(new object[] { "9600", "115200" });
            comboBoxBaud.Location = new System.Drawing.Point(68, 118);
            comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxBaud.Name = "comboBoxBaud";
            comboBoxBaud.Size = new System.Drawing.Size(105, 23);
            comboBoxBaud.TabIndex = 6;
            comboBoxBaud.SelectedIndexChanged += comboBoxBaud_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(5, 121);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 15);
            label8.TabIndex = 5;
            label8.Text = "Baud:";
            // 
            // buttonOpenCloseRX
            // 
            buttonOpenCloseRX.Location = new System.Drawing.Point(181, 13);
            buttonOpenCloseRX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonOpenCloseRX.Name = "buttonOpenCloseRX";
            buttonOpenCloseRX.Size = new System.Drawing.Size(87, 26);
            buttonOpenCloseRX.TabIndex = 4;
            buttonOpenCloseRX.Text = "Open";
            buttonOpenCloseRX.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(5, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 15);
            label7.TabIndex = 3;
            label7.Text = "WiFi TX:";
            // 
            // comboBoxPortTX
            // 
            comboBoxPortTX.FormattingEnabled = true;
            comboBoxPortTX.Location = new System.Drawing.Point(68, 66);
            comboBoxPortTX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxPortTX.Name = "comboBoxPortTX";
            comboBoxPortTX.Size = new System.Drawing.Size(105, 23);
            comboBoxPortTX.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 15);
            label6.TabIndex = 1;
            label6.Text = "WiFi RX:";
            // 
            // comboBoxPortRX
            // 
            comboBoxPortRX.FormattingEnabled = true;
            comboBoxPortRX.Location = new System.Drawing.Point(68, 13);
            comboBoxPortRX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxPortRX.Name = "comboBoxPortRX";
            comboBoxPortRX.Size = new System.Drawing.Size(105, 23);
            comboBoxPortRX.TabIndex = 0;
            // 
            // checkBoxRealtimeDual
            // 
            checkBoxRealtimeDual.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkBoxRealtimeDual.AutoSize = true;
            checkBoxRealtimeDual.Location = new System.Drawing.Point(36, 17);
            checkBoxRealtimeDual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxRealtimeDual.Name = "checkBoxRealtimeDual";
            checkBoxRealtimeDual.Size = new System.Drawing.Size(209, 19);
            checkBoxRealtimeDual.TabIndex = 8;
            checkBoxRealtimeDual.Text = "Realtime Dual UART Capture Mode";
            checkBoxRealtimeDual.UseVisualStyleBackColor = true;
            checkBoxRealtimeDual.CheckedChanged += checkBoxRealtimeDual_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 227);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(318, 90);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // listViewAvailableIDs
            // 
            listViewAvailableIDs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            listViewAvailableIDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, type, columnHeader1, columnHeader2 });
            listViewAvailableIDs.Location = new System.Drawing.Point(8, 359);
            listViewAvailableIDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewAvailableIDs.Name = "listViewAvailableIDs";
            listViewAvailableIDs.Size = new System.Drawing.Size(396, 340);
            listViewAvailableIDs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            listViewAvailableIDs.TabIndex = 2;
            listViewAvailableIDs.UseCompatibleStateImageBehavior = false;
            listViewAvailableIDs.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 37;
            // 
            // type
            // 
            type.Text = "Type";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "VCnt";
            columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Values";
            columnHeader2.Width = 181;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(richTextBoxComparer);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(1630, 744);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Compare tool";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(510, 15);
            label5.TabIndex = 1;
            label5.Text = "Here is a simple compare tool. Enter a hex string in each line, the differences will be hightlihtred";
            // 
            // richTextBoxComparer
            // 
            richTextBoxComparer.Dock = System.Windows.Forms.DockStyle.Bottom;
            richTextBoxComparer.Location = new System.Drawing.Point(3, -78);
            richTextBoxComparer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBoxComparer.Name = "richTextBoxComparer";
            richTextBoxComparer.Size = new System.Drawing.Size(1624, 818);
            richTextBoxComparer.TabIndex = 0;
            richTextBoxComparer.Text = "";
            richTextBoxComparer.TextChanged += richTextBoxComparer_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGCDirection
            // 
            DGCDirection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCDirection.FillWeight = 279.1878F;
            DGCDirection.HeaderText = "Direction";
            DGCDirection.MinimumWidth = 8;
            DGCDirection.Name = "DGCDirection";
            DGCDirection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCDirection.Width = 60;
            // 
            // DGCHeader
            // 
            DGCHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCHeader.FillWeight = 82.08122F;
            DGCHeader.HeaderText = "Header";
            DGCHeader.MinimumWidth = 8;
            DGCHeader.Name = "DGCHeader";
            DGCHeader.Width = 60;
            // 
            // DGCVersion
            // 
            DGCVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCVersion.FillWeight = 82.08122F;
            DGCVersion.HeaderText = "Version";
            DGCVersion.MinimumWidth = 8;
            DGCVersion.Name = "DGCVersion";
            DGCVersion.Width = 60;
            // 
            // DGCCommand
            // 
            DGCCommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCCommand.FillWeight = 82.08122F;
            DGCCommand.HeaderText = "Command";
            DGCCommand.MinimumWidth = 8;
            DGCCommand.Name = "DGCCommand";
            DGCCommand.Width = 60;
            // 
            // DGCLenght
            // 
            DGCLenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCLenght.FillWeight = 82.08122F;
            DGCLenght.HeaderText = "Length";
            DGCLenght.MinimumWidth = 8;
            DGCLenght.Name = "DGCLenght";
            DGCLenght.Width = 60;
            // 
            // DGCDPid
            // 
            DGCDPid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCDPid.FillWeight = 82.08122F;
            DGCDPid.HeaderText = "DPid";
            DGCDPid.MinimumWidth = 8;
            DGCDPid.Name = "DGCDPid";
            DGCDPid.Width = 60;
            // 
            // DGCType
            // 
            DGCType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCType.FillWeight = 82.08122F;
            DGCType.HeaderText = "Type";
            DGCType.MinimumWidth = 8;
            DGCType.Name = "DGCType";
            DGCType.Width = 60;
            // 
            // DGCDataLen
            // 
            DGCDataLen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCDataLen.FillWeight = 82.08122F;
            DGCDataLen.HeaderText = "DataLen";
            DGCDataLen.MinimumWidth = 8;
            DGCDataLen.Name = "DGCDataLen";
            DGCDataLen.Width = 60;
            // 
            // DGCData
            // 
            DGCData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCData.FillWeight = 82.08122F;
            DGCData.HeaderText = "Data";
            DGCData.MinimumWidth = 8;
            DGCData.Name = "DGCData";
            // 
            // DGCDecoded
            // 
            DGCDecoded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCDecoded.FillWeight = 82.08122F;
            DGCDecoded.HeaderText = "Decoded";
            DGCDecoded.MinimumWidth = 8;
            DGCDecoded.Name = "DGCDecoded";
            // 
            // DGCChecksum
            // 
            DGCChecksum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCChecksum.FillWeight = 82.08122F;
            DGCChecksum.HeaderText = "Checksum";
            DGCChecksum.MinimumWidth = 8;
            DGCChecksum.Name = "DGCChecksum";
            DGCChecksum.Width = 80;
            // 
            // FormTuyaMCUAnalyzer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1638, 791);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1651, 821);
            Name = "FormTuyaMCUAnalyzer";
            Text = "TuyaMCU Explorer/Analyzer for OpenBeken - Elektroda.com ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDecoded).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxComparer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourTutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourYoutubeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBoxSrc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxStrTypeAsBytes;
        private System.Windows.Forms.CheckBox checkBoxHIdeHeartbeat;
        private System.Windows.Forms.CheckBox checkBoxDecodeColors;
        private System.Windows.Forms.CheckBox checkBoxHideWiFiState;
        private System.Windows.Forms.Button buttonCopyRawToClipboard;
        private System.Windows.Forms.Button buttonCopyDecodedToClipboard;
        private System.Windows.Forms.CheckBox checkBoxHideDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPauseUART;
        private System.Windows.Forms.Label labelTXStats;
        private System.Windows.Forms.Label labelRXStats;
        private System.Windows.Forms.Button buttonOpenCloseTX;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOpenCloseRX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPortTX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPortRX;
        private System.Windows.Forms.CheckBox checkBoxRealtimeDual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewAvailableIDs;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cb_decode;
        private System.Windows.Forms.TextBox textBox_decode;
        private System.Windows.Forms.DataGridView dataGridViewDecoded;
        private System.Windows.Forms.Button LoadXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDataLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDecoded;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCChecksum;
    }
}

