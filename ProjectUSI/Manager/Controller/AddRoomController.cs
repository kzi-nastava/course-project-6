using System;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class AddRoomController
    {
        private Room _model;
        private MainRepository _mainRepository;
        private RoomRepository _roomRepository;
        private AddRoomWindow _view;

        public AddRoomController(Room model, AddRoomWindow view, MainRepository mainRepository)
        {
            this._model = model;
            this._mainRepository = mainRepository;
            this._roomRepository = mainRepository._RoomRepository;
            this._view = view;
        }
        private void ResetForm()
        {
            _view.Dispose();
            _view = new AddRoomWindow(_mainRepository, _model);
            _view.Show();
        }

        public void Submit(string name, string id, RoomPurpose roomPurpose, int area)
        {
            Room room = new Room()
            {
                Name = name,
                Id = id,
                Purpose = roomPurpose,
                Area = area
            };
            _roomRepository.InsertRooom(room);
            
            
        }
    }
}