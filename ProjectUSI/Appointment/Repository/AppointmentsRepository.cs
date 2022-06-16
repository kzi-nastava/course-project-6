using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    /// <summary>
    /// This class gets appointments from file.
    /// </summary>
    public class AppointmentsRepository
    {
        private List<Appointments> appointments;

        public AppointmentsRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Appointments1.json");
            List<Appointments> appointment = JsonConvert.DeserializeObject<List<Appointments>>(json);
            appointments = appointment;
        }

        public List<Appointments> GetAppointments()
        {
            return this.appointments;
        }

        public bool IsAvailable(Appointments appointment)
        {
            bool b = false;
            foreach (Appointments app in this.appointments)
            {
                if (appointment.Time == app.Time || appointment.EndTime == app.EndTime)
                    b = false;
                else
                {
                    b = true;
                }
            }

            return b;
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Appointments1.json", 
                JsonConvert.SerializeObject(appointments));
        }
    }
}