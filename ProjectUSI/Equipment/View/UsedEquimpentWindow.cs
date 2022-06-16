using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Equipment.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window is where doctor enter how many equipment he used.
    /// </summary>
    public partial class UsedEquimpentWindow : Form
    {
        private Appointments _appointment;
        private Equipment.Model.Equipment _equipment;
        private EquipmentRepository _equipmentRepository = new EquipmentRepository();
        List<Equipment.Model.Equipment> roomEquipments = new List<Equipment.Model.Equipment>();
        public UsedEquimpentWindow(Appointments appointment)
        {
            _appointment = appointment;
            InitializeComponent();
            InitEquipment();
            InitListBox();
        }

        private void InitEquipment()
        {
            List<Equipment.Model.Equipment> equipments = _equipmentRepository.GetEquipment();
            
            foreach (Equipment.Model.Equipment eq in equipments)
            {
                if (_appointment.RoomId == eq.DeployedIn.Id)
                {
                    roomEquipments.Add(eq);
                }
            }
        }
        public void InitListBox()
        {
            for (int i = 0; i < roomEquipments.Count; i++)
            {
                listBox1.Items.Add(roomEquipments.ElementAt(i));
            }
        }
        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                Equipment.Model.Equipment usedEquipment;
                
                int index = listBox1.SelectedIndex;
                usedEquipment = roomEquipments.ElementAt(index);
                List<Equipment.Model.Equipment> equipments = _equipmentRepository.GetEquipment();
                
                equipments.Remove(usedEquipment);
                --usedEquipment.Quantity;
                equipments.Add(usedEquipment);
                
                listBox1.Items.Clear();
                InitListBox();
                
                File.WriteAllText(@"..\..\Data\Equipment.json",
                    JsonConvert.SerializeObject(equipments));
                
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which equipment you want to decrease.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which equipment you want to decrease.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}