using System.Collections.Generic;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Polls.Controller;
using ProjectUSI.Polls.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Polls.View
{
    public partial class HospitalPoolsWindow : Form
    {
        private HospitalPollsRepository _hospitalPoolsRepository;
        private HospitalPollsController _controller;
        public HospitalPoolsWindow(MainRepository mainRepository, HospitalPollsController hospitalPollsController)
        {
            _controller = hospitalPollsController;
            _hospitalPoolsRepository = mainRepository.HospitalPollsRepository;
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