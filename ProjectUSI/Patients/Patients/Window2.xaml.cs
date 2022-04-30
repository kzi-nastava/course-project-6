using System;
using System.Collections.Generic;
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
using System.IO;
using Newtonsoft.Json;

namespace Patients
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private void ChangeAppointment(object sender, EventArgs e, Appointment appointment)
        {
            Window1 window1 = new Window1(appointment, thePatient);
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
        private void DeleteAppointment(object sender, EventArgs e, Appointment appointment)
        {
            int mark = 0;
            if ((Convert.ToDateTime(appointment.date)-DateTime.Today.Date).Days <= 1)
            {
                mark = 1;
                string requestsS = File.ReadAllText("requests.json");
                List<Appointment> requests = JsonConvert.DeserializeObject<List<Appointment>>(requestsS);
                appointment.id = -1;
                requests.Add(appointment);

                requestsS = JsonConvert.SerializeObject(requests);
                File.WriteAllText("appointments-1.json", requestsS);
            }

            if (mark == 0)
            {
                string json = File.ReadAllText("appointments-1.json");
                List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                appointments.RemoveAt(appointment.id);

                json = JsonConvert.SerializeObject(appointments);
                File.WriteAllText("appointments-1.son", json);
            }
        }
        public void SetAppointments(List<Appointment> appointments)
        {
            foreach (Appointment appointment in appointments)
            {
                StackPanel sp = new StackPanel();
                TextBlock tb = new TextBlock();
                tb.Text = "Doktor: " + appointment.doctor + "\n" + "Datum: " + appointment.date + "\n" + "Vreme: " + appointment.time;

                List<string> type = new List<string> { appointment.doctor, appointment.date, appointment.time };

                tb.Width = 240;
                tb.HorizontalAlignment = HorizontalAlignment.Left;
                sp.Children.Add(tb);

                Button change = new Button() { Content = "Promeni" };
                change.Width = 80;
                change.HorizontalAlignment = HorizontalAlignment.Right;
                change.Click += (sender, e) => ChangeAppointment(sender, e, appointment);

                Button delete = new Button() { Content = "Izbrisi" };
                delete.Width = 80;
                delete.HorizontalAlignment = HorizontalAlignment.Right;
                delete.Click += (sender, e) => DeleteAppointment(sender, e, appointment);

                sp.Children.Add(change);
                sp.Children.Add(delete);

                DateTime date = Convert.ToDateTime(appointment.date);

                AppointmentsStackPanel.Children.Add(sp);
            }
        }
        public Patient thePatient = new Patient();
        public Window2(Patient aPatient)
        {
            InitializeComponent();
            thePatient = aPatient;
            string fileName = "appointments-1.json";
            string mail = aPatient.medicalRecord.mail;
            List<Appointment> appointments = aPatient.GetAppointments(fileName, thePatient.medicalRecord.mail);

            SetAppointments(appointments);
        }
    }
}
