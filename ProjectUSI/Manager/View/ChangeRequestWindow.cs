using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class ChangeRequestWindow : Form
    {
        private Request _request;
        private RequestRepository _requestRepository;
        public ChangeRequestWindow(Request request, RequestRepository requestRepository)
        {
            _request = request;
            _requestRepository = requestRepository;
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
            List<Request> requests = _requestRepository.GetRequests();
            Request toBeDeleted = _request;
            Request newRequest = new Request();
            requests.Remove(toBeDeleted);
            
            newRequest.Status = Status.OnHold;
            newRequest.Name = name.Text;
            newRequest.WayOfUse = usage.Text;
            newRequest.Reason = "";
            string fullString = ingredients.Text;
            string[] ingredient = fullString.Split(',');
            foreach (var word in ingredient)
            {
                newRequest.Ingredients.Add(word);
            }
            requests.Add(newRequest);
            
            File.WriteAllText(@"..\..\Data\MedicineRequests.json",
                JsonConvert.SerializeObject(requests));
            
            MessageBox.Show("Chosen request is changed and sent on verification.","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}