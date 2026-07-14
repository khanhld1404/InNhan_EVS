using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PrintLabel
{
    static class Program
    {
        // Giữ mutex sống suốt vòng đời app để tránh GC/Dispose sớm
        private static Mutex _mutex;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            /////////////////////////////////////////////////////////////////

            //bool ownsMutex;
            //using (Mutex mutex = new Mutex(true, "PrintLabel", out ownsMutex))
            //{
            //    if (ownsMutex)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new Form1());
            //        mutex.ReleaseMutex();//chi duoc mo 1 chuong trinh trong cua mot thoi diem
            //    }
            //    else MessageBox.Show("Another instance is already running", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            // Nên dùng GUID/unique name để tránh đụng app khác
            // Global\ để dùng chung mọi RDP session
            string mutexName = @"Global\PrintLabel";

            bool createdNew;
            _mutex = new Mutex(true, mutexName, out createdNew);

            if (!createdNew)
            {
                BringExistingInstanceToFront();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Form1());
            }
            finally
            {
                // Chỉ release nếu ta là owner
                try { _mutex.ReleaseMutex(); } catch { /* ignore */ }
                _mutex.Dispose();
            }
        }

        private static void BringExistingInstanceToFront()
        {
            Process current = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcessesByName(current.ProcessName))
            {
                if (p.Id == current.Id) continue;

                IntPtr hWnd = p.MainWindowHandle;
                if (hWnd == IntPtr.Zero) continue;

                // Nếu đang minimize thì restore
                ShowWindow(hWnd, SW_RESTORE);

                // Đưa lên trước
                SetForegroundWindow(hWnd);
                break;
            }
        }
    }
}
