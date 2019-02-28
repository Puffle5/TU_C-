using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversitySystem
{
    static class Logger
    {
        private static List<String> currentSessionActivities = new List<String>();
        public static void LogActivity(String activity) 
        {
            String activityLine = DateTime.Now+";"+/*LoginValidation.currentUsername*/LoginValidation.CurrentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
            File.AppendAllText(@"C:\Users\Elly\IdeaProjects\TU_C_Sharp\UniversitySystem\UniversitySystem\test.txt", activityLine + Environment.NewLine);
            

        }
    }
}
