using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Equipment.Controller;
using ProjectUSI.Equipment.Model;
using ProjectUSI.Equipment.Repository;
using ProjectUSI.Rooms.Model;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Equipment.View
{
    public partial class EquipmentWindow : Form
    {
        private MainRepository _mainRepository;
        private EquipmentRepository _equipmentRepository;
        public EquipmentController _controller;
        public EquipmentWindow(MainRepository mainRepository, EquipmentController equipmentController)
        {
           _equipmentRepository = mainRepository.EquipmentRepository;
            _controller = equipmentController;
            _mainRepository = mainRepository;
            
            InitializeComponent();
            InitComboBoxes();
            InitListBox(_mainRepository.EquipmentRepository.GetEquipment());
        }

        private void InitComboBoxes()
        {
            cbRoomType.DataSource = Enum.GetValues(typeof(RoomPurpose));
            cbQuantity.DataSource = Enum.GetValues(typeof(Quantity));
            cbEquipmentType.DataSource = Enum.GetValues(typeof(EquipmentType));
            cbRoomType.SelectedItem = cbRoomType.Items[0];
            cbQuantity.SelectedItem = cbQuantity.Items[0];
            cbEquipmentType.SelectedItem = cbEquipmentType.Items[0];
        }

        private void InitListBox(List<Model.Equipment> equipment)
        {
            for (int i = 0; i < equipment.Count; i++)
            {
                listBox1.Items.Add(_mainRepository.EquipmentRepository.GetEquipment().ElementAt(i).ToString());
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var equipmentList =_equipmentRepository.GetEquipment(); //return original data from Store

            listBox1.BeginUpdate();
            listBox1.Items.Clear();

            if(!string.IsNullOrEmpty(textBox1.Text)) 
            {
                foreach (Model.Equipment equipment in equipmentList)
                {                
                    if (equipment.ToString().Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(equipment.ToString());
                    }
                }
            }
            else 
                InitListBox(_mainRepository.EquipmentRepository.GetEquipment());
            listBox1.EndUpdate();             
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RoomPurpose roomPurpose = (RoomPurpose) cbRoomType.SelectedItem;
            Quantity quantity = (Quantity) cbQuantity.SelectedItem;
            EquipmentType equipmentType = (EquipmentType) cbEquipmentType.SelectedItem;
            List<Model.Equipment> filtered = _controller.Filter(roomPurpose, equipmentType, quantity);
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            InitListBox(filtered);
            listBox1.EndUpdate(); 
        }

        private void btnRelocate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Model.Equipment equipment =_equipmentRepository.GetEquipment()[index];
            RelocateWindow relocateWindow = new RelocateWindow(equipment.DeployedIn.Name, _mainRepository,
                new RelocationController(new Relocation(), null, _mainRepository));
            relocateWindow.Show();
            
        }
        
    }
    
    
}