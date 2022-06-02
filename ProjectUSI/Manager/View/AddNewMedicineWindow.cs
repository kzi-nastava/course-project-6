using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class AddNewMedicineWindow : Form
    {
        private Request request = new Request();
        private RequestRepository _requestRepository = new RequestRepository();
        public AddNewMedicineWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request.Name = name.Text;
            request.WayOfUse = usage.Text;

            string fullString = ingredients.Text;
            string[] ingredient = fullString.Split(',');
            foreach (var word in ingredient)
            {
                request.Ingredients.Add(word);
            }

            request.Status = Status.OnHold;
            request.Reason = "";
            
            List<Request> requests = _requestRepository.GetRequests();
            requests.Add(request);

            File.WriteAllText(@"..\..\Data\MedicineRequests.json",
                JsonConvert.SerializeObject(requests));
            
            MessageBox.Show("Proposition for new medicine is successfully sent.","Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}