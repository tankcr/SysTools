using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SysTools
{

    public class gettingEventlogs
    {
      string gettingeventLog;
      string computername;
        public string gettingEventLog
        {
            get { return gettingeventLog; return computername; }
            set { gettingeventLog = value; }
        }

        public gettingEventlogs()
        {
        }
    }
        public class GetEvents
        {
        
        public static List<string> GetLogTypes(string computername)
        {
            EventLog[] remoteEventLogs;
            List<string>logtypes = new List<string>();
            remoteEventLogs = EventLog.GetEventLogs(computername);
            foreach (EventLog e in remoteEventLogs) { logtypes.Add(e.LogDisplayName.ToString()); }
            return logtypes;
        }
/*        public static List<EventLog> GetEventLogs(string logtype, string computername)    
        {
            //logType can be Application, Security, System or any other Custom Log.
            List<EventLog> log = new List<EventLog>();
            EventLog evlogs = new EventLog(logtype, computername);          
            return evlogs;
        }
*/     }      
}
