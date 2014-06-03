using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Diagnostics;
using System.Windows.Forms;
namespace SysTools
{

    public class RemoteApps
    {
        string remoteApp;
        public string RemoteApp
        {
            get { return remoteApp; }
            set { remoteApp = value; }
        }
    }
    public class remoteApp
    {
        public static string GetApp(string appname, string computername)
        {
            RemoteApps App = new RemoteApps();
            App.RemoteApp = appname;
           
/*            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.FileName = @"./PsExec.exe";
            p.StartInfo.Arguments = @"\\computername cmd.exe ipconfig /all";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            string errormessage = p.StandardError.ReadToEnd();
            p.WaitForExit();
            /*var processToRun = new[] {appname};
            var connection = new ConnectionOptions();
            var wmiScope = new ManagementScope(String.Format("\\\\{0}\\root\\cimv2", computername), connection);
            var wmiProcess = new ManagementClass(wmiScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());
            wmiProcess.InvokeMethod("Create", processToRun);
*/
            Term term = new Term();
            term.Show();
            return appname;
        }
    }
}
