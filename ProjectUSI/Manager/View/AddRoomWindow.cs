using System;
using System.Windows.Forms;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class AddRoomWindow : Form
    {
        private MainRepository _MainRepository;
        public AddRoomController _controller;
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
                string name = txtBoxNameOfRoom.Text;
                string id = txtBoxIdOfRoom.Text;
                RoomPurpose purpose = (RoomPurpose) cbPurpose.SelectedItem;
                int area = Int32.Parse(txtBoxArea.Text);
                _controller.Submit(name, id, purpose, area);
                this.Dispose(false);
                RoomsWindow roomsWindow =
                    new RoomsWindow(_MainRepository, new RoomController(new Room(), null, _MainRepository));
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