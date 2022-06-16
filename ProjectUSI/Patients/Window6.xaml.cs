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

namespace Patients
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        static HospitalQuery query = new HospitalQuery(5, 5, 5, 5, 5.0, "");

        public Window6()
        {
            InitializeComponent();
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            RadioButton button = (RadioButton)sender;

            string name = button.Name;
            int grade = Int32.Parse(name[name.Length - 1].ToString()) ;

            if (name[0].ToString() == "Q") { query.quality = grade; }
            if (name[0].ToString() == "H") { query.hygiene = grade; }
            if (name[0].ToString() == "S") { query.satisfied = grade; }
            if (name[0].ToString() == "R") { query.recommendation = grade; }
        }

        private void Clicked(object sender, RoutedEventArgs e)
        {
            query.average = (double) ((query.hygiene + query.quality + query.satisfied + query.recommendation) / 4);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            query.comment = textBox.Text;
        }
    }
}
