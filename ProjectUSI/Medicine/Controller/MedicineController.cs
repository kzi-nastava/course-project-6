using System;
using ProjectUSI.Medicine.Repository;
using ProjectUSI.Medicine.View;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Medicine.Controller
{
    public class MedicineController
    {
        private MedicineRepository _medicineRepository;
        private MainRepository _mainRepository;
        private MedicineWindow _view;

        public MedicineController(MainRepository mainRepository, MedicineWindow view)
        {
            _mainRepository = mainRepository;
            _medicineRepository = _mainRepository.MedicineRepository;
            _view = view;
        }

        private void ResetForm()
        {
            _view = new MedicineWindow(this, _mainRepository);
            _view.Show();
        }

        public void DeleteMedicine(Model.Medicine medicine)
        {
            if (medicine != null)
            {
                _medicineRepository.DeleteMedicine(medicine);
                this.ResetForm();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void UpdateMedicine(Model.Medicine medicine)
        {
            if (medicine != null)
            {
                _medicineRepository.UpdateMedicine(medicine);
                this.ResetForm();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        
        public void AddMedicine(Model.Medicine medicine)
        {
            if (medicine != null)
            {
                _medicineRepository.Add(medicine);
                this.ResetForm();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        

        
    }
}