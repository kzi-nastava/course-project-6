using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectUSI.Doctor.Controller;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
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
            string email = textBox3.Text;
            Referral newReferral = new Referral();
            List<Referral> referrals = _referralRepository.GetReferrals();
            
            foreach (Referral referral in referrals)
            {
                if (referral.Email.Equals(email))
                {
                    newReferral.Name = textBox1.Text;
                    newReferral.Surname = textBox2.Text;
                    newReferral.Email = email;
                    newReferral.LBO = textBox4.Text;
                    newReferral.Phone = textBox5.Text;
                    newReferral.Height = textBox6.Text;
                    newReferral.Weight = textBox7.Text;
                    newReferral.PreviousIllnesses = textBox8.Text;
                    newReferral.Allergens = textBox9.Text;
                    newReferral.Anamnesis = textBox10.Text;
                    
                    //TODO ComboBox;
                }
            }
            referrals.Add(newReferral);
        }
    }
}