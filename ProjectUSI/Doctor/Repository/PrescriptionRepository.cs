using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    public class PrescriptionRepository
    {
        private List<Prescription> prescriptions;
        
        public PrescriptionRepository()
        {
            string json = File.ReadAllText(@"..\..\Doctor\Data\Prescription.json");
            List<Prescription> prescription = JsonConvert.DeserializeObject<List<Prescription>>(json);
            prescriptions = prescription;
        }
        public List<Prescription> GetPrescriptions()
        {
            return this.prescriptions;
        }
    }
}