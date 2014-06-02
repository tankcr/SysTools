using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using AxMSTSCLib;

namespace GetLogs
{
    public partial class Form1 : Form
    {
        List<Domains> domainList = GetDomains.GetDomainNames();
        string systemtype;
        public Form1()
        {
            InitializeComponent();
            
            //int computercount = computerlist
        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*          string domain = "domain";
            List<Computers> computerList = GetComputers.GetComputerNames(domain);
            comboBox1.DisplayMember = "ComputerName";
            comboBox1.DataSource = computerList;
*/          
            List<Domains> domainList = GetDomains.GetDomainNames();
            string domain = domainList[0].DomainName;
            comboBox1.SelectedText = "Domain Name";
            comboBox1.SelectedItem = "Domain Name";
            comboBox1.SelectedValue = "Domain Name";
            comboBox1.ValueMember = "DomainName";
            comboBox1.DataSource = domainList;
            comboBox2.SelectedText = "Servers";
            comboBox2.SelectedValue = "Servers";
            comboBox2.SelectedItem = "Servers";
            List<Computers> computerList = GetComputers.GetComputerNames(domain, "Servers");
            listBox1.DisplayMember = "ComputerName";
            listBox1.DataSource = computerList;
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == null)
            { comboBox2.SelectedItem = "Servers"; }
            string systemtypeselected = comboBox2.SelectedItem.ToString();
//            string domain = comboBox1.SelectedText;
            string domain = comboBox1.SelectedValue.ToString();
            List<Computers> ChangedcomputerList = GetComputers.GetComputerNames(domain, systemtypeselected);
            listBox1.DataSource = ChangedcomputerList;
            listBox1.DisplayMember = "ComputerName";
            listBox1.Update();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                string firstdomain = domainList[0].DomainName;
                string selecteddomain;
                string cb1Text = comboBox1.SelectedValue.ToString();
                if (cb1Text == "")
                { 
                    comboBox1.SelectedText = firstdomain;
                    comboBox1.SelectedItem = firstdomain;
                    comboBox1.SelectedValue = firstdomain;
                    selecteddomain = firstdomain;
                }
                else { selecteddomain = cb1Text; }
                string systemtypeselected = comboBox2.SelectedItem.ToString();
                List<Computers> ChangedcomputerList = GetComputers.GetComputerNames(selecteddomain, systemtypeselected);
                listBox1.DataSource = ChangedcomputerList;
                listBox1.DisplayMember = "ComputerName";
                listBox1.Update();
            }
        }


        public void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string session = (listBox1.Text);
            //term.Show();
            Process.Start("mstsc.exe", string.Format("/v:{0}", session));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { contextMenuStrip1.Show(this, new Point(e.X+85, e.Y)); }
        }

        private void item1TestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void item1TestToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            string session = (listBox1.Text);
            //term.Show();
            Process.Start("mstsc.exe", string.Format("/v:{0}", session));
        }
    }
}
