using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Medicine.Model;
using ProjectUSI.Medicine.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents all medicine requests where doctor can accept medicine or chose to reject it.
    /// </summary>
    public partial class VerifyMedicines : Form
    {
        private RequestRepository _requestRepository = new RequestRepository();
        private MedicineRepository _medicineRepository = new MedicineRepository();
        public VerifyMedicines()
        {
            InitializeComponent();
            
            List<Request> reqs = _requestRepository.GetRequests();
            foreach (Request req in reqs)
            {
                if (req.Status != Status.Rejected)
                {
                    
                    listBox1.Items.Add(req);
                }
            }
        }

        public void InitListBox()
        {
            for (int i = 0; i < _requestRepository.GetRequests().Count; i++)
            {
                listBox1.Items.Add(_requestRepository.GetRequests().ElementAt(i).ToString());
            }
        }

        private void viewMed_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                Request req = _requestRepository.GetRequests()[index];
                VerifyMedicineWindow verifyMedicinesWindow = new VerifyMedicineWindow(req, _requestRepository);
                verifyMedicinesWindow.Show();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which request you want to reject.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which request you want to reject.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Medicine.Model.Medicine medicine = new Medicine.Model.Medicine();
            Request item;
            List<Request> requests = _requestRepository.GetRequests();
            List<Medicine.Model.Medicine> medicines = _medicineRepository.GetMedicine();
            
            int index = listBox1.SelectedIndex;
            item = _requestRepository.GetRequests().ElementAt(index);
            
            try
            {
                medicine.Name = item.Name;
                medicine.Ingredients = item.Ingredients;
                medicine.WayOfUse = item.WayOfUse;

                medicines.Add(medicine);
                requests.Remove(item);

                File.WriteAllText(@"..\..\Data\Medicaments.json",
                    JsonConvert.SerializeObject(medicines));

                File.WriteAllText(@"..\..\Data\MedicineRequests.json",
                    JsonConvert.SerializeObject(requests));

                MessageBox.Show("Selected medicine is successfully accepted.", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                listBox1.Items.Clear();
                InitListBox();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which medicine you want to accept.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which medicine you want to accept.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}