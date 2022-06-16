using System;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Polls.Controller;
using ProjectUSI.Polls.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Polls.View
{
    public partial class DoctorsPoolsWindow : Form
    {
        private DoctorsPoolsRepository _doctorsPoolsRepository;
        private DoctorsPoolsController _controller;
        private MainRepository _mainRepository;

        public DoctorsPoolsWindow(MainRepository mainRepository, DoctorsPoolsController doctorsPoolsController)
        {
            _mainRepository = mainRepository;
            _controller = doctorsPoolsController;
            _doctorsPoolsRepository = mainRepository.DoctorsPoolsRepository;
            InitializeComponent();
            InitComboBoxes();
        }


        private void InitComboBoxes()
        {
            foreach (DoctorQuery doctorQuery in _doctorsPoolsRepository.GetPools())
            {
                lbDoctorPools.Items.Add(doctorQuery.ToString());
            }
        }


        private void btnMore_Click(object sender, EventArgs e)
        {
            DoctorQuery doctorQuery = _doctorsPoolsRepository.GetPools()[lbDoctorPools.SelectedIndex];
            DoctorsPoolsController doctorsPoolsController = new DoctorsPoolsController(_mainRepository, doctorQuery);
            doctorsPoolsController.InitDoctor();
            DoctorsPoolSingleWindow doctorsPoolSingleWindow =
                new DoctorsPoolSingleWindow(_doctorsPoolsRepository, doctorQuery.doctor, doctorsPoolsController);
            doctorsPoolSingleWindow.Show();
        }
    }
}