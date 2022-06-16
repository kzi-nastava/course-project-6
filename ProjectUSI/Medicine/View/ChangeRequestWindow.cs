using System;
using System.Windows.Forms;
using ProjectUSI.Medicine.Controller;
using ProjectUSI.Medicine.Model;
using ProjectUSI.Medicine.Repository;

namespace ProjectUSI.Medicine.View
{
    public partial class ChangeRequestWindow : Form
    {
        private Request _request;
        private RequestRepository _requestRepository;
        private RequestController _requestController;
        public ChangeRequestWindow(Request request, RequestRepository requestRepository)
        {
            _request = request;
            _requestRepository = requestRepository;
            _requestController = new RequestController(_requestRepository);
            InitializeComponent();
            InitComponents();
        }
        private void InitComponents()
        {
            name.Text = _request.Name;
            string ingr = String.Join(", ", _request.Ingredients.ToArray());
            ingredients.Text = ingr;
            usage.Text = _request.WayOfUse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request newRequest = new Request();
            _requestRepository.DeleteRequest(_request);
            _requestController.AddRequest(name.Text, usage.Text, ingredients.Text, "");
            
            _requestRepository.Save();
            
            MessageBox.Show("Chosen request is changed and sent on verification.","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}