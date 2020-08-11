using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace UniversalRichPresence.Core
{
    public class ActiveWindow
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
                return Buff.ToString();

            return null;
        }

        public static string GetActiveWindowExecutable()
        {
            uint processId;
            IntPtr handle = GetForegroundWindow();

            if (GetWindowThreadProcessId(handle, out processId) > 0)
                try { return Process.GetProcessById((int)processId).MainModule.ModuleName; }
                catch (AccessViolationException) { Debug.WriteLine("Access Violation, returning null"); }

            return null;
        }
    }
}
