using ProjectUSI.Rooms.Model;
using ProjectUSI.Rooms.Repository;
using ProjectUSI.Rooms.View;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.Controller
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
            this._roomRepository = mainRepository.RoomRepository;
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
            Room room = new Room(name, id, roomPurpose, area);
            _roomRepository.InsertRooom(room);
        }
    }
}