using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents giving prescription to the patient.
    /// </summary>
    public partial class PrescriptionWindow : Form
    {
        private MedicalRecordRepository _medicalRecordRepository;
        private PrescriptionRepository _prescriptionRepository = new PrescriptionRepository();
        private string email;
        
        public PrescriptionWindow(MedicalRecordRepository medicalRecordRepository, string PatientEmail)
        {
            _medicalRecordRepository = medicalRecordRepository;
            email = PatientEmail;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            List<Prescription> prescriptions = new List<Prescription>();
            
            prescription.PatientEmail = email;
            prescription.Medication = medications.Text;
            prescription.Instruction = instructions.Text;
            prescription.Time = time.Text;
            
            prescriptions.Add(prescription);
            
            _prescriptionRepository.Save();
            
            MessageBox.Show("Prescription is successfully given.","Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}