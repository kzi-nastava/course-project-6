using ProjectUSI.Equipment.Repository;
using ProjectUSI.Medicine.Repository;
using ProjectUSI.Polls.Repository;
using ProjectUSI.Rooms.Repository;

namespace ProjectUSI.Users.Repository
{
    public class MainRepository
    {
        public RoomRepository RoomRepository { get; set; }
        public EquipmentRepository EquipmentRepository { get; set; }
        public RelocationRepository RelocationRepository { get; set; }
        public RenovationRepository RenovationRepository { get; set; }
        public RequestRepository RequestRepository { get; set; }

        public MedicineRepository MedicineRepository { get; set; }
        
        public HospitalPollsRepository HospitalPollsRepository { get; set; }
        public DoctorsPollsRepository DoctorsPollsRepository { get; set; }

        public MainRepository()
        {
            RoomRepository = new RoomRepository();
            EquipmentRepository = new EquipmentRepository();
            RelocationRepository = new RelocationRepository();
            RenovationRepository = new RenovationRepository();
            MedicineRepository = new MedicineRepository();
            RequestRepository = new RequestRepository();
            HospitalPollsRepository = new HospitalPollsRepository();
            DoctorsPollsRepository = new DoctorsPollsRepository();
        }

        public void Save()
        {
            RoomRepository.Save();
            EquipmentRepository.Save();
            RelocationRepository.Save();
            RenovationRepository.Save();
            MedicineRepository.Save();
            RequestRepository.Save();
            HospitalPollsRepository.Save();
            DoctorsPollsRepository.Save();
        }
    }
}