using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.View
{
    public partial class PrescriptionWindow : Form
    {
        public PrescriptionWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            List<Prescription> prescriptions = new List<Prescription>();
            
            prescription.PatientEmail = patientEmail.Text;
            prescription.Medication = medications.Text;
            prescription.Instruction = instructions.Text;
            prescription.Time = time.Text;
            
            prescriptions.Add(prescription);
            
            File.WriteAllText(@"..\..\Doctor\Data\Prescription.json",
                JsonConvert.SerializeObject(prescriptions));
            
            MessageBox.Show("Prescription is successfully given.","Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}