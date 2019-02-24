using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    static class Logger
    {
        private static List<String> currentSessionActivities = new List<String>();
        public static void LogActivity(String activity) 
        {
            String activityLine = DateTime.Now+";"+/*LoginValidation.currentUsername*/LoginValidation.CurrentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
        }
    }
}
