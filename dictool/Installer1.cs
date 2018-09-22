using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace dictool
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public override void Install(IDictionary savedState)
        {
            base.Install(savedState);
            //Add custom code here
        }


        //public override void Rollback(IDictionary savedState)
        //{
        //    base.Rollback(savedState);
        //    //Add custom code here
        //}

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            //Process.Start(@"C:\Program Files (x86)\Ekin\Desktop Dictionary\Desktop Dictionary.exe");
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + 
                    @"\Desktop Dictionary.exe");
            //Add custom code here
        }


        //public override void Uninstall(IDictionary savedState)
        //{
            //Process application = null;
            //foreach (var process in Process.GetProcesses())
            //{
            //    if (!process.ProcessName.ToLower().Contains("creatinginstaller")) continue;
            //    application = process;
            //    break;
            //}

            //if (application != null && application.Responding)
            //{
            //    application.Kill();
            //    base.Uninstall(savedState);
            //}
        //}

    }
}