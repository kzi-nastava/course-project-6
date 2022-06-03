using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Controller;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents patients's medical record when appointment has started.
    /// </summary>
    public partial class AppointmentWindow : Form
    {
        private MedicalRecordRepository _medicalRecordRepository;
        public ReferralRepository _referralRepository;
        private Appointments _appointment;

        public AppointmentWindow(String email, MedicalRecordRepository medicalRecordRepository, Appointments appointment)
        {
            _medicalRecordRepository = medicalRecordRepository;
            _appointment = appointment;
            InitializeComponent();
            InitComponents(email);

        }

        private void InitComponents(String email)
        {
            foreach (MedicalRecord medicalRecord in _medicalRecordRepository.GetMedicalRecords())
            {
                if (medicalRecord.Email.Equals(email))
                {
                    textBox1.Text = medicalRecord.Name;
                    textBox2.Text = medicalRecord.Surname;
                    textBox3.Text = medicalRecord.Email;
                    textBox4.Text = medicalRecord.LBO;
                    textBox5.Text = medicalRecord.Phone;
                    textBox6.Text = medicalRecord.Height;
                    textBox7.Text = medicalRecord.Weight;
                    textBox8.Text = medicalRecord.PreviousIllnesses;
                    textBox9.Text = medicalRecord.Allergens;
                    textBox10.Text = medicalRecord.Anamnesis;
                }
            }
        }

        private void buttonUpdateMedRec_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            MedicalRecord newMedicalRecord = new MedicalRecord();
            MedicalRecord toBeDeleted = new MedicalRecord();
            List<MedicalRecord> medicalRecords = _medicalRecordRepository.GetMedicalRecords();
            
            foreach (MedicalRecord medicalRecord in medicalRecords)
            {
                if (medicalRecord.Email.Equals(email))
                {
                        newMedicalRecord.Name = textBox1.Text;
                        newMedicalRecord.Surname = textBox2.Text;
                        newMedicalRecord.Email = email;
                        newMedicalRecord.LBO = textBox4.Text;
                        newMedicalRecord.Phone = textBox5.Text;
                        newMedicalRecord.Height = textBox6.Text;
                        newMedicalRecord.Weight = textBox7.Text;
                        newMedicalRecord.PreviousIllnesses = textBox8.Text;
                        newMedicalRecord.Allergens = textBox9.Text;
                        newMedicalRecord.Anamnesis = textBox10.Text;
                        toBeDeleted = medicalRecord;
                }
            }
            medicalRecords.Remove(toBeDeleted);
            medicalRecords.Add(newMedicalRecord);
            
            File.WriteAllText(@"..\..\Doctor\Data\MedicalRecords.json",
                JsonConvert.SerializeObject(medicalRecords));
            
            MessageBox.Show("Medical record is successfully modified.", "Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        
        private void buttonPrescription_Click(object sender, EventArgs e)
        {
            string allergens = textBox9.Text;
            PrescriptionWindow prescriptionWindow = new PrescriptionWindow(_medicalRecordRepository, allergens);
            prescriptionWindow.Show();
        }

        private void referral_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            ReferralWindow referralWindow = new ReferralWindow(email, _medicalRecordRepository, _referralRepository,
                new ReferralController(new Referral(), null,  _referralRepository));
            referralWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsedEquimpentWindow usedEquimpentWindow = new UsedEquimpentWindow(_appointment);
            usedEquimpentWindow.Show();
        }
    }
}