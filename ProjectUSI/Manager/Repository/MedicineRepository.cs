using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class MedicineRepository
    {
        private List<Medicine> _medicine;

        public MedicineRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Medicaments.json");
            List<Medicine> medicine = JsonConvert.DeserializeObject<List<Medicine>>(json);
            _medicine = medicine;
        }
        public List<Medicine> GetMedicine()
        {
            return _medicine;
        }

        public void SetMedicine(List<Medicine> medicine)
        {
            _medicine = medicine;
        }

        public Medicine GetMedicineByName(string name)
        {
            foreach (Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(name))
                {
                    return medicine;
                }
            }

            return null;
        }

        public void UpdateMedicine(Medicine medicineForUpdate)
        {
            foreach (Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(medicineForUpdate.Name))
                {
                    medicine.Ingredients = medicineForUpdate.Ingredients;
                    medicine.WayOfUse = medicineForUpdate.WayOfUse;
                }
            }
        }

        public void DeleteMedicine(Medicine medicineToDelete)
        {
            foreach (Medicine medicine in _medicine)
            {
                if (medicine.Name.Equals(medicineToDelete.Name))
                {
                    _medicine.Remove(medicineToDelete);
                }
            }
        }

        public void Add(Medicine medicine)
        {
            _medicine.Add(medicine);
        }


        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Medicine.json", JsonConvert.SerializeObject(_medicine));
        }
    }
}