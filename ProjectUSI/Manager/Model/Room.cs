namespace ProjectUSI.Manager.Model
{
    public class Room
    {

        public string Name{ get; set; }

        public string Id{ get; set; }

        public RoomPurpose Purpose{ get; set; }

        public int Area{ get; set; }
        
        public override string ToString()
        {
            return Name + "\t" + Id + "\t" + Purpose + "\t" + Area;
        }
        public Room(string name, string id, RoomPurpose purpose, int area)
        {
            Name = name;
            Id = id;
            Purpose = purpose;
            Area = area;
        }
        public Room()
        {
            Name = "";
            Id = "";
            Purpose = RoomPurpose.None;
            Area = 0;
        }
    }
}