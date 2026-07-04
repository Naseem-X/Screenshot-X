using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Screenshot_X
{
    static class Program
    {
        private static Mutex mutex = null;

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

    
        private const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            const string appName = "Screenshot_X_Unique_Application_Mutex_Name";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

           
            if (!createdNew)
            {
                BringToFront();
                return;  
            }

            try
            {
                SetProcessDPIAware();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMainApp());
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.ReleaseMutex();
                    mutex.Close();
                }
            }
        }

        private static void BringToFront()
        {
            Process current = Process.GetCurrentProcess();

            foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            {
                if (process.Id != current.Id)
                {
                    IntPtr handle = process.MainWindowHandle;

                
                    if (handle != IntPtr.Zero)
                    {
                        if (IsIconic(handle))
                        {
                            ShowWindow(handle, SW_RESTORE);
                        }

                        SetForegroundWindow(handle);
                    }
                    break;
                }
            }
        }
    }
}