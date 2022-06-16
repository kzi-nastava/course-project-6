using System;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
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

        public void DeleteMedicine(Medicine medicine)
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

        public void UpdateMedicine(Medicine medicine)
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
        
        public void AddMedicine(Medicine medicine)
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