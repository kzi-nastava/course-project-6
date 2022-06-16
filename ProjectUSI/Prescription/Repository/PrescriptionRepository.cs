using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    /// <summary>
    /// This class gets prescriptions from file.
    /// </summary>
    public class PrescriptionRepository
    {
        private List<Prescription> prescriptions;

        public PrescriptionRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Prescription.json");
            List<Prescription> prescription = JsonConvert.DeserializeObject<List<Prescription>>(json);
            prescriptions = prescription;
        }

        public List<Prescription> GetPrescriptions()
        {
            return this.prescriptions;
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Prescription.json", 
                JsonConvert.SerializeObject(prescriptions));
        }
    }
}