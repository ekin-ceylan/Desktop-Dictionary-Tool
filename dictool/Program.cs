using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dictool.Properties;

namespace dictool
{
    static class Program
    {
        static Mutex _m;

        /// <summary> 
        /// Entry point of the application. 
        /// </summary> 
        [STAThread]
        private static void Main()
        {
            bool first = false;
            _m = new Mutex(true, Application.ProductName.ToString(), out first);

            if ((first))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new DesktopDictionary());
                _m.ReleaseMutex();
            }
            //else
            //{
            //    MessageBox.Show("Application" + " " + Application.ProductName.ToString() + " " + "already running");
            //}
        }
    }
}
