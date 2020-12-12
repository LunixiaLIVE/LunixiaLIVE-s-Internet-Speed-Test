namespace Internet_Speed_Test
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prog_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_RunSpeedTest = new System.Windows.Forms.Button();
            this.dg_ServerView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.check_Logging = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_tests = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_RunNum = new System.Windows.Forms.RadioButton();
            this.rad_RunCont = new System.Windows.Forms.RadioButton();
            this.rad_RunOnce = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Interval = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btn_CopyResultURL = new System.Windows.Forms.Button();
            this.txt_ResultURL = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_PacketLoss = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_Upload = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_Download = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_Jitter = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_Ping = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_ServerID = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_ClearOutput = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_ISP = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.num_Timeout = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ServerView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.fCCToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fCCToolStripMenuItem
            // 
            this.fCCToolStripMenuItem.Name = "fCCToolStripMenuItem";
            this.fCCToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fCCToolStripMenuItem.Text = "FCC Website";
            this.fCCToolStripMenuItem.Click += new System.EventHandler(this.fCCToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prog_Progress,
            this.lbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prog_Progress
            // 
            this.prog_Progress.Name = "prog_Progress";
            this.prog_Progress.Size = new System.Drawing.Size(50, 16);
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(48, 17);
            this.lbl_Status.Text = "Ready...";
            // 
            // btn_RunSpeedTest
            // 
            this.btn_RunSpeedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RunSpeedTest.Location = new System.Drawing.Point(7, 19);
            this.btn_RunSpeedTest.Name = "btn_RunSpeedTest";
            this.btn_RunSpeedTest.Size = new System.Drawing.Size(55, 27);
            this.btn_RunSpeedTest.TabIndex = 2;
            this.btn_RunSpeedTest.Text = "Start";
            this.btn_RunSpeedTest.UseVisualStyleBackColor = true;
            this.btn_RunSpeedTest.Click += new System.EventHandler(this.btn_RunSpeedTest_Click);
            // 
            // dg_ServerView
            // 
            this.dg_ServerView.AllowUserToAddRows = false;
            this.dg_ServerView.AllowUserToDeleteRows = false;
            this.dg_ServerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ServerView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_ServerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ServerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ServerView.Location = new System.Drawing.Point(3, 3);
            this.dg_ServerView.Name = "dg_ServerView";
            this.dg_ServerView.ReadOnly = true;
            this.dg_ServerView.RowHeadersVisible = false;
            this.dg_ServerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ServerView.Size = new System.Drawing.Size(344, 230);
            this.dg_ServerView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 262);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_ServerView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_FilePath);
            this.groupBox4.Controls.Add(this.btn_SelectFolder);
            this.groupBox4.Controls.Add(this.check_Logging);
            this.groupBox4.Location = new System.Drawing.Point(6, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logging";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Enabled = false;
            this.txt_FilePath.Location = new System.Drawing.Point(6, 42);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(288, 20);
            this.txt_FilePath.TabIndex = 4;
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.Enabled = false;
            this.btn_SelectFolder.Location = new System.Drawing.Point(216, 15);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(78, 23);
            this.btn_SelectFolder.TabIndex = 3;
            this.btn_SelectFolder.Text = "Log Location";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_SelectFolder_Click);
            // 
            // check_Logging
            // 
            this.check_Logging.AutoSize = true;
            this.check_Logging.Location = new System.Drawing.Point(6, 19);
            this.check_Logging.Name = "check_Logging";
            this.check_Logging.Size = new System.Drawing.Size(100, 17);
            this.check_Logging.TabIndex = 2;
            this.check_Logging.Text = "Enable Logging";
            this.check_Logging.UseVisualStyleBackColor = true;
            this.check_Logging.CheckedChanged += new System.EventHandler(this.check_Logging_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_tests);
            this.groupBox3.Location = new System.Drawing.Point(167, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 44);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "# of tests (0 for infinite)";
            // 
            // num_tests
            // 
            this.num_tests.Enabled = false;
            this.num_tests.Location = new System.Drawing.Point(6, 19);
            this.num_tests.Name = "num_tests";
            this.num_tests.Size = new System.Drawing.Size(127, 20);
            this.num_tests.TabIndex = 0;
            this.num_tests.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_RunNum);
            this.groupBox2.Controls.Add(this.rad_RunCont);
            this.groupBox2.Controls.Add(this.rad_RunOnce);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed Test Mode";
            // 
            // rad_RunNum
            // 
            this.rad_RunNum.AutoSize = true;
            this.rad_RunNum.Location = new System.Drawing.Point(6, 65);
            this.rad_RunNum.Name = "rad_RunNum";
            this.rad_RunNum.Size = new System.Drawing.Size(137, 17);
            this.rad_RunNum.TabIndex = 2;
            this.rad_RunNum.Text = "Run X Amount of Times";
            this.rad_RunNum.UseVisualStyleBackColor = true;
            this.rad_RunNum.CheckedChanged += new System.EventHandler(this.rad_RunNum_CheckedChanged);
            // 
            // rad_RunCont
            // 
            this.rad_RunCont.AutoSize = true;
            this.rad_RunCont.Location = new System.Drawing.Point(6, 42);
            this.rad_RunCont.Name = "rad_RunCont";
            this.rad_RunCont.Size = new System.Drawing.Size(101, 17);
            this.rad_RunCont.TabIndex = 1;
            this.rad_RunCont.Text = "Run Continuous";
            this.rad_RunCont.UseVisualStyleBackColor = true;
            this.rad_RunCont.CheckedChanged += new System.EventHandler(this.rad_RunCont_CheckedChanged);
            // 
            // rad_RunOnce
            // 
            this.rad_RunOnce.AutoSize = true;
            this.rad_RunOnce.Checked = true;
            this.rad_RunOnce.Location = new System.Drawing.Point(6, 19);
            this.rad_RunOnce.Name = "rad_RunOnce";
            this.rad_RunOnce.Size = new System.Drawing.Size(74, 17);
            this.rad_RunOnce.TabIndex = 0;
            this.rad_RunOnce.TabStop = true;
            this.rad_RunOnce.Text = "Run Once";
            this.rad_RunOnce.UseVisualStyleBackColor = true;
            this.rad_RunOnce.CheckedChanged += new System.EventHandler(this.rad_RunOnce_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Interval);
            this.groupBox1.Location = new System.Drawing.Point(167, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minutes between tests";
            // 
            // num_Interval
            // 
            this.num_Interval.Enabled = false;
            this.num_Interval.Location = new System.Drawing.Point(6, 19);
            this.num_Interval.Name = "num_Interval";
            this.num_Interval.Size = new System.Drawing.Size(127, 20);
            this.num_Interval.TabIndex = 0;
            this.num_Interval.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_output);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(350, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(-4, 0);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_output.Size = new System.Drawing.Size(354, 250);
            this.txt_output.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox13);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(350, 236);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Results";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btn_CopyResultURL);
            this.groupBox12.Controls.Add(this.txt_ResultURL);
            this.groupBox12.Location = new System.Drawing.Point(6, 159);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(324, 45);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Result URL";
            // 
            // btn_CopyResultURL
            // 
            this.btn_CopyResultURL.Location = new System.Drawing.Point(271, 12);
            this.btn_CopyResultURL.Name = "btn_CopyResultURL";
            this.btn_CopyResultURL.Size = new System.Drawing.Size(47, 26);
            this.btn_CopyResultURL.TabIndex = 1;
            this.btn_CopyResultURL.Text = "Copy";
            this.btn_CopyResultURL.UseVisualStyleBackColor = true;
            this.btn_CopyResultURL.Click += new System.EventHandler(this.btn_CopyResultURL_Click);
            // 
            // txt_ResultURL
            // 
            this.txt_ResultURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ResultURL.Location = new System.Drawing.Point(6, 18);
            this.txt_ResultURL.Name = "txt_ResultURL";
            this.txt_ResultURL.Size = new System.Drawing.Size(259, 20);
            this.txt_ResultURL.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_PacketLoss);
            this.groupBox11.Location = new System.Drawing.Point(240, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(90, 45);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Loss %";
            // 
            // txt_PacketLoss
            // 
            this.txt_PacketLoss.Location = new System.Drawing.Point(6, 18);
            this.txt_PacketLoss.Name = "txt_PacketLoss";
            this.txt_PacketLoss.Size = new System.Drawing.Size(78, 20);
            this.txt_PacketLoss.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txt_Upload);
            this.groupBox10.Location = new System.Drawing.Point(164, 57);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(166, 45);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Upload Speed";
            // 
            // txt_Upload
            // 
            this.txt_Upload.Location = new System.Drawing.Point(6, 18);
            this.txt_Upload.Name = "txt_Upload";
            this.txt_Upload.Size = new System.Drawing.Size(154, 20);
            this.txt_Upload.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_Download);
            this.groupBox9.Location = new System.Drawing.Point(6, 57);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(152, 45);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Download Speed";
            // 
            // txt_Download
            // 
            this.txt_Download.Location = new System.Drawing.Point(6, 18);
            this.txt_Download.Name = "txt_Download";
            this.txt_Download.Size = new System.Drawing.Size(140, 20);
            this.txt_Download.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_Jitter);
            this.groupBox8.Location = new System.Drawing.Point(164, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(73, 45);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Jitter (ms)";
            // 
            // txt_Jitter
            // 
            this.txt_Jitter.Location = new System.Drawing.Point(6, 18);
            this.txt_Jitter.Name = "txt_Jitter";
            this.txt_Jitter.Size = new System.Drawing.Size(61, 20);
            this.txt_Jitter.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_Ping);
            this.groupBox7.Location = new System.Drawing.Point(85, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(73, 45);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ping (ms)";
            // 
            // txt_Ping
            // 
            this.txt_Ping.Location = new System.Drawing.Point(6, 18);
            this.txt_Ping.Name = "txt_Ping";
            this.txt_Ping.Size = new System.Drawing.Size(61, 20);
            this.txt_Ping.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_ServerID);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(73, 45);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Server ID";
            // 
            // txt_ServerID
            // 
            this.txt_ServerID.Location = new System.Drawing.Point(6, 18);
            this.txt_ServerID.Name = "txt_ServerID";
            this.txt_ServerID.Size = new System.Drawing.Size(61, 20);
            this.txt_ServerID.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btn_ClearOutput);
            this.groupBox5.Controls.Add(this.btn_Stop);
            this.groupBox5.Controls.Add(this.btn_RunSpeedTest);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 52);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // btn_ClearOutput
            // 
            this.btn_ClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearOutput.Location = new System.Drawing.Point(271, 19);
            this.btn_ClearOutput.Name = "btn_ClearOutput";
            this.btn_ClearOutput.Size = new System.Drawing.Size(74, 27);
            this.btn_ClearOutput.TabIndex = 5;
            this.btn_ClearOutput.Text = "Clear Output";
            this.btn_ClearOutput.UseVisualStyleBackColor = true;
            this.btn_ClearOutput.Click += new System.EventHandler(this.btn_ClearOutput_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(68, 19);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(55, 27);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txt_ISP);
            this.groupBox13.Location = new System.Drawing.Point(6, 108);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(324, 45);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Internet Service Provider";
            // 
            // txt_ISP
            // 
            this.txt_ISP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ISP.Location = new System.Drawing.Point(6, 18);
            this.txt_ISP.Name = "txt_ISP";
            this.txt_ISP.Size = new System.Drawing.Size(312, 20);
            this.txt_ISP.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.num_Timeout);
            this.groupBox14.Location = new System.Drawing.Point(167, 97);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(139, 44);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Timeout (Seconds)";
            // 
            // num_Timeout
            // 
            this.num_Timeout.Enabled = false;
            this.num_Timeout.Location = new System.Drawing.Point(6, 19);
            this.num_Timeout.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.num_Timeout.Name = "num_Timeout";
            this.num_Timeout.Size = new System.Drawing.Size(127, 20);
            this.num_Timeout.TabIndex = 0;
            this.num_Timeout.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 372);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Smexy Internet Speed Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ServerView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_tests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Timeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_RunSpeedTest;
        private System.Windows.Forms.ToolStripProgressBar prog_Progress;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.DataGridView dg_ServerView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_SelectFolder;
        private System.Windows.Forms.CheckBox check_Logging;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_tests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_RunNum;
        private System.Windows.Forms.RadioButton rad_RunCont;
        private System.Windows.Forms.RadioButton rad_RunOnce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_Interval;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem fCCToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_ClearOutput;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btn_CopyResultURL;
        private System.Windows.Forms.TextBox txt_ResultURL;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txt_PacketLoss;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txt_Upload;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_Download;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_Jitter;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_Ping;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_ServerID;
        public System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txt_ISP;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown num_Timeout;
    }
}