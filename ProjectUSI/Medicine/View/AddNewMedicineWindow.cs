using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Controller;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class AddNewMedicineWindow : Form
    {
        
        private RequestRepository _requestRepository;
        private RequestController _requestController;
        public AddNewMedicineWindow(MainRepository mainRepository, RequestController requestController)
        {
            _requestRepository = mainRepository.RequestRepository;
            _requestController = requestController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _requestController.AddRequest(name.Text, usage.Text, ingredients.Text, "");
            _requestRepository.Save();
            
            MessageBox.Show("Proposition for new medicine is successfully sent.","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}