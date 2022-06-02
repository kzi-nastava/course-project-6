using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
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
        private void InitListBox(List<Medicine> medicine)
        {
            for (int i = 0; i < medicine.Count; i++)
            {
                listBox1.Items.Add(medicine.ElementAt(i).ToString());
            }
        }

        // private Dictionary<string, double> ParseIngredients(string s)
        // {
        //     Dictionary<string, double> ingredients = new Dictionary<string, double>();
        //     string[] pairs = s.Split(';');
        //     foreach (string str in pairs)
        //     {
        //         string[] pair = str.Split(':');
        //         ingredients[pair[0]] = Double.Parse(pair[1]);
        //     }
        //
        //     return ingredients;
        // }


        private void btnRooms_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                Medicine medicine = _mainRepository.MedicineRepository.GetMedicine()[index];
                // ConfirmRenovationWindow confirm = new ConfirmRenovationWindow(roomForRenovation, _mainRepository, new RenovationController(null, null, _mainRepository));
                // confirm.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You need to select room!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    int index = listBox1.SelectedIndex;
                    Medicine medicine = _mainRepository.MedicineRepository.GetMedicine()[index];
                    CRUDMedicineView medicineView = new CRUDMedicineView(medicine, _mainRepository.MedicineRepository);
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
                AddNewMedicineWindow newMedicineWindow = new AddNewMedicineWindow();
                newMedicineWindow.Show();
            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                InitListBox(_mainRepository.MedicineRepository.GetMedicine());
            }
    }
}