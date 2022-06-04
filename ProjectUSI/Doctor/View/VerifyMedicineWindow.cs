using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Doctor.View
{
    /// <summary>
    /// This window represents place where doctor rejects medicine and enter the reason why.
    /// </summary>
    public partial class VerifyMedicineWindow : Form
    {
        private Request _request;
        private RequestRepository _requestRepository;
        public VerifyMedicineWindow(Request request, RequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
            _request = request;
            InitializeComponent();
            InitComponents();
        }
        private void InitComponents()
        {
            name.Text = _request.Name;
            string ingr = String.Join(", ", _request.Ingredients.ToArray());
            ingredients.Text = ingr;
            wayOfUse.Text = _request.WayOfUse;
        }
        private void reject_Click(object sender, EventArgs e)
        {
            List<Request> requests = _requestRepository.GetRequests();
            requests.Remove(_request);
            File.WriteAllText(@"..\..\Data\MedicineRequests.json",
                JsonConvert.SerializeObject(requests));
            
            _request.Status = Status.Rejected;
            _request.Reason = reason.Text;

            requests.Add(_request);
            
            File.WriteAllText(@"..\..\Data\MedicineRequests.json",
                JsonConvert.SerializeObject(requests));

            MessageBox.Show("Chosen medicine is rejected.","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}