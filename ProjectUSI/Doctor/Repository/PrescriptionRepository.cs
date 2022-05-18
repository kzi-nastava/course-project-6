using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Data;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    public class PrescriptionRepository
    {
        private List<Prescription> prescriptions;
        private List<Medicine> medicines;

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

        public List<Medicine> GetMedicines()
        {
            string json2 = File.ReadAllText(@"..\..\Data\Medicine.json");
            List<Medicine> medicine = JsonConvert.DeserializeObject<List<Medicine>>(json2);
            medicines = medicine;
            return medicines;
        }
        
}
}