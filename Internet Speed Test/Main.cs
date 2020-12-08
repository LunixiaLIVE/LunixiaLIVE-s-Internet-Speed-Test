using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Speed_Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (!File.Exists(@".\speedtest.exe"))
            {
                lbl_Status.Text = "Downloading Speedtest.exe from Ookla";
                Application.DoEvents();
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://bintray.com/ookla/download/download_file?file_path=ookla-speedtest-1.0.0-win64.zip", @".\SpeedTest.zip");
                };
                prog_Progress.Value = 100;
                Application.DoEvents();
                prog_Progress.Value = 0;
                Application.DoEvents();
                ZipFile.ExtractToDirectory(@".\SpeedTest.zip", @".\");
            };

            Process procGetServers = new Process();
            procGetServers.StartInfo.FileName = @".\Speedtest.exe";
            procGetServers.StartInfo.Arguments = "--servers --format=csv";
            procGetServers.StartInfo.UseShellExecute = false;
            procGetServers.StartInfo.RedirectStandardOutput = true;
            procGetServers.StartInfo.RedirectStandardError = true;
            procGetServers.Start();
            procGetServers.WaitForExit();

            while(!procGetServers.HasExited)
            {
                Thread.Sleep(1000);
            }

            String procGetServersOutput = procGetServers.StandardOutput.ReadToEnd();
            String procGetServersError = procGetServers.StandardError.ReadToEnd();

            DataTable dt_Servers = new DataTable();
            dt_Servers.Columns.Add("ID", typeof(String));
            dt_Servers.Columns.Add("Name", typeof(String));
            dt_Servers.Columns.Add("Host", typeof(String));
            dt_Servers.Columns.Add("City", typeof(String));
            dt_Servers.Columns.Add("State", typeof(String));
            dt_Servers.Columns.Add("Country", typeof(String));
            
            if (procGetServersOutput.Length > 0)
            {
                foreach (String line in procGetServersOutput.Split(new [] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                {
                    String strTemp = line.ToString().Replace('"', ' ').Trim();
                    if (strTemp.Contains("ID") || strTemp.Length == 0){
                        continue;
                    }
                    Console.WriteLine(strTemp);
                    String[] arrInfo = strTemp.Split(new[] { "," }, StringSplitOptions.None);
                    dt_Servers.Rows.Add(arrInfo[0].Trim(), arrInfo[1].Trim(), arrInfo[5].Trim(), arrInfo[2].Trim(), arrInfo[3].Trim(), arrInfo[4].Trim());
                }   
            }
            dg_ServerView.DataSource = dt_Servers;
            lbl_Status.Text = "Ready...";
            Application.DoEvents();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "--------------------------------\r\n" +
                                  "Author : LunixiaLIVE\r\n\r\n" +
                                  "on:\r\n\r\nYoutube\r\nTwitch\r\nTwitter\r\nInstagram\r\nTikTok\r\nFacebook\r\n\r\n" +
                                  "This app is made possible by Ookla",
                                  "About", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txt_FilePath.Text = folderBrowserDialog1.SelectedPath;
        }
        private void check_Logging_CheckedChanged(object sender, EventArgs e)
        {
                btn_SelectFolder.Enabled = check_Logging.Checked;
                txt_FilePath.Enabled = check_Logging.Checked;
        }
        private void fCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://consumercomplaints.fcc.gov/hc/en-us");
            lbl_Status.Text = "Copied!";
            Application.DoEvents();
        }

        private void rad_RunOnce_CheckedChanged(object sender, EventArgs e)
        {
            num_Interval.Enabled = false;
            num_tests.Enabled = false;
        }

        private void rad_RunCont_CheckedChanged(object sender, EventArgs e)
        {
            num_Interval.Enabled = true;
            num_tests.Enabled = false;
        }

        private void rad_RunNum_CheckedChanged(object sender, EventArgs e)
        {
            num_Interval.Enabled = true;
            num_tests.Enabled = true;
        }
    }
}