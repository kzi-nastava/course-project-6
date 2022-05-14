using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class ConfirmRenovationWindow : Form
    {
        private Room _firstRoom;
        private MainRepository _mainRepository;
        private RenovationController _controller;
        public ConfirmRenovationWindow(Room room, MainRepository mainRepository, RenovationController renovationController)
        {
            _firstRoom = room;
            _mainRepository = mainRepository;
            _controller = renovationController;
            _controller.View = this;
            _controller.CheckRoomsInRenovation();
            InitializeComponent();
            InitComboBox();
        }
        
        private void InitComboBox()
        {
            List<string> rooms = new List<string>();
            foreach (Room room in _mainRepository._RoomRepository.GetRooms())
            {
                if (room.Name != _firstRoom.Name)
                {
                    rooms.Add(room.Name);
                }
            }
            enabledRooms.DataSource = rooms;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbRenovation.Checked)
            {
                try
                {
                    _controller.TryRenovation(_firstRoom, null, startDatePicker.Value, endDatePicker.Value, RenovationType.SimpleRenovation);
                    this.Dispose(false);
                }
                catch (DateIsNotValidException exception)
                {
                    MessageBox.Show("Date must be valid!");
                }
            }
            else if (rbSplit.Checked)
            {
                try
                {
                    Random random = new Random();
                    _controller.TryRenovation(_firstRoom, new Room("room" + random.Next(0, 20), random.Next(0, 1000).ToString(), _firstRoom.Purpose, _firstRoom.Area/2), startDatePicker.Value, endDatePicker.Value, RenovationType.Splitting);
                    this.Dispose(false);
                }
                catch (DateIsNotValidException exception)
                {
                    MessageBox.Show("Date must be valid!");
                }
                
            }
            else if (rbMerge.Checked)
            {
                try
                {
                    _controller.TryRenovation(_firstRoom, _mainRepository._RoomRepository.GetRoomByName(enabledRooms.SelectedItem.ToString()), startDatePicker.Value, endDatePicker.Value, RenovationType.Merging);
                    this.Dispose(false);
                }
                catch (DateIsNotValidException exception)
                {
                    MessageBox.Show("Date must be valid!");
                }
            }
        }
    }
}