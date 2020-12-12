using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Internet_Speed_Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txt_FilePath.Text = Directory.GetCurrentDirectory();
            Application.DoEvents();
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

            String strMonth = DateTime.Now.Month.ToString();
            String strYear = DateTime.Now.Year.ToString();
            String strDay = DateTime.Now.Day.ToString();
            String strTime = DateTime.Now.TimeOfDay.ToString().Substring(0, DateTime.Now.TimeOfDay.ToString().IndexOf("."));
            String strLogFile = strDay + "_" + strMonth + "_" + strYear + "_" + strTime.Replace(":", "-") + ".csv";
            Global.strLogFileName = txt_FilePath.Text + "\\" + strLogFile;

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

            txt_output.Text += procGetServersError;

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
                    String[] arrInfo = strTemp.Split(new[] { "," }, StringSplitOptions.None);
                    dt_Servers.Rows.Add(arrInfo[0].Trim(), arrInfo[1].Trim(), arrInfo[5].Trim(), arrInfo[2].Trim(), arrInfo[3].Trim(), arrInfo[4].Trim());
                }   
            }
            txt_output.Text += "Server List Generated\r\n";
            dg_ServerView.DataSource = dt_Servers;
            lbl_Status.Text = "Ready...";
            dg_ServerView.ClearSelection();
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
            txt_output.Text += "Folder Selected\r\n";
            if(folderBrowserDialog1.SelectedPath == null || folderBrowserDialog1.SelectedPath == "")
            {
                txt_output.Text += "Cancelled\r\n";
            }
            else
            {
                txt_output.Text += folderBrowserDialog1.SelectedPath + "\r\n";
            }
            
        }
        private void check_Logging_CheckedChanged(object sender, EventArgs e)
        {
            btn_SelectFolder.Enabled = check_Logging.Checked;
            txt_FilePath.Enabled = check_Logging.Checked;
            if (check_Logging.Checked)
            {
                txt_output.Text += "Logging Enabled\r\n";
            }
            else
            {
                txt_output.Text += "Logging Disabled\r\n";
            }
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

        private void btn_ClearOutput_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
        }

        private void btn_RunSpeedTest_Click(object sender, EventArgs e)
        {
            Global.Breakout = false;
            tabControl1.SelectTab(tabPage4);
            Application.DoEvents();
            List<int> serverIDlist = new List<int>();
            foreach(DataGridViewTextBoxCell cell in dg_ServerView.SelectedCells)
            {
                if(cell.OwningColumn.Name == "ID")
                {
                    serverIDlist.Add(Convert.ToInt32(cell.Value));
                }
            }
            txt_output.Text += "Servers Selected by ID\r\n";
            foreach (int ID in serverIDlist.ToArray())
            {
                txt_output.Text += (ID + "\r\n");
            }
            foreach(int ID in serverIDlist.ToArray())
            {
                if (rad_RunOnce.Checked)
                {
                    ExecuteProcess(ID);
                }
                if (rad_RunNum.Checked)
                {
                    for(int i = 0; i < Convert.ToInt32(num_tests.Value); i++)
                    {
                        lbl_Status.Text = "Running Speed Test " + (i + 1).ToString() + " of " + Convert.ToInt32(num_tests.Value).ToString();
                        Application.DoEvents();
                        if (Global.Breakout)
                        {
                            prog_Progress.Value = 0;
                            lbl_Status.Text = "Ready...";
                            prog_Progress.Style = ProgressBarStyle.Blocks;
                            Application.DoEvents();
                            return;
                        }
                        ExecuteProcess(ID);
                    }
                }
                if (rad_RunCont.Checked)
                {
                    while(true)
                    {
                        lbl_Status.Text = "Running Continuous Speed Test...";
                        Application.DoEvents();
                        if (Global.Breakout)
                        {
                            prog_Progress.Value = 0;
                            lbl_Status.Text = "Ready...";
                            prog_Progress.Style = ProgressBarStyle.Blocks;
                            Application.DoEvents();
                            return;
                        }
                        ExecuteProcess(ID); ;
                    }
                }
            }
        }
        public void ExecuteProcess(int ServerID)
        {
            if (check_Logging.Checked)
            {
                StreamWriter SR = File.CreateText(Global.strLogFileName);
                SR.WriteLine(Global.strHeaders);
                SR.Close();
            }
            txt_ServerID.Clear();
            txt_ISP.Clear();
            txt_Download.Clear();
            txt_Jitter.Clear();
            txt_Ping.Clear();
            txt_ResultURL.Clear();
            txt_Upload.Clear();
            txt_PacketLoss.Clear();
            Application.DoEvents();
            prog_Progress.Style = ProgressBarStyle.Blocks;
            prog_Progress.Maximum = Convert.ToInt32(num_Timeout.Value);
            Global.psi.FileName = @".\SpeedTest.exe";
            Global.psi.Arguments = "--server-id=" + ServerID.ToString();
            Global.psi.UseShellExecute = false;
            Global.psi.RedirectStandardOutput = true;
            Global.psi.RedirectStandardError = true;
            Global.psi.WindowStyle = ProcessWindowStyle.Hidden;
            Global.psi.CreateNoWindow = true;
            Global.proc.StartInfo = Global.psi;
            /// If Reps is a negative number, the loop is infinite
            /// If Reps is 1, the loop runs once
            /// If Reps is greater than one, the loops runs that many times
           
            Global.proc.Start();
            
            int j = 0;
            for (j = 0; j < Convert.ToInt32(num_Timeout.Value); j++)
            {
                prog_Progress.Value = j;
                Refesh();
                if (Global.proc.HasExited)
                {
                    break;
                }
            }
            prog_Progress.Value = Convert.ToInt32(num_Timeout.Value);
            if (j == Convert.ToInt32(num_Timeout.Value))
            {
                lbl_Status.Text = "ERROR: See output";
                prog_Progress.Style = ProgressBarStyle.Blocks;
                txt_output.Text += "Speedtest timed out.\r\nCheck your internet connection.\r\n";
                String[] strErrors = Global.proc.StandardError.ReadToEnd().ToString().Split(new[] { "\r\n" }, StringSplitOptions.None);
                foreach (String line in strErrors)
                {
                    txt_output.Text += line.Trim();
                }
                Application.DoEvents();
                return;
            }
            String strServer = "";
            String[] strResults = Global.proc.StandardOutput.ReadToEnd().ToString().Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (String line in strResults)
            {
                txt_output.Text += (line.Trim() + "\r\n");
                txt_ServerID.Text = ServerID.ToString();
                if (line.Contains("Server:"))
                {
                    strServer = line.Replace("Server:", "");
                }
                if (line.Contains("ISP:"))
                {
                    txt_ISP.Text = line.Replace("ISP:", "").Trim();
                }
                if (line.Contains("Latency:"))
                {
                    String temp = line.Replace("Latency:", "").Trim();
                    txt_Ping.Text = temp.Substring(0, temp.IndexOf("(") - 1).Trim();
                    txt_Jitter.Text = temp.Replace(txt_Ping.Text, "").Replace("jitter", "").Replace("(", "").Replace(")", "").Trim();
                }
                if (line.Contains("Download:"))
                {
                    String temp = line.Replace("Download:", "").Trim();
                    txt_Download.Text = temp.Substring(0, temp.IndexOf("(") - 1).Trim();
                }
                if (line.Contains("Upload:"))
                {
                    String temp = line.Replace("Upload:", "").Trim();
                    txt_Upload.Text = temp.Substring(0, temp.IndexOf("(") - 1).Trim();
                }
                if (line.Contains("Packet Loss:"))
                {
                    txt_PacketLoss.Text = line.Replace("Packet Loss:", "").Trim();
                }
                if (line.Contains("Result URL:"))
                {
                    txt_ResultURL.Text = line.Replace("Result URL:", "").Trim();
                }
                Application.DoEvents();
            }
            Application.DoEvents();
            if (check_Logging.Checked)
            {
                String strLogText = strServer.ToString().Trim() + "," + txt_ISP.Text.ToString().Trim() + "," + txt_Ping.Text.Replace(" ", ",").ToString().Trim() + "," + txt_Jitter.Text.Replace(" ", ",").Trim() + "," + txt_Download.Text.Replace(" ", ",").ToString().Trim() + "," + txt_Upload.Text.Replace(" ", ",").ToString().Trim() + "," + txt_PacketLoss.Text.ToString().Trim() + "," + txt_ResultURL.Text.ToString().Trim() + Environment.NewLine;
                File.AppendAllText(Global.strLogFileName, strLogText.Trim());
            }
            
            prog_Progress.Value = 0;
            lbl_Status.Text = "Ready...";
            prog_Progress.Style = ProgressBarStyle.Blocks;
            Application.DoEvents();
        }
        public void Refesh()
        {
            for(int i = 0; i < 10; i++) 
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (!Global.proc.HasExited)
            {
                Global.proc.Kill();
            }
            Global.Breakout = true;
            lbl_Status.Text = "Ready...";
            prog_Progress.Style = ProgressBarStyle.Blocks;
            Application.DoEvents();
        }

        private void btn_CopyResultURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_ResultURL.Text.Trim());
            lbl_Status.Text = "URL Copied!";
        }
    }
}