using System;
using System.Windows.Forms;
using ProjectUSI.Rooms.Controller;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.View
{
    public partial class AddRoomWindow : Form
    {
        private MainRepository _MainRepository;
        private AddRoomController _controller;
        public AddRoomWindow(MainRepository mainRepository, Room room)
        {
            _MainRepository = mainRepository;
            _controller = new AddRoomController(room, this, _MainRepository);
            InitializeComponent();
            SetDefaultParams(room);
            InitComboBox();
            
        }
        
        private void InitComboBox()
        {
            cbPurpose.DataSource = Enum.GetValues(typeof(RoomPurpose));
            cbPurpose.SelectedItem = cbPurpose.Items[0];
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Submit(txtBoxNameOfRoom.Text, txtBoxIdOfRoom.Text, (RoomPurpose) cbPurpose.SelectedItem, Int32.Parse(txtBoxArea.Text));
                this.Dispose(false);
                RoomsWindow roomsWindow = new RoomsWindow(_MainRepository, new RoomController(new Room(), null, _MainRepository));
                roomsWindow.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong area input, area must be number!");
            }
            
        }

        private void SetDefaultParams(Room room)
        {
            if (room != null)
            {
                txtBoxNameOfRoom.Text = room.Name;
                txtBoxIdOfRoom.Text = room.Id;
                txtBoxArea.Text = room.Area.ToString();
                
            }
        }

        

    }
}