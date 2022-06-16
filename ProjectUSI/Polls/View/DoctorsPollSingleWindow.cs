using System.Collections.Generic;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Polls.Controller;
using ProjectUSI.Polls.Repository;

namespace ProjectUSI.Polls.View
{
    public partial class DoctorsPollSingleWindow : Form
    {
        private string _name;
        private DoctorsPollsRepository _doctorsPoolsRepository;
        private DoctorsPollsController _doctorsPoolsController;
        public DoctorsPollSingleWindow(DoctorsPollsRepository doctorsPoolsRepository, string name, DoctorsPollsController doctorsPoolsController)
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