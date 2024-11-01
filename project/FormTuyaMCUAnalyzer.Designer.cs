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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            label_dp_decoder = new System.Windows.Forms.Label();
            label_cmd_decoder = new System.Windows.Forms.Label();
            Load_CMD_XML = new System.Windows.Forms.Button();
            Load_DP_XML = new System.Windows.Forms.Button();
            textBox_decode = new System.Windows.Forms.TextBox();
            ButtonDecode = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            richTextBoxSrc = new System.Windows.Forms.RichTextBox();
            dataGridViewDecoded = new System.Windows.Forms.DataGridView();
            DGCDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCCmdData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCCMDInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDataLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDPData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCDPInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DGCChecksum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            label1.Location = new System.Drawing.Point(1367, 1263);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 25);
            label1.TabIndex = 3;
            label1.Text = "VCnt is a number of unique vals received";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, examplesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(2340, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, openTextToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            openToolStripMenuItem.Text = "Open binary..";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openTextToolStripMenuItem
            // 
            openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            openTextToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            openTextToolStripMenuItem.Text = "Open text...";
            openTextToolStripMenuItem.Click += openTextToolStripMenuItem_Click;
            // 
            // examplesToolStripMenuItem
            // 
            examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            examplesToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            examplesToolStripMenuItem.Text = "Examples";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ourForumToolStripMenuItem, ourTutorialsToolStripMenuItem, ourYoutubeChannelToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // ourForumToolStripMenuItem
            // 
            ourForumToolStripMenuItem.Name = "ourForumToolStripMenuItem";
            ourForumToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            ourForumToolStripMenuItem.Text = "Our forum";
            ourForumToolStripMenuItem.Click += ourForumToolStripMenuItem_Click;
            // 
            // ourTutorialsToolStripMenuItem
            // 
            ourTutorialsToolStripMenuItem.Name = "ourTutorialsToolStripMenuItem";
            ourTutorialsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            ourTutorialsToolStripMenuItem.Text = "Our tutorials";
            ourTutorialsToolStripMenuItem.Click += ourTutorialsToolStripMenuItem_Click;
            // 
            // ourYoutubeChannelToolStripMenuItem
            // 
            ourYoutubeChannelToolStripMenuItem.Name = "ourYoutubeChannelToolStripMenuItem";
            ourYoutubeChannelToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            ourYoutubeChannelToolStripMenuItem.Text = "Our Youtube Channel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 68);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 25);
            label2.TabIndex = 5;
            label2.Text = "Raw packets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 1208);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(414, 25);
            label3.TabIndex = 6;
            label3.Text = "Tuya packets display. Dump  / Decoded in one line";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 33);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(2340, 1285);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label_dp_decoder);
            tabPage1.Controls.Add(label_cmd_decoder);
            tabPage1.Controls.Add(Load_CMD_XML);
            tabPage1.Controls.Add(Load_DP_XML);
            tabPage1.Controls.Add(textBox_decode);
            tabPage1.Controls.Add(ButtonDecode);
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
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            tabPage1.Size = new System.Drawing.Size(2332, 1247);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Decode tool";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_dp_decoder
            // 
            label_dp_decoder.AutoSize = true;
            label_dp_decoder.Location = new System.Drawing.Point(1351, 68);
            label_dp_decoder.Name = "label_dp_decoder";
            label_dp_decoder.Size = new System.Drawing.Size(105, 25);
            label_dp_decoder.TabIndex = 26;
            label_dp_decoder.Text = "DP decoder";
            // 
            // label_cmd_decoder
            // 
            label_cmd_decoder.AutoSize = true;
            label_cmd_decoder.Location = new System.Drawing.Point(1351, 22);
            label_cmd_decoder.Name = "label_cmd_decoder";
            label_cmd_decoder.Size = new System.Drawing.Size(122, 25);
            label_cmd_decoder.TabIndex = 25;
            label_cmd_decoder.Text = "CMD decoder";
            // 
            // Load_CMD_XML
            // 
            Load_CMD_XML.BackColor = System.Drawing.Color.OrangeRed;
            Load_CMD_XML.Location = new System.Drawing.Point(1189, 12);
            Load_CMD_XML.Name = "Load_CMD_XML";
            Load_CMD_XML.Size = new System.Drawing.Size(156, 43);
            Load_CMD_XML.TabIndex = 24;
            Load_CMD_XML.Text = "Load CMD XML";
            Load_CMD_XML.UseVisualStyleBackColor = false;
            Load_CMD_XML.Click += Load_CMD_XML_Click;
            // 
            // Load_DP_XML
            // 
            Load_DP_XML.BackColor = System.Drawing.Color.OrangeRed;
            Load_DP_XML.Location = new System.Drawing.Point(1189, 58);
            Load_DP_XML.Name = "Load_DP_XML";
            Load_DP_XML.Size = new System.Drawing.Size(156, 43);
            Load_DP_XML.TabIndex = 23;
            Load_DP_XML.Text = "Load DP XML";
            Load_DP_XML.UseVisualStyleBackColor = false;
            Load_DP_XML.Click += Load_DP_XML_Click;
            // 
            // textBox_decode
            // 
            textBox_decode.Font = new System.Drawing.Font("Courier New", 8F);
            textBox_decode.Location = new System.Drawing.Point(141, 68);
            textBox_decode.Name = "textBox_decode";
            textBox_decode.Size = new System.Drawing.Size(1041, 26);
            textBox_decode.TabIndex = 22;
            // 
            // ButtonDecode
            // 
            ButtonDecode.Location = new System.Drawing.Point(927, 13);
            ButtonDecode.Name = "ButtonDecode";
            ButtonDecode.Size = new System.Drawing.Size(124, 40);
            ButtonDecode.TabIndex = 21;
            ButtonDecode.Text = "Decode";
            ButtonDecode.UseVisualStyleBackColor = true;
            ButtonDecode.Click += ButtonDecode_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(3, 112);
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
            splitContainer1.Size = new System.Drawing.Size(1710, 1079);
            splitContainer1.SplitterDistance = 526;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 19;
            // 
            // richTextBoxSrc
            // 
            richTextBoxSrc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxSrc.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBoxSrc.Location = new System.Drawing.Point(0, 0);
            richTextBoxSrc.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            richTextBoxSrc.Name = "richTextBoxSrc";
            richTextBoxSrc.ReadOnly = true;
            richTextBoxSrc.Size = new System.Drawing.Size(1701, 520);
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
            dataGridViewDecoded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DGCDirection, DGCHeader, DGCVersion, DGCCommand, DGCLenght, DGCCmdData, DGCCMDInfo, DGCDPid, DGCType, DGCDataLen, DGCDPData, DGCDPInfo, DGCChecksum });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDecoded.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDecoded.Location = new System.Drawing.Point(-3, 8);
            dataGridViewDecoded.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            dataGridViewDecoded.Name = "dataGridViewDecoded";
            dataGridViewDecoded.RowHeadersVisible = false;
            dataGridViewDecoded.RowHeadersWidth = 62;
            dataGridViewDecoded.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDecoded.Size = new System.Drawing.Size(1701, 499);
            dataGridViewDecoded.TabIndex = 23;
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
            DGCHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCHeader.Width = 60;
            // 
            // DGCVersion
            // 
            DGCVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCVersion.FillWeight = 82.08122F;
            DGCVersion.HeaderText = "Version";
            DGCVersion.MinimumWidth = 8;
            DGCVersion.Name = "DGCVersion";
            DGCVersion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCVersion.Width = 80;
            // 
            // DGCCommand
            // 
            DGCCommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCCommand.FillWeight = 82.08122F;
            DGCCommand.HeaderText = "Command";
            DGCCommand.MinimumWidth = 8;
            DGCCommand.Name = "DGCCommand";
            DGCCommand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCCommand.Width = 60;
            // 
            // DGCLenght
            // 
            DGCLenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCLenght.FillWeight = 82.08122F;
            DGCLenght.HeaderText = "Length";
            DGCLenght.MinimumWidth = 8;
            DGCLenght.Name = "DGCLenght";
            DGCLenght.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCLenght.Width = 60;
            // 
            // DGCCmdData
            // 
            DGCCmdData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCCmdData.HeaderText = "CmdData";
            DGCCmdData.MinimumWidth = 8;
            DGCCmdData.Name = "DGCCmdData";
            // 
            // DGCCMDInfo
            // 
            DGCCMDInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCCMDInfo.FillWeight = 82.08122F;
            DGCCMDInfo.HeaderText = "CMD Info";
            DGCCMDInfo.MinimumWidth = 8;
            DGCCMDInfo.Name = "DGCCMDInfo";
            // 
            // DGCDPid
            // 
            DGCDPid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCDPid.FillWeight = 82.08122F;
            DGCDPid.HeaderText = "DPid";
            DGCDPid.MinimumWidth = 8;
            DGCDPid.Name = "DGCDPid";
            DGCDPid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCDPid.Width = 60;
            // 
            // DGCType
            // 
            DGCType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCType.FillWeight = 82.08122F;
            DGCType.HeaderText = "DPType";
            DGCType.MinimumWidth = 8;
            DGCType.Name = "DGCType";
            DGCType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCType.Width = 60;
            // 
            // DGCDataLen
            // 
            DGCDataLen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCDataLen.FillWeight = 82.08122F;
            DGCDataLen.HeaderText = "DPDataLen";
            DGCDataLen.MinimumWidth = 8;
            DGCDataLen.Name = "DGCDataLen";
            DGCDataLen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCDataLen.Width = 60;
            // 
            // DGCDPData
            // 
            DGCDPData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCDPData.HeaderText = "DPData";
            DGCDPData.MinimumWidth = 8;
            DGCDPData.Name = "DGCDPData";
            // 
            // DGCDPInfo
            // 
            DGCDPInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            DGCDPInfo.FillWeight = 82.08122F;
            DGCDPInfo.HeaderText = "DP Info";
            DGCDPInfo.MinimumWidth = 8;
            DGCDPInfo.Name = "DGCDPInfo";
            // 
            // DGCChecksum
            // 
            DGCChecksum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DGCChecksum.FillWeight = 82.08122F;
            DGCChecksum.HeaderText = "Checksum";
            DGCChecksum.MinimumWidth = 8;
            DGCChecksum.Name = "DGCChecksum";
            DGCChecksum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DGCChecksum.Width = 80;
            // 
            // checkBoxHideDate
            // 
            checkBoxHideDate.AutoSize = true;
            checkBoxHideDate.Location = new System.Drawing.Point(579, 18);
            checkBoxHideDate.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxHideDate.Name = "checkBoxHideDate";
            checkBoxHideDate.Size = new System.Drawing.Size(117, 29);
            checkBoxHideDate.TabIndex = 18;
            checkBoxHideDate.Text = "Hide Date";
            checkBoxHideDate.UseVisualStyleBackColor = true;
            checkBoxHideDate.CheckedChanged += checkBoxHideDate_CheckedChanged;
            // 
            // buttonCopyRawToClipboard
            // 
            buttonCopyRawToClipboard.Location = new System.Drawing.Point(1484, 12);
            buttonCopyRawToClipboard.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            buttonCopyRawToClipboard.Name = "buttonCopyRawToClipboard";
            buttonCopyRawToClipboard.Size = new System.Drawing.Size(203, 43);
            buttonCopyRawToClipboard.TabIndex = 17;
            buttonCopyRawToClipboard.Text = "Copy raw to clipboard";
            buttonCopyRawToClipboard.UseVisualStyleBackColor = true;
            buttonCopyRawToClipboard.Click += buttonCopyRawToClipboard_Click;
            // 
            // buttonCopyDecodedToClipboard
            // 
            buttonCopyDecodedToClipboard.Location = new System.Drawing.Point(1484, 63);
            buttonCopyDecodedToClipboard.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            buttonCopyDecodedToClipboard.Name = "buttonCopyDecodedToClipboard";
            buttonCopyDecodedToClipboard.Size = new System.Drawing.Size(203, 43);
            buttonCopyDecodedToClipboard.TabIndex = 16;
            buttonCopyDecodedToClipboard.Text = "Copy decoded to clipboard CSV";
            buttonCopyDecodedToClipboard.UseVisualStyleBackColor = true;
            buttonCopyDecodedToClipboard.Click += buttonCopyDecodedToClipboard_Click;
            // 
            // checkBoxHideWiFiState
            // 
            checkBoxHideWiFiState.AutoSize = true;
            checkBoxHideWiFiState.Location = new System.Drawing.Point(411, 18);
            checkBoxHideWiFiState.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxHideWiFiState.Name = "checkBoxHideWiFiState";
            checkBoxHideWiFiState.Size = new System.Drawing.Size(151, 29);
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
            checkBoxDecodeColors.Location = new System.Drawing.Point(707, 18);
            checkBoxDecodeColors.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxDecodeColors.Name = "checkBoxDecodeColors";
            checkBoxDecodeColors.Size = new System.Drawing.Size(197, 29);
            checkBoxDecodeColors.TabIndex = 14;
            checkBoxDecodeColors.Text = "Decode Tuya Colors";
            checkBoxDecodeColors.UseVisualStyleBackColor = true;
            checkBoxDecodeColors.CheckedChanged += checkBoxDecodeColors_CheckedChanged;
            // 
            // checkBoxHIdeHeartbeat
            // 
            checkBoxHIdeHeartbeat.AutoSize = true;
            checkBoxHIdeHeartbeat.Location = new System.Drawing.Point(241, 18);
            checkBoxHIdeHeartbeat.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxHIdeHeartbeat.Name = "checkBoxHIdeHeartbeat";
            checkBoxHIdeHeartbeat.Size = new System.Drawing.Size(155, 29);
            checkBoxHIdeHeartbeat.TabIndex = 13;
            checkBoxHIdeHeartbeat.Text = "Hide heartbeat";
            checkBoxHIdeHeartbeat.UseVisualStyleBackColor = true;
            checkBoxHIdeHeartbeat.CheckedChanged += checkBoxHIdeHeartbeat_CheckedChanged;
            // 
            // checkBoxStrTypeAsBytes
            // 
            checkBoxStrTypeAsBytes.AutoSize = true;
            checkBoxStrTypeAsBytes.Location = new System.Drawing.Point(13, 18);
            checkBoxStrTypeAsBytes.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxStrTypeAsBytes.Name = "checkBoxStrTypeAsBytes";
            checkBoxStrTypeAsBytes.Size = new System.Drawing.Size(230, 29);
            checkBoxStrTypeAsBytes.TabIndex = 12;
            checkBoxStrTypeAsBytes.Text = "Display STR type as hex ";
            checkBoxStrTypeAsBytes.UseVisualStyleBackColor = true;
            checkBoxStrTypeAsBytes.CheckedChanged += checkBoxStrTypeAsBytes_CheckedChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new System.Drawing.Point(1059, 12);
            buttonClear.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(124, 43);
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
            groupBox1.Location = new System.Drawing.Point(1724, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(583, 1185);
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
            panel1.Location = new System.Drawing.Point(30, 78);
            panel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(511, 297);
            panel1.TabIndex = 9;
            // 
            // checkBoxPauseUART
            // 
            checkBoxPauseUART.AutoSize = true;
            checkBoxPauseUART.Location = new System.Drawing.Point(11, 257);
            checkBoxPauseUART.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxPauseUART.Name = "checkBoxPauseUART";
            checkBoxPauseUART.Size = new System.Drawing.Size(317, 29);
            checkBoxPauseUART.TabIndex = 10;
            checkBoxPauseUART.Text = "Pause capture (but keep port inuse)";
            checkBoxPauseUART.UseVisualStyleBackColor = true;
            // 
            // labelTXStats
            // 
            labelTXStats.AutoSize = true;
            labelTXStats.Location = new System.Drawing.Point(7, 165);
            labelTXStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTXStats.Name = "labelTXStats";
            labelTXStats.Size = new System.Drawing.Size(74, 25);
            labelTXStats.TabIndex = 9;
            labelTXStats.Text = "TX stats";
            // 
            // labelRXStats
            // 
            labelRXStats.AutoSize = true;
            labelRXStats.Location = new System.Drawing.Point(7, 72);
            labelRXStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRXStats.Name = "labelRXStats";
            labelRXStats.Size = new System.Drawing.Size(76, 25);
            labelRXStats.TabIndex = 8;
            labelRXStats.Text = "RX stats";
            // 
            // buttonOpenCloseTX
            // 
            buttonOpenCloseTX.Location = new System.Drawing.Point(259, 107);
            buttonOpenCloseTX.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            buttonOpenCloseTX.Name = "buttonOpenCloseTX";
            buttonOpenCloseTX.Size = new System.Drawing.Size(124, 43);
            buttonOpenCloseTX.TabIndex = 7;
            buttonOpenCloseTX.Text = "Open";
            buttonOpenCloseTX.UseVisualStyleBackColor = true;
            // 
            // comboBoxBaud
            // 
            comboBoxBaud.FormattingEnabled = true;
            comboBoxBaud.Items.AddRange(new object[] { "9600", "115200" });
            comboBoxBaud.Location = new System.Drawing.Point(97, 197);
            comboBoxBaud.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            comboBoxBaud.Name = "comboBoxBaud";
            comboBoxBaud.Size = new System.Drawing.Size(148, 33);
            comboBoxBaud.TabIndex = 6;
            comboBoxBaud.SelectedIndexChanged += comboBoxBaud_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 202);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 25);
            label8.TabIndex = 5;
            label8.Text = "Baud:";
            // 
            // buttonOpenCloseRX
            // 
            buttonOpenCloseRX.Location = new System.Drawing.Point(259, 22);
            buttonOpenCloseRX.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            buttonOpenCloseRX.Name = "buttonOpenCloseRX";
            buttonOpenCloseRX.Size = new System.Drawing.Size(124, 43);
            buttonOpenCloseRX.TabIndex = 4;
            buttonOpenCloseRX.Text = "Open";
            buttonOpenCloseRX.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 115);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(75, 25);
            label7.TabIndex = 3;
            label7.Text = "WiFi TX:";
            // 
            // comboBoxPortTX
            // 
            comboBoxPortTX.FormattingEnabled = true;
            comboBoxPortTX.Location = new System.Drawing.Point(97, 110);
            comboBoxPortTX.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            comboBoxPortTX.Name = "comboBoxPortTX";
            comboBoxPortTX.Size = new System.Drawing.Size(148, 33);
            comboBoxPortTX.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 28);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 25);
            label6.TabIndex = 1;
            label6.Text = "WiFi RX:";
            // 
            // comboBoxPortRX
            // 
            comboBoxPortRX.FormattingEnabled = true;
            comboBoxPortRX.Location = new System.Drawing.Point(97, 22);
            comboBoxPortRX.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            comboBoxPortRX.Name = "comboBoxPortRX";
            comboBoxPortRX.Size = new System.Drawing.Size(148, 33);
            comboBoxPortRX.TabIndex = 0;
            // 
            // checkBoxRealtimeDual
            // 
            checkBoxRealtimeDual.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkBoxRealtimeDual.AutoSize = true;
            checkBoxRealtimeDual.Location = new System.Drawing.Point(37, 28);
            checkBoxRealtimeDual.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            checkBoxRealtimeDual.Name = "checkBoxRealtimeDual";
            checkBoxRealtimeDual.Size = new System.Drawing.Size(313, 29);
            checkBoxRealtimeDual.TabIndex = 8;
            checkBoxRealtimeDual.Text = "Realtime Dual UART Capture Mode";
            checkBoxRealtimeDual.UseVisualStyleBackColor = true;
            checkBoxRealtimeDual.CheckedChanged += checkBoxRealtimeDual_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 378);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(483, 150);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // listViewAvailableIDs
            // 
            listViewAvailableIDs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            listViewAvailableIDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, type, columnHeader1, columnHeader2 });
            listViewAvailableIDs.Location = new System.Drawing.Point(11, 598);
            listViewAvailableIDs.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            listViewAvailableIDs.Name = "listViewAvailableIDs";
            listViewAvailableIDs.Size = new System.Drawing.Size(564, 564);
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
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            tabPage2.Size = new System.Drawing.Size(2332, 1247);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Compare tool";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 52);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(762, 25);
            label5.TabIndex = 1;
            label5.Text = "Here is a simple compare tool. Enter a hex string in each line, the differences will be hightlihtred";
            // 
            // richTextBoxComparer
            // 
            richTextBoxComparer.Dock = System.Windows.Forms.DockStyle.Bottom;
            richTextBoxComparer.Location = new System.Drawing.Point(4, -121);
            richTextBoxComparer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            richTextBoxComparer.Name = "richTextBoxComparer";
            richTextBoxComparer.Size = new System.Drawing.Size(2324, 1361);
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
            // FormTuyaMCUAnalyzer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2340, 1318);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            MinimumSize = new System.Drawing.Size(2343, 1308);
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
        private System.Windows.Forms.Button ButtonDecode;
        private System.Windows.Forms.TextBox textBox_decode;
        private System.Windows.Forms.DataGridView dataGridViewDecoded;
        private System.Windows.Forms.Button Load_DP_XML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Load_CMD_XML;
        private System.Windows.Forms.Label label_dp_decoder;
        private System.Windows.Forms.Label label_cmd_decoder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCCmdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCCMDInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDataLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDPData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCDPInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCChecksum;
    }
}

