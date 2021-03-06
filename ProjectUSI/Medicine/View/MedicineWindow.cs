using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Medicine.Controller;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Medicine.View
{
    public partial class MedicineWindow : Form
    {
        private MainRepository _mainRepository;
        private MedicineController _controller;
        public MedicineWindow(MedicineController controller, MainRepository mainRepository)
        {
            _controller = controller;
            _mainRepository = mainRepository;
            InitializeComponent();
            InitListBox(_mainRepository.MedicineRepository.GetMedicine());
        }
        private void InitListBox(List<Model.Medicine> medicine)
        {
            for (int i = 0; i < medicine.Count; i++)
            {
                listBox1.Items.Add(medicine.ElementAt(i).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    int index = listBox1.SelectedIndex;
                    Model.Medicine medicine = _mainRepository.MedicineRepository.GetMedicine()[index];
                    CRUDIngredientsView medicineView = new CRUDIngredientsView(medicine, _mainRepository);
                    medicineView.Show();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    MessageBox.Show("Please select medicine first!","Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NullReferenceException exception)
                {
                    MessageBox.Show("Please select medicine first!","Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            private void newMed_Click(object sender, EventArgs e)
            {
                AddNewMedicineWindow newMedicineWindow = new AddNewMedicineWindow(_mainRepository, new RequestController(_mainRepository.RequestRepository));
                newMedicineWindow.Show();
            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                InitListBox(_mainRepository.MedicineRepository.GetMedicine());
            }
    }
}