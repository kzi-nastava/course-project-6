using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Rooms.Repository;

namespace ProjectUSI.Doctor.View
{
    public partial class CRUDAppointmentWindow : Form
    {
        /// <summary>
        /// Window where you create new appointment.
        /// </summary>
        
        private AppointmentsRepository _appointmentsRepository;

        private RoomRepository _roomRepository = new RoomRepository();
        public CRUDAppointmentWindow(String type, AppointmentsRepository appointmentsRepository)
        {
            _appointmentsRepository = appointmentsRepository;
            InitializeComponent();
            textBoxType.Text = type;
            InitComboBox();
        }
        private void InitComboBox()
        {
            
            List<Room> rooms = _roomRepository.GetRooms();
            List<String> roomIds = new List<String>();
            foreach (Room room in rooms)
            {
                if (textBoxType.Text == "operation" && room.Purpose == RoomPurpose.OperationRoom)
                {
                    roomIds.Add(room.Id);
                }
                
                if (textBoxType.Text == "check up" && room.Purpose == RoomPurpose.ExaminationRoom)
                {
                    roomIds.Add(room.Id);
                }
            }
            comboBox1.DataSource = roomIds;
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
            newAppointments.RoomId = (string) comboBox1.SelectedItem;

            List<Appointments> appointments = _appointmentsRepository.GetAppointments();
            appointments.Add(newAppointments);
            
            _appointmentsRepository.Save();
            
            MessageBox.Show("Appointment is successfully created.","Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedText;
        }
    }
}