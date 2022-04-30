using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    /// <summary>
    /// This class gets medical records from file.
    /// </summary>
    public class MedicalRecordRepository
    {
        public List<MedicalRecord> medicalRecords;
        
        public MedicalRecordRepository()
        {
            string json = File.ReadAllText(@"C:\Users\anita\OneDrive\Radna površina\ProjectUSI\Doctor\Data\MedicalRecords.json");
            List<MedicalRecord> medicalRecord = JsonConvert.DeserializeObject<List<MedicalRecord>>(json);
            medicalRecords = medicalRecord;
        }
        public List<MedicalRecord> GetMedicalRecords()
        {
            return this.medicalRecords;
        }
    }
}