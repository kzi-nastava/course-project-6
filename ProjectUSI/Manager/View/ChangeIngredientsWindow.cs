using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class ChangeIngredientsWindow : Form
    {
        private Medicine _medicine;
        private MedicineRepository _medicineRepository;
        private string _item;
        public ChangeIngredientsWindow(String item, Medicine medicine, MedicineRepository medicineRepository)
        {
            _medicine = medicine;
            _medicineRepository = medicineRepository;
            _item = item;
            InitializeComponent();
            textBox2.Text = _item;
            _medicine.Ingredients.Remove(_item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string changedIngredient = textBox2.Text;
                _medicine.Ingredients.Add(changedIngredient);
            
                List<Medicine> medicines = _medicineRepository.GetMedicine();
                File.WriteAllText(@"..\..\Data\Medicaments.json",
                    JsonConvert.SerializeObject(medicines));
            
                MessageBox.Show("Chosen ingredient is successfully changed!","Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please enter the new ingredient.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please enter the new ingredient.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}