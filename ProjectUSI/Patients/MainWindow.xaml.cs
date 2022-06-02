using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Patients.Models;
using Newtonsoft.Json;

namespace Patients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient JsonToClassObject(string fileName, string mail)
        {
            string json = File.ReadAllText(fileName);
            Dictionary<string, Patient> patientsBook = JsonConvert.DeserializeObject<Dictionary<string, Patient>>(json);
            Patient aPatient = patientsBook[mail];
            return aPatient;
        }

        public Patient aPatient { get; set; }
        public Appointment appointment = new Appointment { id = -1 };

        public MainWindow ()
        { 
            string fileName = "patients.json";
            string mail = "marinap@gmail.com";

            aPatient = JsonToClassObject(fileName, mail);

            InitializeComponent();
            if (aPatient.status == "blocked") { this.Close(); }
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            List<string> type = new List<string> { "", "", "" };
            Window1 objectWindow1 = new Window1(appointment, aPatient);
            this.Visibility = Visibility.Hidden;
            objectWindow1.Show();
        }

        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            Window2 objectWindow2 = new Window2(aPatient);
            this.Visibility = Visibility.Hidden;
            objectWindow2.Show();
        }

        private void OpenWindow4(object sender, RoutedEventArgs e)
        {
            Window4 objectWindow4 = new Window4(aPatient.anamnesis);
            this.Visibility = Visibility.Hidden;
            objectWindow4.Show();
        }

        private void OpenWindow3(object sender, RoutedEventArgs e)
        {
            Window3 objectWindow3 = new Window3();
            this.Visibility = Visibility.Hidden;
            objectWindow3.Show();
        }
    }
}
