using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectUSI.Rooms.Controller;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.View
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
            foreach (Room room in _mainRepository.RoomRepository.GetRooms())
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
                SimpleRenovation();
            }
            else if (rbSplit.Checked)
            {
                RenovationWithSplitting();
                
            }
            else if (rbMerge.Checked)
            {
                RenovationWithMerging();
            }
        }

        private void SimpleRenovation()
        {
            try
            {
                _controller.TryRenovation(_firstRoom, null, startDatePicker.Value, endDatePicker.Value, RenovationType.SimpleRenovation);
                _mainRepository.RenovationRepository.Save();
                this.Dispose(false);
            }
            catch (DateIsNotValidException exception)
            {
                MessageBox.Show("Date must be valid!");
            }
        }

        private void RenovationWithSplitting()
        {
            try
            {
                Random random = new Random();
                _controller.TryRenovation(_firstRoom, new Room("room" + random.Next(0, 20), random.Next(0, 1000).ToString(), _firstRoom.Purpose, _firstRoom.Area/2), startDatePicker.Value, endDatePicker.Value, RenovationType.Splitting);
                _mainRepository.RenovationRepository.Save();
                this.Dispose(false);
            }
            catch (DateIsNotValidException exception)
            {
                MessageBox.Show("Date must be valid!");
            }
        }

        private void RenovationWithMerging()
        {
            try
            {
                _controller.TryRenovation(_firstRoom, _mainRepository.RoomRepository.GetRoomByName(enabledRooms.SelectedItem.ToString()), startDatePicker.Value, endDatePicker.Value, RenovationType.Merging);
                _mainRepository.RenovationRepository.Save();
                this.Dispose(false);
            }
            catch (DateIsNotValidException exception)
            {
                MessageBox.Show("Date must be valid!");
            }
        }
    }
}