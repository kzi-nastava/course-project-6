using System.Collections.Generic;
using ProjectUSI.Equipment.Model;
using ProjectUSI.Equipment.View;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Equipment.Controller
{
    public class EquipmentController
    {
        private Model.Equipment _model;
        private MainRepository _MainRepository;
        private EquipmentWindow _view;

        public EquipmentController(Model.Equipment model, EquipmentWindow view, MainRepository mainRepository)
        {
            
            this._model = model;
            this._MainRepository = mainRepository;
            this._view = view;
        }
        private void ResetForm()
        {
            _view.Dispose();
            EquipmentWindow equipmentWindow = new EquipmentWindow(_MainRepository, new EquipmentController(_model, null, _MainRepository));
            equipmentWindow.Show();
        }

        public List<Model.Equipment> Filter(RoomPurpose roomPurpose, EquipmentType equipmentType, Quantity quantity)
        {
            List<Model.Equipment> temp = new List<Model.Equipment>();
            if (!roomPurpose.Equals(RoomPurpose.None))
            {
                foreach (Model.Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                {
                    if (equipment.DeployedIn.Purpose.Equals(roomPurpose))
                    {
                        temp.Add(equipment);
                    }
                }
            }
            else if (!equipmentType.Equals(EquipmentType.None))
            {
                foreach (Model.Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                {
                    if (equipment.EquipmentType.Equals(equipmentType))
                    {
                        temp.Add(equipment);
                    }
                }
            }
            else if (!quantity.Equals(Quantity.None))
            {
                int i = (int) quantity;
                switch (i)
                {
                    case 1:
                    {
                        foreach (Model.Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                        {
                            if (equipment.Quantity == 0)
                            {
                                temp.Add(equipment);
                            }
                        }

                        break;
                    }
                    case 2:
                    {
                        foreach (Model.Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                        {
                            if (equipment.Quantity < 10)
                            {
                                temp.Add(equipment);
                            }
                        }

                        break;
                    }
                    case 3:
                    {
                        foreach (Model.Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                        {
                            if (equipment.Quantity > 10)
                            {
                                temp.Add(equipment);
                            }
                        }

                        break;
                    }
                        
                            
                }
                
            }
            else
            {
                temp = _MainRepository.EquipmentRepository.GetEquipment();
            }

            return temp;
        }

        public void Relocate(Model.Equipment equipment)
        {
            this._MainRepository.EquipmentRepository.DecreaseQuantity(equipment.Id);
        }
        


    }
}