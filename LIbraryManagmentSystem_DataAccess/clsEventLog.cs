using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_DataAccess
{
    public class clsEventLog
    {
        static public void LogError(string msg, EventLogEntryType eventLogEntryType)
        {

            string sourceName = "LIbraryManagmentSystem";
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            // Log an information event
            EventLog.WriteEntry(sourceName, msg, eventLogEntryType);
        }
    }
}
