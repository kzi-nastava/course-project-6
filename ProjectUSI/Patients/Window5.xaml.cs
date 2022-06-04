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
using Patients.Set;
using Patients.Models;

namespace Patients
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public List<string> doctors;
        public Objects obj = new Objects();
        public Appointment appointment = new Appointment();
        public Patient aPatient = new Patient();

        private void button_click(object senderr, EventArgs ee)
        {
            Button button = (Button)senderr;
            string doctor = button.Name.Replace("_", " ");
            appointment.doctor = doctor;

            Window1 objectWindow1 = new Window1(appointment, aPatient);
            this.Visibility = Visibility.Hidden;
            objectWindow1.Show();
        }
        public Window5()
        {
            doctors = obj.JsonToDoctorsList("doctors.json");
            InitializeComponent();
        }

        private void TextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            DoctorsStackPanel.Children.Clear();
            TextBox tb = (TextBox)sender;
            foreach (string doctor in doctors)
            {
                if (doctor.Contains(tb.Text) & tb.Text != "") 
                {
                    Button button = new Button();
                    button.Content = doctor;
                    button.Name = doctor.Replace(" ", "_");
                    button.Click += (senderr, ee) => button_click(senderr, ee);
                    DoctorsStackPanel.Children.Add(button);
                }
            }
        }
    }
}
