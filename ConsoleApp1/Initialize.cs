using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Initialize
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        public static void startup()
        {
            //Gets the current active window title. This will be used to see if the target window is currently the active one
            //Do contains to check if title has World in it, if not then alt tab and check again?
            string GetActiveWindowTitle()
            {
                const int nChars = 256;
                StringBuilder Buff = new StringBuilder(nChars);
                IntPtr handle = GetForegroundWindow();

                if (GetWindowText(handle, Buff, nChars) > 0)
                {
                    Console.WriteLine("Here is the window title");
                    Console.WriteLine(Buff.ToString());
                    return Buff.ToString();
                }
                Console.WriteLine("Returning null...");
                return null;
            }
            //Playing with getting process by name
            Process[] localByName = Process.GetProcessesByName("WowClassic");
            Console.WriteLine(localByName.Length);
        }
    }
}
