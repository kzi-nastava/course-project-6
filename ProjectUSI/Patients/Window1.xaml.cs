using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Patients.Models;
using Newtonsoft.Json;
using Patients.Set;

namespace Patients
{
    public partial class Window1 : Window
    {
        public void SetTimes(List<string> DayTimes, string doctor, DateTime date, Appointment theAppointment)
        {
            while (Times1.Children.Count > 0) { Times1.Children.RemoveAt(0); }
            while (Times2.Children.Count > 0) { Times2.Children.RemoveAt(0); }

            for (int i = 0; i < DayTimes.Count; i++)
            {
                string time = DayTimes[i];

                RadioButton rb = new RadioButton() { Content = DayTimes[i]};
                rb.GroupName = "Times";

                if (i % 2 == 0) { Times1.Children.Add(rb); }
                else { Times2.Children.Add(rb); }

                rb.Checked += (sender, args) =>
                {
                    AppointButton.Visibility = Visibility.Visible;
                    theAppointment.type = "check-up";
                    theAppointment.patient = thePatient.medicalRecord.name + thePatient.medicalRecord.surname;
                    theAppointment.patientmail = thePatient.medicalRecord.mail;
                    theAppointment.doctor = doctor;
                    theAppointment.date = Convert.ToString(date.Date);
                    theAppointment.time = time;
                };

                if (i == 0 && theAppointment.id == -1) { rb.IsChecked = true; }
            }
        }

        public void Appointing(List<Appointment> appointments, List<DateTime> nextWeekDates, List<List<string>> nextWeekTimes, string doctor, Appointment theAppointment)
        {
            foreach (Appointment anAppointment in appointments)
            {
                DateTime date = Convert.ToDateTime(anAppointment.date);

                if (anAppointment.doctor == doctor && nextWeekDates.Contains(date))
                {
                    int dateIndex = (date - nextWeekDates[0]).Days;
                    nextWeekTimes[dateIndex].Remove(anAppointment.time);
                }
            }

            for (int i = 0; i<nextWeekTimes.Count; i++)
            {
                if (nextWeekTimes[i].Count == 0) { nextWeekDates[i] = nextWeekDates[i].AddYears(-1); }
            }

            while (DaysStackPanel.Children.Count > 0) { DaysStackPanel.Children.RemoveAt(0); }

            for (int i = 0; i < nextWeekTimes.Count; i++)
            {
                RadioButton rb = new RadioButton() { Content = nextWeekDates[i].Date };
                rb.Margin = new System.Windows.Thickness(10, 0, 0, 10);
                rb.FontSize = 16;

                DateTime date = nextWeekDates[i];
                List<string> DayTime = nextWeekTimes[i];
                rb.Checked += (sender, args) =>
                {
                    SetTimes(DayTime, doctor, date, theAppointment);
                };
                if (i == 0 && theAppointment.id == -1) { rb.IsChecked = true; }

                DaysStackPanel.Children.Add(rb);
            }
        }

        public void SetDoctors(List<string> doctors, List<Appointment> appointments, List<DateTime> nextSevenDays, List<List<string>> nextWeekTimes, Appointment theAppointment, Patient thePatient) 
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                RadioButton rb = new RadioButton() { Content = doctors[i] };
                rb.Margin = new System.Windows.Thickness(10, 0, 0, 10);
                rb.FontSize = 16;
    
                string theDoctor = doctors[i];
                rb.Checked += (sender, args) => 
                {
                    Appointing(appointments, nextSevenDays, nextWeekTimes, theDoctor, theAppointment);
                };

                if (i == 0 && theAppointment.id == -1) { rb.IsChecked = true; }
                if (theAppointment.doctor == theDoctor) { rb.IsChecked = true; }
                DoctorsStackPanel.Children.Add(rb);
            }
        }

        public Appointment theAppointment = new Appointment();
        public Patient thePatient = new Patient();
        public Objects obj = new Objects();
        public Time today = new Time() { currentDate = DateTime.Today };

        public Window1(Appointment appointment, Patient aPatient)
        {
            thePatient = aPatient;
            theAppointment = appointment;
            string appointmentsFileName = "appointments-1.json";
            string doctorsFileName = "doctors.json";
            InitializeComponent();

            AppointButton.Visibility = Visibility.Hidden;
            AppointButton.Click += (sender, EventArgs) => { ConfirmAppointment(sender, EventArgs, theAppointment, thePatient); };

            if (appointment.id == -1) { Title.Text = "Zakazivanje novog pregleda: "; }
            else { Title.Text = "Izmena termina: "; }

            List<Appointment> appointments = obj.JsonToAppointmentsList(appointmentsFileName);
            List<string> doctors = obj.JsonToDoctorsList(doctorsFileName);
            List<DateTime> nextSevenDays = today.DaysSetup();
            List<List<string>> nextWeekTimes = today.TimeSetup();

            SetDoctors(doctors, appointments, nextSevenDays, nextWeekTimes, theAppointment, thePatient);
        }

        private void ToMainPage(object sender, RoutedEventArgs e)
        {
            MainWindow objectMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objectMainWindow.Show();
        }

        private void ConfirmAppointment(object sender, EventArgs e, Appointment theAppointment, Patient thePatient)
        {
            int mark = 0;
            List<Appointment> appointments = obj.JsonToAppointmentsList("appointments-1.json");
            int appointmentsCount = appointments.Count();
            if (theAppointment.id == -1) { mark = 1; theAppointment.id = appointmentsCount + 1; appointments.Add(theAppointment); }
            else { appointments[theAppointment.id] = theAppointment; }

            string json = JsonConvert.SerializeObject(appointments);
            File.WriteAllText("appointments-1.json", json);

            if (mark == 1) 
            { 
                thePatient.appointings.Add(DateTime.Today.Date.ToString()); 

                if (thePatient.appointings.Count == 8 && (Convert.ToDateTime(thePatient.appointings[7])- Convert.ToDateTime(thePatient.appointings[0])).Days > 30)
                {
                    thePatient.status = "blocked";

                    string json1 = File.ReadAllText("patients.json");
                    Dictionary<string, Patient> patientsBookk = JsonConvert.DeserializeObject<Dictionary<string, Patient>>(json);
                    patientsBookk[thePatient.medicalRecord.mail] = thePatient;

                    string json11 = JsonConvert.SerializeObject(patientsBookk);
                    File.WriteAllText("patients.json", json11);
                }
            }
            else
            {
                thePatient.changes.Add(DateTime.Today.Date.ToString());

                if (thePatient.changes.Count == 5 && (Convert.ToDateTime(thePatient.changes[4]) - Convert.ToDateTime(thePatient.appointings[0])).Days > 30)
                {
                    thePatient.status = "blocked";

                    string json1 = File.ReadAllText("patients.json");
                    Dictionary<string, Patient> patientsBookk = JsonConvert.DeserializeObject<Dictionary<string, Patient>>(json);
                    patientsBookk[thePatient.medicalRecord.mail] = thePatient;

                    string json11 = JsonConvert.SerializeObject(patientsBookk);
                    File.WriteAllText("patients.json", json11);
                }
            }

            string json12 = File.ReadAllText("patients.json");
            Dictionary<string, Patient> patientsBook = JsonConvert.DeserializeObject<Dictionary<string, Patient>>(json);
            patientsBook[thePatient.medicalRecord.mail] = thePatient;

            string json122 = JsonConvert.SerializeObject(patientsBook);
            File.WriteAllText("patients.json", json122);
        }
    }
}

