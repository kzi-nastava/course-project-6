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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {

        public void SetAnamneses(List<Anamnesis> anamneses)
        {
            foreach (Anamnesis anamnesis in anamneses)
            {
                StackPanel sp = new StackPanel();
                TextBlock tb = new TextBlock();
                tb.Text = "Doktor: " + anamnesis.doctor + "\n" + "Datum: " + anamnesis.date + "\n" + "Tip: " + anamnesis.type;

                tb.Width = 240;
                tb.HorizontalAlignment = HorizontalAlignment.Left;
                sp.Children.Add(tb);

                AnamnesesStackPanel.Children.Add(sp);
            }
        }
        public List<Anamnesis> anamneses;
        public List<Anamnesis> displayedAnamneses;

        public Window4(List<Anamnesis> allAnamneses)
        {
            displayedAnamneses = allAnamneses;
            anamneses = allAnamneses;
            InitializeComponent();
            SetAnamneses(anamneses);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AnamnesesStackPanel.Children.Clear();
            TextBox tb = (TextBox)sender;
            foreach (Anamnesis anamnesis in anamneses.ToList())
            {
                if ((anamnesis.doctor.Contains(tb.Text)) | (anamnesis.type.Contains(tb.Text)))
                {
                    displayedAnamneses.Add(anamnesis);

                    StackPanel sp = new StackPanel();
                    TextBlock tbl = new TextBlock();
                    tbl.Text = "Doktor: " + anamnesis.doctor + "\n" + "Datum: " + anamnesis.date + "\n" + "Tip: " + anamnesis.type;

                    tbl.Width = 240;
                    tbl.HorizontalAlignment = HorizontalAlignment.Left;
                    sp.Children.Add(tbl);

                    AnamnesesStackPanel.Children.Add(sp);
                }
            }
        }
        private void sort(object sender, RoutedEventArgs e)
        {
            List<Anamnesis> sortedList = new List<Anamnesis> { };
            RadioButton rb = (RadioButton)sender;
            if (rb != null) 
            { 
                if (rb.Name == "datum") 
                {
                    sortedList = displayedAnamneses.OrderBy(anamnesis => anamnesis.date).ToList();
                }
                if (rb.Name == "doktor")
                {
                    sortedList = displayedAnamneses.OrderBy(anamnesis => anamnesis.doctor).ToList();
                }
            }
            AnamnesesStackPanel.Children.Clear();
            SetAnamneses(sortedList);
        }
    }
}
