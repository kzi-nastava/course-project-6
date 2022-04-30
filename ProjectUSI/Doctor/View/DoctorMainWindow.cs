using System;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Doctor.Controller;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// Main window which doctor sees when he's logged in..
    /// </summary>
    public partial class DoctorMainWindow : Form
    {
        public AppointmentsRepository _appointmentsRepository;
        public AppointmentsController _controller;
        public MedicalRecordRepository _medicalRecordRepository;
        
        public DoctorMainWindow(AppointmentsRepository appointmentsRepository, MedicalRecordRepository medicalRecordRepository)
        {
            _appointmentsRepository = appointmentsRepository;
            _medicalRecordRepository = medicalRecordRepository;
            InitializeComponent();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            ScheduleWindow scheduleWindow = new ScheduleWindow(_appointmentsRepository,
                new AppointmentsController(new Appointments(), null, _appointmentsRepository), _medicalRecordRepository);
            scheduleWindow.ShowDialog();
        }
        
        private void buttonCreateApp_Click(object sender, EventArgs e)
        {
            CRUDAppointmentWindow crudAppointmentWindow = new CRUDAppointmentWindow(new AppointmentsRepository());
            crudAppointmentWindow.Show();
        }
    }
}