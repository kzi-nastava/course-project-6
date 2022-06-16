using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Rooms.Model;

namespace ProjectUSI.Rooms.Repository
{
    public class RoomRepository
    {
        private List<Room> _rooms;

        public RoomRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Rooms.json");
            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(json);
            _rooms = rooms;
        }
        
        public List<Room> GetRooms()
        {
            return this._rooms;
        }

        public Room GetRoomById(string id)
        {
            foreach (Room room in _rooms)
            {
                if (room.Id.Equals(id))
                {
                    return room;
                }
            }
            return null;
        }
        
        public Room GetRoomByName(string name)
        {
            foreach (Room room in _rooms)
            {
                if (room.Name.Equals(name))
                {
                    return room;
                }
            }
            return null;
        }

        public void InsertRooom(Room room)
        {
            _rooms.Add(room);
        }

        public void DeleteRoom(Room room)
        {
            _rooms.Remove(room);
        }

        public void UpdateRoom(Room room)
        {
            Room roomForUpdate = GetRoomById(room.Id);
            _rooms.Remove(roomForUpdate);
            roomForUpdate.Name = room.Name;
            roomForUpdate.Purpose = room.Purpose;
            roomForUpdate.Area = room.Area;
            _rooms.Add(roomForUpdate);
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Rooms.json", JsonConvert.SerializeObject(_rooms));
        }
    }
}