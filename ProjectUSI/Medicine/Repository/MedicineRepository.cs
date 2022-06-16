using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjectUSI.Medicine.Repository
{
    public class MedicineRepository
    {
        private List<Model.Medicine> _medicine;

        public MedicineRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Medicaments.json");
            List<Model.Medicine> medicine = JsonConvert.DeserializeObject<List<Model.Medicine>>(json);
            _medicine = medicine;
        }
        public List<Model.Medicine> GetMedicine()
        {
            return _medicine;
        }

        public void SetMedicine(List<Model.Medicine> medicine)
        {
            _medicine = medicine;
        }

        public Model.Medicine GetMedicineByName(string name)
        {
            foreach (Model.Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(name))
                {
                    return medicine;
                }
            }

            return null;
        }

        public void UpdateMedicine(Model.Medicine medicineForUpdate)
        {
            foreach (Model.Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(medicineForUpdate.Name))
                {
                    medicine.Ingredients = medicineForUpdate.Ingredients;
                    medicine.WayOfUse = medicineForUpdate.WayOfUse;
                }
            }
        }

        public void DeleteMedicine(Model.Medicine medicineToDelete)
        {
            foreach (Model.Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(medicineToDelete.Name))
                {
                    _medicine.Remove(medicineToDelete);
                }
            }
        }

        public void Add(Model.Medicine medicine)
        {
            _medicine.Add(medicine);
        }


        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Medicaments.json", JsonConvert.SerializeObject(_medicine));
        }
    }
}