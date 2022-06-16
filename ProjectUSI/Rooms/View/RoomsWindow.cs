using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Rooms.Controller;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.View
{
    public partial class RoomsWindow : Form
    {
        private MainRepository _mainRepository;
        private List<Room> _rooms;
        public RoomController _controller;
        
        public RoomsWindow(MainRepository mainRepository, RoomController roomController)
        {
            _mainRepository = mainRepository;
            _rooms = _mainRepository.RoomRepository.GetRooms();
            _controller = roomController;
            
            InitializeComponent();
            InitListBox(_rooms);

        }
        private void InitListBox(List<Room> rooms)
        {
            for (int i = 0; i < _rooms.Count; i++)
            {
                listBox1.Items.Add(rooms.ElementAt(i).ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            AddRoomWindow addRoomWindow = new AddRoomWindow(_mainRepository, null);
            addRoomWindow.Show();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                _controller.UpdateRoom(index);
                this.Dispose(false);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Room does not exist!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You need to select room!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                _controller.DeleteRoom(index);
                this.Dispose(true);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Room does not exist!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You need to select room!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnRenovate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                Room roomForRenovation = _mainRepository.RoomRepository.GetRooms()[index];
                ConfirmRenovationWindow confirm = new ConfirmRenovationWindow(roomForRenovation, _mainRepository, new RenovationController(null, null, _mainRepository));
                confirm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Room does not exist!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You need to select room!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
    
}