using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Rooms.Model;


namespace ProjectUSI.Equipment.Repository
{
    public class EquipmentRepository
    {
        private List<Model.Equipment> _equipment;

        public EquipmentRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Equipment.json");
            List<Model.Equipment> equipment = JsonConvert.DeserializeObject<List<Model.Equipment>>(json);
            _equipment = equipment;
        }

        public void DecreaseQuantity(string id)
        {
            foreach (Model.Equipment equipment in _equipment)
            {
                if (equipment.Id.Equals(id) && equipment.Quantity!=0)
                {
                    --equipment.Quantity;
                }
            }
        }

        private Model.Equipment Find(Model.Equipment equipment)
        {
            foreach (Model.Equipment e in _equipment)
            {
                if (e.Equals(equipment))
                {
                    return equipment;
                }
            }

            return null;
        }

        public void UpdateEquipmentRoom(Model.Equipment equipment, Room room)
        {
            this.Find(equipment).DeployedIn = room;
        }
        public List<Model.Equipment> GetEquipment()
        {
            return this._equipment;
        }
        public void SetEquipment(List<Model.Equipment> equipment)
        {
            this._equipment = equipment;
        }

        public Model.Equipment GetEquipmentById(string id)
        {
            foreach (Model.Equipment equipment in _equipment)
            {
                if (equipment.Id.Equals(id))
                {
                    return equipment;
                }
            }
            return null;
        }
        
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Equipment.json", JsonConvert.SerializeObject(_equipment));
        }
    }
}