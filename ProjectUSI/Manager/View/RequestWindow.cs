using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;

namespace ProjectUSI.Manager.View
{
    public partial class RequestWindow : Form
    {
        private RequestRepository _requestRepository = new RequestRepository();
        public RequestWindow()
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            InitListBox();
        }
    }
}