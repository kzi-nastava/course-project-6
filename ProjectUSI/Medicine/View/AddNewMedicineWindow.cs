using System;
using System.Windows.Forms;
using ProjectUSI.Medicine.Controller;
using ProjectUSI.Medicine.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Medicine.View
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