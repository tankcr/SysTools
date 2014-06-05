using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SysTools
{
    public class Logs
    {
        string logName;

        public string LogName
        {
            get { return logName; }
            set { logName = value; }
        }
        string evLog;

        public string EVLogName
        {
            get { return evLog; }
            set { evLog = value; }
        }

        public Logs()
        {

        }

    }
    public class GetLogs
    {
        public static List<Logs> GetLogNames(string computername)
        {
            List<Logs> logs = new List<Logs>();
            GetLogs LogNames = new GetLogs();
            EventLog[] remoteEventLogs;
            remoteEventLogs = EventLog.GetEventLogs(computername);
            Logs log = new Logs();
            foreach (EventLog e in remoteEventLogs)
            {
                log = new Logs();
                log.LogName = e.LogDisplayName;
                logs.Add(log);
            }
            return logs;
        }
        public static EventLog GetEventLogs(string logtype, string computername)
        {
            //logType can be Application, Security, System or any other Custom Log.
            List<EventLog> log = new List<EventLog>();
            EventLog evlog = new EventLog(logtype, computername);
            return evlog;
        }
    }
}