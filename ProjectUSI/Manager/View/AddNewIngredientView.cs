using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class AddNewIngredientView : Form
    {
        private Medicine _medicine;
        private MedicineRepository _medicineRepository;
        public AddNewIngredientView(Medicine medicine, MedicineRepository medicineRepository)
        {
            _medicine = medicine;
            _medicineRepository = medicineRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newIngredient = textBox2.Text;
                _medicine.Ingredients.Add(newIngredient);
                _medicineRepository.Save();
            
            MessageBox.Show("New ingredient is successfully added!","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please enter the ingredient you want to add.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please enter the ingredient you want to add.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}