using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    public partial class CRUDAppointmentWindow : Form
    {
        /// <summary>
        /// Window where you create new appointment.
        /// </summary>
        
        private AppointmentsRepository _appointmentsRepository;

        public CRUDAppointmentWindow(AppointmentsRepository appointmentsRepository)
        {
            _appointmentsRepository = appointmentsRepository;
            InitializeComponent();
        }

        private void buttonCreateApp_Click(object sender, EventArgs e)
        {
            Appointments newAppointments = new Appointments();
            
            newAppointments.Id = textBoxId.Text;
            newAppointments.Type = textBoxType.Text; 
            newAppointments.Patient = textBoxPatient.Text;
            newAppointments.PatientEmail = textBoxPatientEmail.Text;
            newAppointments.Doctor = textBoxDoctor.Text;
            newAppointments.Date = textBoxDate.Text;
            newAppointments.Time = textBoxStartTime.Text;
            newAppointments.EndTime = textBoxEndTime.Text;
            
            List<Appointments> appointments = _appointmentsRepository.GetAppointments();
            appointments.Add(newAppointments);
            
            File.WriteAllText(@"C:\Users\anita\OneDrive\Radna površina\ProjectUSI\Doctor\Data\Appointments1.json", 
                JsonConvert.SerializeObject(appointments));
            
            MessageBox.Show("Appointment is successfully created.","Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}