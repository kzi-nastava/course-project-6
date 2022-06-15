using System.Collections.Generic;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class DoctorsPoolSingleWindow : Form
    {
        private string _name;
        private DoctorsPoolsRepository _doctorsPoolsRepository;
        private DoctorsPoolsController _doctorsPoolsController;
        public DoctorsPoolSingleWindow(DoctorsPoolsRepository doctorsPoolsRepository, string name, DoctorsPoolsController doctorsPoolsController)
        {
            _name = name;
            _doctorsPoolsRepository = doctorsPoolsRepository;
            _doctorsPoolsController = doctorsPoolsController;
            InitializeComponent();
            InitTextBoxes();
            InitComboBoxes();
            InitComments();
        }

        private void InitTextBoxes()
        {
            tbName.Text = _name;
            averageQuality.Text = "" + _doctorsPoolsController.GetAverage("quality");
            averageRecomendation.Text = "" + _doctorsPoolsController.GetAverage("recommendation");
        }
        private void InitComboBoxes()
        {
            Dictionary<string, Dictionary<int, int>> grades = _doctorsPoolsController.GetDoctorsGrades();
            for (int i = 1; i < 6; i++)
            {
                cbQuality.Items.Add( "Number of " + i + " = " + grades["quality"][i]);
                cbRecomendation.Items.Add( "Number of " + i + " = " + grades["recommendation"][i]);
            }
        }
        private void InitComments()
        {
            foreach (DoctorQuery doctorQuery in _doctorsPoolsController.GetDoctorsPols())
            {
                if (_name.Equals(doctorQuery.doctor))
                {
                    comments.Items.Add(doctorQuery.comment);
                }
            }
        }
        
        
    }
}