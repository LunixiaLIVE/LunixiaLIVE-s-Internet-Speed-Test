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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prog_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_RunSpeedTest = new System.Windows.Forms.Button();
            this.dg_ServerView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Interval = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_RunOnce = new System.Windows.Forms.RadioButton();
            this.rad_RunCont = new System.Windows.Forms.RadioButton();
            this.rad_RunNum = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_tests = new System.Windows.Forms.NumericUpDown();
            this.check_Logging = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.fCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ClearOutput = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ServerView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tests)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prog_Progress,
            this.lbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prog_Progress
            // 
            this.prog_Progress.Name = "prog_Progress";
            this.prog_Progress.Size = new System.Drawing.Size(100, 16);
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
            this.btn_RunSpeedTest.Text = "Run";
            this.btn_RunSpeedTest.UseVisualStyleBackColor = true;
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
            this.dg_ServerView.Size = new System.Drawing.Size(340, 173);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 205);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_ServerView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_output);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 179);
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
            this.txt_output.Size = new System.Drawing.Size(350, 193);
            this.txt_output.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Interval);
            this.groupBox1.Location = new System.Drawing.Point(167, 6);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_tests);
            this.groupBox3.Location = new System.Drawing.Point(167, 52);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_FilePath);
            this.groupBox4.Controls.Add(this.btn_SelectFolder);
            this.groupBox4.Controls.Add(this.check_Logging);
            this.groupBox4.Location = new System.Drawing.Point(6, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logging";
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.Enabled = false;
            this.btn_SelectFolder.Location = new System.Drawing.Point(248, 15);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(78, 23);
            this.btn_SelectFolder.TabIndex = 3;
            this.btn_SelectFolder.Text = "Log Location";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_SelectFolder_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Enabled = false;
            this.txt_FilePath.Location = new System.Drawing.Point(6, 42);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(320, 20);
            this.txt_FilePath.TabIndex = 4;
            // 
            // fCCToolStripMenuItem
            // 
            this.fCCToolStripMenuItem.Name = "fCCToolStripMenuItem";
            this.fCCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fCCToolStripMenuItem.Text = "FCC Website";
            this.fCCToolStripMenuItem.Click += new System.EventHandler(this.fCCToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btn_ClearOutput);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btn_RunSpeedTest);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 52);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_ClearOutput
            // 
            this.btn_ClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearOutput.Location = new System.Drawing.Point(267, 19);
            this.btn_ClearOutput.Name = "btn_ClearOutput";
            this.btn_ClearOutput.Size = new System.Drawing.Size(74, 27);
            this.btn_ClearOutput.TabIndex = 5;
            this.btn_ClearOutput.Text = "Clear Output";
            this.btn_ClearOutput.UseVisualStyleBackColor = true;
            this.btn_ClearOutput.Click += new System.EventHandler(this.btn_ClearOutput_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 315);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "LunixiaLIVE\'s Internet Speed Test GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ServerView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_tests)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem fCCToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ClearOutput;
    }
}