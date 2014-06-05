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

namespace SysTools
{
    public partial class LogViewer : Form
    {
        DataTable eventLog = new DataTable();
        DataSet dataset1 = new DataSet();
        private EventLog unhandledLogs;
        public LogViewer(EventLog logs)
        {
            unhandledLogs = logs;
            InitializeComponent();
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            EventLog currentLog = unhandledLogs;
            DataTable dataTable1 = new DataTable();
            DataColumn column;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Category";
            dataTable1.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "DateTime";
            dataTable1.Columns.Add(column);
            dataTable1.Rows.Clear();
            for (int currLogIndex = 0; currLogIndex <= unhandledLogs.Entries.Count; currLogIndex++)
            {
                DataRow drnew = dataTable1.NewRow();
                try
                {
                    EventLogEntry currLogEntry = unhandledLogs.Entries[currLogIndex];
                    drnew["Category"] = currLogEntry.Source;
                    drnew["DateTime"] = currLogEntry.TimeGenerated;
                    dataTable1.Rows.Add(drnew);
                }
                catch { }
            }
            dataGridView1.DataSource = dataTable1;
            dataTable1.DefaultView.Sort = ("DateTime asc");
        }
    }
}
