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
        public MedicalRecord medicalRecord { get; set; }
        public List<Appointment> appointments;
        public List<Anamnesis> anamnesis { get; set; }
        public List<string> appointings;
        public List<string> changes;
        public string status;

        public void GetAppointments(string fileName, string mail)
        {
            string json = File.ReadAllText(fileName);
            List<Appointment> allAppointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
            
            for (int i = 0; i < allAppointments.Count; i++) 
            { 
                if (allAppointments[i].patientmail != mail) { allAppointments.RemoveAt(i); } 
            }
            appointments = allAppointments;
        }
    }
}
