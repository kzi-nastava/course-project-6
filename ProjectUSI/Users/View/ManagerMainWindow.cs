using System;
using System.Windows.Forms;
using Patients.Models;
using ProjectUSI.Equipment.Controller;
using ProjectUSI.Equipment.View;
using ProjectUSI.Medicine.Controller;
using ProjectUSI.Medicine.View;
using ProjectUSI.Polls.Controller;
using ProjectUSI.Polls.View;
using ProjectUSI.Rooms.Controller;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Rooms.View;
using ProjectUSI.Users.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Users.View
{
    public partial class ManagerMainWindow : Form
    {
        private MainRepository _MainRepository;
        public ManagerMainWindow(User user)
        {
            _MainRepository = new MainRepository();
            InitializeComponent();
            InitPanel(user);
            
        }
        private void InitPanel(User user)
        {
            string message = String.Format(" Welcome {0}! \n\n First name: {1} \n Last name: {2} \n Telephone: {3} \n Date of birth: {4} \n LBO: {5}", 
                user.Email, user.FirstName, user.LastName, user.Telephone, user.DateOfBirth.ToString("dd.MM.yyyy."), user.LBO);
            label1.Text = label1.Text + message;
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsWindow roomsWindow = new RoomsWindow(_MainRepository, null);
            RoomController roomController = new RoomController(new Room(), roomsWindow, _MainRepository);
            roomsWindow._controller = roomController;
            roomsWindow.Show();
        }
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            EquipmentWindow equipmentWindow = new EquipmentWindow(_MainRepository, null);
            EquipmentController equipmentController = new EquipmentController(new Equipment.Model.Equipment(), equipmentWindow, _MainRepository);
            equipmentWindow._controller = equipmentController;
            equipmentWindow.Show();
        }


        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {
            _MainRepository.Save();
        }

        private void btnRenovation_Click(object sender, EventArgs e)
        {
            RenovationWindow renovationWindow = new RenovationWindow(_MainRepository, null);
            renovationWindow.Show();
        }

        private void btnMedicaments_Click(object sender, EventArgs e)
        {
            MedicineWindow medicineWindow = new MedicineWindow(new MedicineController(_MainRepository, null), _MainRepository);
            medicineWindow.Show();
        }

        private void btnRejectedMedicaments_Click(object sender, EventArgs e)
        {
            RequestWindow requestWindow = new RequestWindow(_MainRepository);
            requestWindow.Show();
        }

        private void btnPolls_Click(object sender, EventArgs e)
        {
            DoctorsPoolsWindow doctorsPoolsWindow =
                new DoctorsPoolsWindow(_MainRepository, new DoctorsPollsController(_MainRepository, new DoctorQuery()));
            doctorsPoolsWindow.Show();
        }

        private void btnHospitalPools_Click(object sender, EventArgs e)
        {
            HospitalPoolsWindow hospitalPoolsWindow =
                new HospitalPoolsWindow(_MainRepository, new HospitalPollsController(_MainRepository));
            hospitalPoolsWindow.Show();
        }
        
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            _MainRepository.Save();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

    }
}