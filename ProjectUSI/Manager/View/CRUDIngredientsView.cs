using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{

    public partial class CRUDMedicineView : Form
    {
        private MedicineRepository _medicineRepository;
        private Medicine _medicine;

        public CRUDMedicineView(Medicine medicine, MedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
            _medicine = medicine;
            InitializeComponent();
            for (int i = 0; i < _medicine.Ingredients.Count; i++)
            {
                listBox1.Items.Add(_medicine.Ingredients.ElementAt(i).ToString());
            }
        }

        public void InitListBox()
        {
            for (int i = 0; i < _medicine.Ingredients.Count; i++)
            {
                listBox1.Items.Add(_medicine.Ingredients.ElementAt(i).ToString());
            }
            
        }

        private void delIng_Click(object sender, EventArgs e)
        {
            string item = (string)listBox1.SelectedItem;
            if (item != null)
            {
                _medicine.Ingredients.Remove(item);
                
                listBox1.Items.Clear();
                InitListBox();

                List <Medicine> medicines = _medicineRepository.GetMedicine();

                File.WriteAllText(@"..\..\Data\Medicaments.json",
                    JsonConvert.SerializeObject(medicines));
            
                MessageBox.Show("Selected ingredient is successfully deleted.","Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select which ingredient you want to delete.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void UpdateIng_Click(object sender, EventArgs e)
        {
            string item = (string)listBox1.SelectedItem;
            if (item != null)
            {
                ChangeIngredientsWindow changeIngredientsWindow =
                    new ChangeIngredientsWindow(item, _medicine, _medicineRepository);
                changeIngredientsWindow.Show();
                listBox1.Items.Clear();
                InitListBox();
            }
            else
            {
                MessageBox.Show("Please select which ingredient you want to change.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddIng_Click(object sender, EventArgs e)
        {
            AddNewIngredientView newIngredientView = new AddNewIngredientView(_medicine, _medicineRepository);
            newIngredientView.Show();
            listBox1.Items.Clear();
            InitListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            InitListBox();
        }
    }
}