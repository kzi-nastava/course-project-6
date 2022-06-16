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
        private DoctorsPollsRepository doctorsPollsRepository;
        private DoctorsPollsController _controller;
        private MainRepository _mainRepository;

        public DoctorsPoolsWindow(MainRepository mainRepository, DoctorsPollsController doctorsPoolsController)
        {
            _mainRepository = mainRepository;
            _controller = doctorsPoolsController;
            doctorsPollsRepository = mainRepository.DoctorsPollsRepository;
            InitializeComponent();
            InitComboBoxes();
        }


        private void InitComboBoxes()
        {
            foreach (DoctorQuery doctorQuery in doctorsPollsRepository.GetPolls())
            {
                lbDoctorPools.Items.Add(doctorQuery.ToString());
            }
        }


        private void btnMore_Click(object sender, EventArgs e)
        {
            DoctorQuery doctorQuery = doctorsPollsRepository.GetPolls()[lbDoctorPools.SelectedIndex];
            DoctorsPollsController doctorsPoolsController = new DoctorsPollsController(_mainRepository, doctorQuery);
            doctorsPoolsController.InitDoctor();
            DoctorsPollSingleWindow doctorsPoolSingleWindow =
                new DoctorsPollSingleWindow(doctorsPollsRepository, doctorQuery.doctor, doctorsPoolsController);
            doctorsPoolSingleWindow.Show();
        }
    }
}