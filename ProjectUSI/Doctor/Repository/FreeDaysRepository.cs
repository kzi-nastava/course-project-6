using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    public class FreeDaysRepository
    {
        private List<FreeDays> freeDays;
        private AppointmentsRepository _appointmentsRepository = new AppointmentsRepository();
        public FreeDaysRepository()
        {
            string json = File.ReadAllText(@"..\..\Doctor\Data\FreeDays.json");
            List<FreeDays> freeDay = JsonConvert.DeserializeObject<List<FreeDays>>(json);
            freeDays = freeDay;
        }

        public List<FreeDays> GetFreeDays()
        {
            return this.freeDays;
        }

        public bool IsAvailable(FreeDays freeDays)
        {
            bool b = false;
            foreach (Appointments appointments in _appointmentsRepository.GetAppointments())
            {
                if (appointments.Doctor == freeDays.Doctor)
                {
                    if (appointments.Date == freeDays.StartDate || appointments.Date == freeDays.EndDate)
                    {
                        b = false;
                    }
                    else
                    {
                        b = true;
                    }
                }
            }
            return b;
        }
    }
}