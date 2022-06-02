

namespace ProjectUSI.Manager.Repository
{
    public class MainRepository
    {
        public RoomRepository _RoomRepository { get; set; }
        public EquipmentRepository _EquipmentRepository { get; set; }
        public RelocationRepository _RelocationRepository { get; set; }
        public RenovationRepository _RenovationRepository { get; set; }

        public MedicineRepository MedicineRepository { get; set; }

        public MainRepository()
        {
            _RoomRepository = new RoomRepository();
            _EquipmentRepository = new EquipmentRepository();
            _RelocationRepository = new RelocationRepository();
            _RenovationRepository = new RenovationRepository();
            MedicineRepository = new MedicineRepository();
        }

        public void Save()
        {
            _RoomRepository.Save();
            _EquipmentRepository.Save();
            _RelocationRepository.Save();
            _RenovationRepository.Save();
            MedicineRepository.Save();
        }
    }
}