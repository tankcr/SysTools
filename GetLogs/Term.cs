using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMSTSCLib;

namespace GetLogs
{

    public partial class Term : Form
    {

        string pcName;
        AxMsRdpClient9 rdp = new AxMsRdpClient9();
        public Term()
        {
            InitializeComponent();
        }

        public Term(string my_string)
        {
            InitializeComponent();
            this.pcName = my_string;
        }


        private void axMsRdpClient91_OnConnecting(object sender, EventArgs e)
        {

        }

        private void Term_Load(object sender, EventArgs e)
        {
            rdp.Server = pcName;
            rdp.AdvancedSettings8.EnableCredSspSupport = true;
            rdp.Connect();
        }
    }
    /*
    public class PC
    {
        
    }
     * */
}
