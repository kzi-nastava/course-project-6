using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Patients.Models
{
    public class Patient
    {
        public class MedicalRecord
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string mail { get; set; }
            public string height { get; set; }
            public string weight { get; set; }
            public List<string> allergies { get; set; }
        }

        public class Anamnesis
        {
            public string date;
            public string doctor;
            public string type;
            public string notes;
            public List<string> anamnesis;
        }

        public MedicalRecord medicalRecord { get; set; }
        public List<Anamnesis> anamnesis;
        public List<string> appointings;
        public List<string> changes;
        public string status;

        public List<Appointment> GetAppointments(string fileName, string mail)
        {
            string json = File.ReadAllText(fileName);
            List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
            
            for (int i = 0; i < appointments.Count; i++) 
            { 
                if (appointments[i].patientmail != mail) { appointments.RemoveAt(i); } 
            }
            return appointments;
        }
    }
}
