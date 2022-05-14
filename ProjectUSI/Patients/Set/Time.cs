using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Set
{
    public class Time
    {
        public DateTime currentDate;
        public List<List<string>> TimeSetup()
        {
            List<string> times = new List<string>
                                {
                                  "8:00", "8:15", "8:30", "8:45",
                                  "9:00", "9:15", "9:30", "9:45",
                                  "10:00", "10:15", "10:30", "10:45",
                                  "11:00", "11:15", "11:30", "11:45",
                                  "12:00", "12:15", "12:30", "12:45",
                                  "13:00", "13:15", "13:30", "13:45",
                                  "14:00", "14:15", "14:30", "14:45",
                                  "15:00", "15:15", "15:30", "15:45",
                                  "16:00", "16:15", "16:30", "16:45",
                                  "17:00", "17:15", "17:30", "17:45",
                                  "18:00", "18:15", "18:30", "18:45",
                                  "19:00", "19:15", "19:30", "19:45"
                                };

            List<List<string>> nextWeekTimes = new List<List<string>>();
            for (int i = 0; i < 7; i++) { nextWeekTimes.Add(times); }

            return nextWeekTimes;
        }
        public List<DateTime> DaysSetup()
        {
            DateTime firstDate = currentDate.AddDays(2);
            List<DateTime> nextSevenDays = new List<DateTime>();

            for (int i = 0; i < 7; i++) { nextSevenDays.Add(firstDate.AddDays(i).Date); }

            return nextSevenDays;
        }

    }
}
