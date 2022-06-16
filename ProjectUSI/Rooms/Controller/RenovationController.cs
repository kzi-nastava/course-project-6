using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Rooms.Repository;
using ProjectUSI.Rooms.View;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Rooms.Controller
{
    
    public class RenovationController
    {
        private Renovation _model;
        private RenovationRepository _renovationRepository;
        private MainRepository _mainRepository;
        private ConfirmRenovationWindow _view;

        public Renovation Model
        {
            get => _model;
            set => _model = value;
        }

        public RenovationRepository RenovationRepository
        {
            get => _renovationRepository;
            set => _renovationRepository = value;
        }

        public MainRepository MainRepository
        {
            get => _mainRepository;
            set => _mainRepository = value;
        }

        public ConfirmRenovationWindow View
        {
            get => _view;
            set => _view = value;
        }

        public RenovationController(Renovation model, ConfirmRenovationWindow view, MainRepository mainRepository)
        {
            this._model = model;
            this._mainRepository = mainRepository;
            this._renovationRepository = _mainRepository.RenovationRepository;
            this._view = view;
        }



        public void AddRenovation(Renovation renovation)
        {
            _renovationRepository.Add(renovation);
        }
        
        public Room FindRoomByIndex(int index)
        {
            Room room = _mainRepository.RoomRepository.GetRooms()[index];
            if (room != null)
            {
                return room;
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }

        public void TryRenovation(Room firstRoom, Room secondRoom, DateTime startDate, DateTime endDate, RenovationType type)
        {
            if (IsValidDate(startDate, endDate))
            {
                Renovation renovation = new Renovation(firstRoom, secondRoom, startDate, endDate, type);
                if (IsAvailableRenovation(renovation))
                {   
                    this.AddRenovation(renovation);
                }
                else
                {
                    MessageBox.Show("Room is not available for renovation!");
                }
            }
            else throw new DateIsNotValidException();
        }

        public void CheckRoomsInRenovation()
        {
            DeselectRoomsInRenovation();
            ReturnRoomsInUse();
        }

        public void DeselectRoomsInRenovation()
        {
            foreach (Renovation renovation in _renovationRepository.GetRenovation())
            {
                if (IsPastDate(renovation.DateOfBegnning))
                {
                    _mainRepository.RoomRepository.DeleteRoom(renovation.PrimaryRoom);
                }
            }
        }
        
        public void ReturnRoomsInUse()
        {
            foreach (Renovation renovation in _renovationRepository.GetRenovation())
            {
                if (IsPastDate(renovation.DateOfEnd))
                {
                    switch (renovation.Type)
                    {
                        case RenovationType.Splitting:
                            Splitting(renovation);
                            break;
                        case RenovationType.Merging:
                            Merging(renovation);
                            break;
                    }
                    
                    _mainRepository.RoomRepository.DeleteRoom(renovation.PrimaryRoom);
                }
            }
        }

        public void Merging(Renovation renovation)
        {
            if (renovation.Type == RenovationType.Merging)
            {
                Room newRoom = new Room(renovation.RoomToAttach.Name, renovation.RoomToAttach.Id, renovation.PrimaryRoom.Purpose, renovation.PrimaryRoom.Area + renovation.RoomToAttach.Area);
                foreach (Equipment.Model.Equipment equipment in _mainRepository.EquipmentRepository.GetEquipment())
                {
                    if (equipment.DeployedIn.Id == renovation.PrimaryRoom.Id || equipment.DeployedIn.Id == renovation.RoomToAttach.Id)
                    {
                        _mainRepository.EquipmentRepository.UpdateEquipmentRoom(equipment, newRoom);
                    }
                }
                _mainRepository.RoomRepository.InsertRooom(newRoom);
            }
        }
        
        public void Splitting(Renovation renovation)
        {
            if (renovation.Type == RenovationType.Merging)
            {
                renovation.PrimaryRoom.Area = renovation.RoomToAttach.Area;
                _mainRepository.RoomRepository.InsertRooom(renovation.PrimaryRoom);
                _mainRepository.RoomRepository.InsertRooom(renovation.RoomToAttach);
            }
        }
        

        private bool IsPastDate(DateTime date)
        {
            DateTime now = DateTime.Now;
            int compare = DateTime.Compare(now, date);
            if (compare<0)
            {
                return false;
            }
            return true;
        }

        private bool IsValidDate(DateTime start, DateTime stop)
        {
            DateTime now = DateTime.Now;
            int startToStop = DateTime.Compare(start, stop);
            int startToNow = DateTime.Compare(now, start);
            if (startToStop>0 || startToNow>0)
            {
                return false;
            }
            return true;
        }

        private Dictionary<string, List<DateTime>> GetApointedTimeSlots()
        {
            AppointmentsRepository appointmentsRepository = new AppointmentsRepository();
            List<Appointments> appointments = appointmentsRepository.GetAppointments();
            Dictionary<string, List<DateTime>> bussyRooms = new Dictionary<string, List<DateTime>>();
            foreach (Appointments appointment in appointments)
            {
                if (bussyRooms.ContainsKey(appointment.RoomId)) {
                    bussyRooms[appointment.RoomId].Add(DateTime.ParseExact(appointment.Date, "dd.MM.yyyy.", CultureInfo.CurrentCulture));
                } else
                {
                    bussyRooms[appointment.RoomId] = new List<DateTime>();
                    bussyRooms[appointment.RoomId].Add(DateTime.ParseExact(appointment.Date, "dd.MM.yyyy.", CultureInfo.CurrentCulture));
                }
            }

            return bussyRooms;
        }

        public bool IsAvailableRenovation(Renovation renovation)
        {
            Dictionary<string, List<DateTime>> bussyRooms = GetApointedTimeSlots();
            if ((bussyRooms.Keys.Contains(renovation.PrimaryRoom.Id) &&
                 bussyRooms[renovation.PrimaryRoom.Id].Contains(renovation.DateOfBegnning))|| (bussyRooms.Keys.Contains(renovation.PrimaryRoom.Id) &&
                    bussyRooms[renovation.PrimaryRoom.Id].Contains(renovation.DateOfEnd)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
    [Serializable]
    public class DateIsNotValidException : Exception
    {

        public DateIsNotValidException() { }

        public DateIsNotValidException(string message)
            : base(message) { }

        public DateIsNotValidException(string message, Exception inner)
            : base(message, inner) { }

    }
}