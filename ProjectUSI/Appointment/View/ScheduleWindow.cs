using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Controller;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents doctor's schedule from where you can search, update, delete and start an appointment.
    /// </summary>
    public partial class ScheduleWindow : Form
    {
        
        public AppointmentsRepository _appointmentsRepository;
        public AppointmentsController _controller;
        public MedicalRecordRepository _medicalRecordRepository;

        public ScheduleWindow(AppointmentsRepository appointmentRepository, AppointmentsController appointmentsController,
            MedicalRecordRepository medicalRecordRepository)
        {
            _appointmentsRepository = appointmentRepository;
            _controller = appointmentsController;
            _medicalRecordRepository = medicalRecordRepository;
            
            InitializeComponent();
            InitListBox();

        }

        public void InitListBox()
        {
            for (int i = 0; i < _appointmentsRepository.GetAppointments().Count; i++)
            {
                appointments.Items.Add(_appointmentsRepository.GetAppointments().ElementAt(i).ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            var appointmentsList = _appointmentsRepository.GetAppointments(); 

            appointments.BeginUpdate();
            appointments.Items.Clear();

            if(!string.IsNullOrEmpty(textBox1.Text)) 
            {
                foreach (Appointments appointment in appointmentsList)
                {                
                    if (appointment.ToString().Contains(textBox1.Text))
                    {
                        appointments.Items.Add(appointment.ToString());
                    }
                }
            }
            else
                InitListBox();
            appointments.EndUpdate();    
        }

        private void buttonStartApp_Click(object sender, EventArgs e)
        {
            try
            {
                int index = appointments.SelectedIndex;
                Appointments appointment;
                appointment = _appointmentsRepository.GetAppointments().ElementAt(index);
                Appointments app = _appointmentsRepository.GetAppointments()[index];
                AppointmentWindow appointmentWindow = new AppointmentWindow(app.PatientEmail, _medicalRecordRepository, appointment);
                appointmentWindow.ShowDialog();
            }
            
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which appointment you want to delete.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which appointment you want to delete.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteApp_Click(object sender, EventArgs e)
        {
            try
            {
                int index = appointments.SelectedIndex;
                Appointments app = _appointmentsRepository.GetAppointments()[index];
                List<Appointments> appointmentsList = _appointmentsRepository.GetAppointments();
                appointmentsList.Remove(app);

                _appointmentsRepository.Save();

                appointments.Items.Clear();
                InitListBox();
                
                MessageBox.Show("Selected appointment is successfully deleted.","Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which appointment you want to delete.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which appointment you want to delete.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUpdateApp_Click(object sender, EventArgs e)
        {
            try
            {
                int index = appointments.SelectedIndex;
                Appointments app = _appointmentsRepository.GetAppointments()[index];
                UpdateAppointmentWindow appointment = new UpdateAppointmentWindow(app.PatientEmail,
                    _appointmentsRepository,
                    new AppointmentsController(new Appointments(), null, _appointmentsRepository));
                appointment.ShowDialog();
                appointments.Items.Clear();
                InitListBox();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which appointment you want to change.", caption:"Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which appointment you want to change.", caption:"Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appointments.Items.Clear();
            InitListBox();
        }
    }
}