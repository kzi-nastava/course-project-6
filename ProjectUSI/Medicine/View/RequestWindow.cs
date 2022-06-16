using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectUSI.Medicine.Model;
using ProjectUSI.Medicine.Repository;
using ProjectUSI.Users.Repository;

namespace ProjectUSI.Medicine.View
{
    public partial class RequestWindow : Form
    {
        private RequestRepository _requestRepository;
        public RequestWindow(MainRepository mainRepository)
        {
            _requestRepository = mainRepository.RequestRepository;
            InitializeComponent();
            InitListBox();
        }

        private void InitListBox()
        {
            List<Request> reqs = _requestRepository.GetRequests();
            foreach (Request req in reqs)
            {
                if (req.Status == Status.Rejected)
                {
                    listBox1.Items.Add(req);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                Request req = _requestRepository.GetRequests()[index];
                _requestRepository.DeleteRequest(req);
                listBox1.Items.Clear();
                InitListBox();
                _requestRepository.Save();
                ChangeRequestWindow changeRequestWindow = new ChangeRequestWindow(req, _requestRepository);
                changeRequestWindow.Show();
                
                
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which request you want to change.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which request you want to change.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            InitListBox();
        }
    }
}