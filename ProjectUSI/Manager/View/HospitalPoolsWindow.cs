using System.Collections.Generic;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class HospitalPoolsWindow : Form
    {
        private HospitalPoolsRepository _hospitalPoolsRepository;
        private HospitalPoolsController _controller;
        public HospitalPoolsWindow(MainRepository mainRepository, HospitalPoolsController hospitalPoolsController)
        {
            _controller = hospitalPoolsController;
            _hospitalPoolsRepository = mainRepository.HospitalPoolsRepository;
            InitializeComponent();
            InitAverages();
            InitComboBoxes();
            InitComments();
        }

        private void InitAverages()
        {
            averageHygiene.Text = "" + _controller.GetAverage("hygiene");
            averageQuality.Text = "" + _controller.GetAverage("quality");
            averageRecomendation.Text = "" + _controller.GetAverage("recommendation");
            averageSatisfaction.Text = "" + _controller.GetAverage("satisfied");
        }

        private void InitComboBoxes()
        {
            Dictionary<string, Dictionary<int, int>> grades = _controller.GetGrades();
            for (int i = 1; i < 6; i++)
            {
                cbHygiene.Items.Add( "Number of " + i + " = " + grades["hygiene"][i]);
                cbQuality.Items.Add( "Number of " + i + " = " + grades["quality"][i]);
                cbRecomendation.Items.Add( "Number of " + i + " = " + grades["recommendation"][i]);
                cbSatisfaction.Items.Add( "Number of " + i + " = " + grades["satisfied"][i]);
            }
        }

        private void InitComments()
        {
            foreach (HospitalQuery hospitalQuery in _controller.GetPools())
            {
                comments.Items.Add(hospitalQuery.comment);
            }
        }
    }
}