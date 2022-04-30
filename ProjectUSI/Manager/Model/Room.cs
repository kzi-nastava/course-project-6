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
    }
}