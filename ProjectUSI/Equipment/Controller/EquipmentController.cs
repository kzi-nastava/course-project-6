
using System.Collections.Generic;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class EquipmentController
    {
        private Equipment _model;
        private MainRepository _MainRepository;
        private EquipmentWindow _view;

        public EquipmentController(Equipment model, EquipmentWindow view, MainRepository mainRepository)
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

        public List<Equipment> Filter(RoomPurpose roomPurpose, EquipmentType equipmentType, Quantity quantity)
        {
            List<Equipment> temp = new List<Equipment>();
            if (!roomPurpose.Equals(RoomPurpose.None))
            {
                foreach (Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
                {
                    if (equipment.DeployedIn.Purpose.Equals(roomPurpose))
                    {
                        temp.Add(equipment);
                    }
                }
            }
            else if (!equipmentType.Equals(EquipmentType.None))
            {
                foreach (Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
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
                        foreach (Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
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
                        foreach (Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
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
                        foreach (Equipment equipment in _MainRepository.EquipmentRepository.GetEquipment())
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

        public void Relocate(Equipment equipment)
        {
            this._MainRepository.EquipmentRepository.DecreaseQuantity(equipment.Id);
        }
        


    }
}