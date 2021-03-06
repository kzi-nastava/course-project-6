using System;
using System.Windows.Forms;
using ProjectUSI.Medicine.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Medicine.View
{
    public partial class ChangeIngredientsWindow : Form
    {
        private Model.Medicine _medicine;
        private MedicineRepository _medicineRepository;
        public ChangeIngredientsWindow(String itemName, Model.Medicine medicine, MainRepository mainRepository)
        {
            _medicine = medicine;
            _medicineRepository = mainRepository.MedicineRepository;
            InitializeComponent();
            textBox2.Text = itemName;
            _medicine.Ingredients.Remove(itemName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string changedIngredient = textBox2.Text;
                _medicine.Ingredients.Add(changedIngredient);
                _medicineRepository.Save();
            
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