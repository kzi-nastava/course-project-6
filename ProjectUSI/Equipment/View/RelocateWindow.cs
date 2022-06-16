using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class RelocateWindow : Form
    {
        private MainRepository _mainRepository;
        private RelocationController _controller;
        
        public RelocateWindow(String from, MainRepository mainRepository, RelocationController relocationController)
        {
            _mainRepository = mainRepository;
            _controller = relocationController;
            InitializeComponent();
            InitComboBox();
            lblFrom.Text = from;
        }

        private void InitComboBox()
        {
            List<String> rooms = _controller.Rooms();
            cbRelocateTo.DataSource = rooms;
        }

        private void btnRelocate_Click(object sender, EventArgs e)
        {
            _controller.Relocate(lblFrom.Text, (string) cbRelocateTo.SelectedItem, dateOfRelocation.Value.ToString("dd.MM.yyyy. HH:mm:ss"));
            this.Dispose(false);
            
        }
        
        
        
    }
}