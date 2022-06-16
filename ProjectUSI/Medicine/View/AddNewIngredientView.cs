using System;
using System.Windows.Forms;
using ProjectUSI.Medicine.Repository;

namespace ProjectUSI.Medicine.View
{
    public partial class AddNewIngredientView : Form
    {
        private Model.Medicine _medicine;
        private MedicineRepository _medicineRepository;
        public AddNewIngredientView(Model.Medicine medicine, MedicineRepository medicineRepository)
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