using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patients.Models;
using System.IO;
using Newtonsoft.Json;

namespace Patients.Set
{
    public class Objects
    {
        public List<Appointment> JsonToAppointmentsList(string fileName)
        {
            string json = File.ReadAllText(fileName);
            List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
            return appointments;
        }

        public List<string> JsonToDoctorsList(string fileName)
        {
            string json = File.ReadAllText(fileName);
            List<string> doctors = JsonConvert.DeserializeObject<List<string>>(json);
            return doctors;
        }


    }
}
