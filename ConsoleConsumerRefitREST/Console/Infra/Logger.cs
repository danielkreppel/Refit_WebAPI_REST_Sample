using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Infra
{
    public static class Logger 
    {
        public static void SaveLog(Exception e)
        {
            EventLog.WriteEntry("ConsoleConsumerRefitREST", e.StackTrace, EventLogEntryType.Error);
        }
        public static void SaveLog(string message)
        {
            EventLog.WriteEntry("ConsoleConsumerRefitREST", message, EventLogEntryType.Error);
        }
    }
}
