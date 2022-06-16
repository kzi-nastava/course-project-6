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

    public partial class CRUDIngredientsView : Form
    {
        private MedicineRepository _medicineRepository;
        private MainRepository _mainRepository;
        private Medicine _medicine;

        public CRUDIngredientsView(Medicine medicine, MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
            _medicineRepository = mainRepository.MedicineRepository;
            _medicine = medicine;
            InitializeComponent();
            InitListBox();
        }

        public void InitListBox()
        {
            for (int i = 0; i < _medicine.Ingredients.Count; i++)
            {
                listBox1.Items.Add(_medicine.Ingredients.ElementAt(i).ToString());
            }
            
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            string item = (string)listBox1.SelectedItem;
            if (item != null)
            {
                _medicine.Ingredients.Remove(item);
                _medicineRepository.Save();
                listBox1.Items.Clear();
                InitListBox();
            
                MessageBox.Show("Selected ingredient is successfully deleted.","Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select which ingredient you want to delete.","Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            string item = (string)listBox1.SelectedItem;
            if (item != null)
            {
                ChangeIngredientsWindow changeIngredientsWindow = new ChangeIngredientsWindow(item, _medicine, _mainRepository);
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

        private void AddClick(object sender, EventArgs e)
        {
            AddNewIngredientView newIngredientView = new AddNewIngredientView(_medicine, _medicineRepository);
            newIngredientView.Show();
            listBox1.Items.Clear();
            InitListBox();
        }

        private void RefreshClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            InitListBox();
        }
    }
}