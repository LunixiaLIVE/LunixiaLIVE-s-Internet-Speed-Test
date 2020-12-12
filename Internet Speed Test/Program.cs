using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Internet_Speed_Test
{
    static class Global
    {
        public static Process proc = new Process();
        public static ProcessStartInfo psi = new ProcessStartInfo();
        public static String strHeaders = "Server, ServerID, ISP, Latency, LatencyUnit, Jitter, JitterUnit, Download, DownloadUnit, Upload, UploadUnit, PacketLoss, ResultURL";
        public static String strLogFileName;
        public static Boolean Breakout;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
