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
    /// This window represents referral to another doctor.
    /// </summary>
    public partial class ReferralWindow : Form
    {
        private ReferralRepository _referralRepository;
        public ReferralController _controller;
        private MedicalRecordRepository _medicalRecordRepository;
        public ReferralWindow(string email, MedicalRecordRepository medicalRecordRepository,
            ReferralRepository referralRepository, ReferralController referralController)
        {
            _referralRepository = referralRepository;
            _controller = referralController;
            _medicalRecordRepository = medicalRecordRepository;
            
            InitializeComponent();
            InitComponents(email);
        }
        
        private void InitComponents(String email)
        {
            foreach (MedicalRecord referral in _medicalRecordRepository.GetMedicalRecords())
            {
                if (referral.Email.Equals(email))
                {
                    textBox1.Text = referral.Name;
                    textBox2.Text = referral.Surname;
                    textBox3.Text = referral.Email;
                    textBox4.Text = referral.LBO;
                    textBox5.Text = referral.Phone;
                    textBox6.Text = referral.Height;
                    textBox7.Text = referral.Weight;
                    textBox8.Text = referral.PreviousIllnesses;
                    textBox9.Text = referral.Allergens;
                    textBox10.Text = referral.Anamnesis;
                }
            }
        }

        private void referral_Click(object sender, EventArgs e)
        {
            Referral newReferral = new Referral();
            List<Referral> referrals = new List<Referral>();
            
            List<string> doctors = new List<string>();
            doctors.Add("Petar Petrovic");
            doctors.Add("Janko Jankovic");
            
            newReferral.Name = textBox1.Text;
            newReferral.Surname = textBox2.Text;
            newReferral.Email = textBox3.Text;
            newReferral.LBO = textBox4.Text;
            newReferral.Phone = textBox5.Text;
            newReferral.Height = textBox6.Text;
            newReferral.Weight = textBox7.Text;
            newReferral.PreviousIllnesses = textBox8.Text;
            newReferral.Allergens = textBox9.Text;
            newReferral.Anamnesis = textBox10.Text;
            
            if (doctors.Contains(chosenDoctor.Text))
            {
                newReferral.ChosenDoctor = chosenDoctor.Text;
                referrals.Add(newReferral);

                File.WriteAllText(@"..\..\Doctor\Data\Referrals.json",
                    JsonConvert.SerializeObject(referrals));

                MessageBox.Show("Referral is successfully given!", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chosen doctor doesn't exist!", "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}