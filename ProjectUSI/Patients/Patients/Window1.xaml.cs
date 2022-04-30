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

namespace Patients
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<Appointment> JsonToAppointmentsList(string fileName)
        {
            string json = File.ReadAllText(fileName);
            List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
            return appointments;
        }

        public List<string> JsonToDoctorsList(string fileName)
        {
            string json = File.ReadAllText(fileName);
            List<string> doctors = JsonConvert.DeserializeObject<List<string>>(json);
            return doctors;
        }

        public List<List<string>> TimeSetup()
        {
            List<string> times = new List<string>
                                {
                                  "8:00", "8:15", "8:30", "8:45",
                                  "9:00", "9:15", "9:30", "9:45",
                                  "10:00", "10:15", "10:30", "10:45",
                                  "11:00", "11:15", "11:30", "11:45",
                                  "12:00", "12:15", "12:30", "12:45",
                                  "13:00", "13:15", "13:30", "13:45",
                                  "14:00", "14:15", "14:30", "14:45",
                                  "15:00", "15:15", "15:30", "15:45",
                                  "16:00", "16:15", "16:30", "16:45",
                                  "17:00", "17:15", "17:30", "17:45",
                                  "18:00", "18:15", "18:30", "18:45",
                                  "19:00", "19:15", "19:30", "19:45"
                                };

            List<List<string>> nextWeekTimes = new List<List<string>>();
            for (int i = 0; i < 7; i++) { nextWeekTimes.Add(times); }

            return nextWeekTimes;
        }
        public List<DateTime> DaysSetup()
        {
            DateTime currentDate = DateTime.Now;
            DateTime firstDate = currentDate.AddDays(2);
            List<DateTime> nextSevenDays = new List<DateTime>();

            for (int i = 0; i < 7; i++) { nextSevenDays.Add(firstDate.AddDays(i).Date); Console.WriteLine(firstDate.AddDays(i).Date); }

            return nextSevenDays;
        }

        /*
                public int TimeStrToInt(string time)
                {
                    Dictionary<string, int> minutesToInts = new Dictionary<string, int>()
                    {
                        {"00", 0},
                        {"15", 1},
                        {"30", 2},
                        {"45", 3},
                    };

                    string[] subs = time.Split(':');
                    string hourS = subs[0];
                    string minuteS = subs[1];
                    int hours = Int32.Parse(hourS);
                    int minutes = minutesToInts[minuteS];

                    int timeIndex = 4 * (hours - 8) + minutes;
                    return timeIndex;
                }
        */

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

            List<Appointment> appointments = JsonToAppointmentsList(appointmentsFileName);
            List<string> doctors = JsonToDoctorsList(doctorsFileName);
            List<DateTime> nextSevenDays = DaysSetup();
            List<List<string>> nextWeekTimes = TimeSetup();
            

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
            List<Appointment> appointments = JsonToAppointmentsList("appointments-1.json");
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

