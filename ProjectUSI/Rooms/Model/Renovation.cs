using System;

namespace ProjectUSI.Rooms.Model
{
    public class Renovation
    {
        public Renovation(){}
        public Room PrimaryRoom { get; set; }
        public Room RoomToAttach { get; set; }
        public DateTime DateOfBegnning { get; set; }
        public DateTime DateOfEnd { get; set; }

        public RenovationType Type { get; set; }

        public Renovation(Room primaryRoom, Room roomToAttach, DateTime dateOfBegnning, DateTime dateOfEnd, RenovationType type)
        {
            PrimaryRoom = primaryRoom;
            RoomToAttach = roomToAttach;
            DateOfBegnning = dateOfBegnning;
            DateOfEnd = dateOfEnd;
            Type = type;
        }

        public override string ToString()
        {
            if (RoomToAttach == null)
            {
                return "Room id: " + PrimaryRoom.Id + ", Start date: " + DateOfBegnning.Date + ", End date: " + DateOfEnd.Date+ ", Renovation type: " + Type;
            }
            else
            {
                return "Room id: " + PrimaryRoom.Id + " Start date: " + DateOfBegnning.Date + ", End date: " + DateOfEnd.Date
                    + ", Room to attach id: " + RoomToAttach.Id + ", Renovation type: " + Type;
            }
        }
    }
}