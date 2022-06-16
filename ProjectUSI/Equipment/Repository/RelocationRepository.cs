using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class RelocationRepository
    {
        private List<Relocation> _relocations;
        private EquipmentRepository _equipmentRepository;
        private RoomRepository _roomRepository;

        public RelocationRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Relocations.json");
            List<Relocation> relocation = JsonConvert.DeserializeObject<List<Relocation>>(json);
            _relocations = relocation;
            _roomRepository = new RoomRepository();
        }
        public List<Relocation> GetRelocations()
        {
            return this._relocations;
        }
        
        public EquipmentRepository GetEquipmentRepository()
        {
            return this._equipmentRepository;
        }
        
        public RoomRepository GetRoomRepository()
        {
            return this._roomRepository;
        }

        public Room GetDeployedFromById(string id)
        {
            return _roomRepository.GetRoomById(id);
        }

        public void Add(Relocation relocation)
        {
            _relocations.Add(relocation);
        }


        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Relocations.json", JsonConvert.SerializeObject(_relocations));
        }
    }
}