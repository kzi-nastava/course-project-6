using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents giving prescription to the patient.
    /// </summary>
    public partial class PrescriptionWindow : Form
    {
        private MedicalRecordRepository _medicalRecordRepository;
        private string _allergens;
        
        public PrescriptionWindow(MedicalRecordRepository medicalRecordRepository, string Allergens)
        {
            _medicalRecordRepository = medicalRecordRepository;
            Allergens = _allergens;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            List<Prescription> prescriptions = new List<Prescription>();
            //List<MedicalRecord> medicalRecords = _medicalRecordRepository.GetMedicalRecords();
            
            
            prescription.PatientEmail = patientEmail.Text;
            prescription.Medication = medications.Text;
            prescription.Instruction = instructions.Text;
            prescription.Time = time.Text;
            // foreach (Medicine medicine in medicines)
            // {
            //     if(medicine.Ingredients.ContainsKey())
            // }
            prescriptions.Add(prescription);
            
            File.WriteAllText(@"..\..\Doctor\Data\Prescription.json",
                JsonConvert.SerializeObject(prescriptions));
            
            MessageBox.Show("Prescription is successfully given.","Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}