using System;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class RoomController
    {
        private Room _model;
        private RoomRepository _roomRepository;
        private MainRepository _mainRepository;
        private RoomsWindow _view;

        public RoomController(Room model, RoomsWindow view, MainRepository mainRepository)
        {
            this._model = model;
            this._mainRepository = mainRepository;
            this._roomRepository = _mainRepository.RoomRepository;
            this._view = view;
        }
        
        private void ResetForm()
        {
            _view = new RoomsWindow(_mainRepository, new RoomController(_model, null, _mainRepository));
            _view.Show();
        }

        public void DeleteRoom(int index)
        {
            Room room = _roomRepository.GetRooms()[index];
            if (room != null)
            {
                _roomRepository.DeleteRoom(room);
                this.ResetForm();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void UpdateRoom(int index)
        {
            Room room = _roomRepository.GetRooms()[index];
            if (room != null)
            {
                _roomRepository.UpdateRoom(room);
                AddRoomWindow addRoomWindow = new AddRoomWindow(_mainRepository, room);
                addRoomWindow.Show();
                
                
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }

        
    }
}