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
    public partial class UpdateAppointmentWindow : Form
    {
        private AppointmentsRepository _appointmentsRepository;
        public AppointmentsController _controller;
        public UpdateAppointmentWindow(String email, AppointmentsRepository appointmentsRepository,
            AppointmentsController appointmentsController)
        {
            _appointmentsRepository = appointmentsRepository;
            _controller = appointmentsController;
            
            InitializeComponent();
            InitComponents(email);
            
        }
        
        private void InitComponents(String email)
        {
            foreach (Appointments appointment in _appointmentsRepository.GetAppointments())
            {
                try
                {
                    if (appointment.PatientEmail.Equals(email))
                    {
                        textBoxId.Text = appointment.Id;
                        textBoxType.Text = appointment.Type;
                        textBoxPatient.Text = appointment.Patient;
                        textBoxPatientEmail.Text = appointment.PatientEmail;
                        textBoxDoctor.Text = appointment.Doctor;
                        textBoxDate.Text = appointment.Date;
                        textBoxStartTime.Text = appointment.Time;
                        textBoxEndTime.Text = appointment.EndTime;
                    }
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show("Appointment doesn't exist!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonUpdateApp_Click(object sender, EventArgs e)
        {
            string email = textBoxPatientEmail.Text;
            Appointments newAppointment = new Appointments();
            Appointments toBeDeleted = new Appointments();
            List<Appointments> appointments = _appointmentsRepository.GetAppointments();

            foreach (Appointments appointment in appointments)
            {
                if (appointment.PatientEmail.Equals(email))
                {
                    newAppointment.Id = textBoxId.Text;
                    newAppointment.Type = textBoxType.Text;
                    newAppointment.Patient = textBoxPatient.Text;
                    newAppointment.PatientEmail = textBoxPatientEmail.Text;
                    newAppointment.Doctor = textBoxDoctor.Text;
                    newAppointment.Date = textBoxDate.Text;
                    newAppointment.Time = textBoxStartTime.Text;
                    newAppointment.EndTime = textBoxEndTime.Text;
                    toBeDeleted = appointment;
                }

            }
            appointments.Remove(toBeDeleted);
            appointments.Add(newAppointment);
            
            File.WriteAllText(@"C:\Users\anita\OneDrive\Radna površina\ProjectUSI\Doctor\Data\Appointments1.json",
                JsonConvert.SerializeObject(appointments));
            
            MessageBox.Show("Appointment is successfully modified.", "Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    
}