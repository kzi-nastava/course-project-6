using System;
using ProjectUSI.Rooms.Model;

namespace ProjectUSI.Equipment.Model
{
    [Serializable()]
    public class Relocation
    {
        public Relocation(){}
        public Room From { get; set; }
        public Room To { get; set; }
        public string DateTime { get; set; }

        public Relocation(Room from, Room to, string dateTime)
        {
            From = from;
            To = to;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return From.ToString() + "\t" + DateTime + "\t" + To.ToString();
        }
    }
    
}