using System;
using System.Windows.Forms;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Users.Model;
using ProjectUSI.Users.View;

namespace ProjectUSI.Manager.View
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
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _MainRepository.Save();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Dispose(false);
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
            EquipmentController equipmentController = new EquipmentController(new Equipment(), equipmentWindow, _MainRepository);
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
            RenovationController renovationController = new RenovationController(new Renovation(), renovationWindow, _MainRepository);
            renovationWindow._controller = renovationController;
            renovationWindow.Show();
        }
    }
}