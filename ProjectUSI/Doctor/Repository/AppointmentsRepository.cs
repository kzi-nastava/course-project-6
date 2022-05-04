using System.Collections.Generic;
using System.IO;
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
            string json = File.ReadAllText(@"..\..\Doctor\Data\Appointments1.json");
            List<Appointments> appointment = JsonConvert.DeserializeObject<List<Appointments>>(json);
            appointments = appointment;
        }
        public List<Appointments> GetAppointments()
        {
            return this.appointments;
        }
        
    }
}