namespace ProjectUSI.Manager.Model
{
    public class Equipment
    {
        
        public string Id{ get; set; }
        public string Name{ get; set; }
        public Room DeployedIn{ get; set; }
        public EquipmentType EquipmentType{ get; set; }
        public int Quantity{ get; set; }
        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + DeployedIn.Id + "\t" + EquipmentType+"\t"+Quantity;
        }
        
    }
}