using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SysTools
{
    public partial class Term : Form
    {
        private static StringBuilder cmdOutput = null;
        Process cmdProcess;
        StreamWriter cmdStreamWriter;

        public Term(string appname, string computername)
        {
            //do stuff here
            Term.ActiveForm.Text = computername;
            InitializeComponent();
        }
        
        private void Term_Load(object sender, EventArgs e)
        {

            cmdOutput = new StringBuilder("");
            cmdProcess = new Process();
            RemoteApps app = new RemoteApps();
            cmdProcess.StartInfo.FileName = "./psexec.exe";
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.RedirectStandardError = true;
            cmdProcess.StartInfo.Arguments = @"\\ " + Term.ActiveForm.Text + "cmd.exe";


            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.Start();

            cmdStreamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            cmdStreamWriter.WriteLine(textBox1.Text);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            cmdStreamWriter.Close();
            cmdProcess.WaitForExit();
            cmdProcess.Close();
        }

        private void btnShowOutput_Click(object sender, EventArgs e)
        {
            textBox2.Text = cmdOutput.ToString();
        }

        private static void SortOutputHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                cmdOutput.Append(Environment.NewLine + outLine.Data);
            }
        }
    }
}
