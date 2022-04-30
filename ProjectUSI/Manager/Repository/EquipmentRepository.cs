using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class EquipmentRepository
    {
        private List<Equipment> _equipment;

        public EquipmentRepository()
        {
            string json = File.ReadAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Equipment.json");
            List<Equipment> equipment = JsonConvert.DeserializeObject<List<Equipment>>(json);
            _equipment = equipment;
        }

        public void DecreaseQuantity(string id)
        {
            foreach (Equipment equipment in _equipment)
            {
                if (equipment.Id.Equals(id) && equipment.Quantity!=0)
                {
                    --equipment.Quantity;
                }
            }
        }
        public List<Equipment> GetEquipment()
        {
            return this._equipment;
        }
        public void SetEquipment(List<Equipment> equipment)
        {
            this._equipment = equipment;
        }

        public Equipment GetEquipmentById(string id)
        {
            foreach (Equipment equipment in _equipment)
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
            File.WriteAllText(@"C:\Users\ANJA\course-project-6\ProjectUSI\Data\Equipment.json", JsonConvert.SerializeObject(_equipment));
        }
    }
}