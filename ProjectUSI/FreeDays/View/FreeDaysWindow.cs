using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;
using Status = ProjectUSI.Medicine.Model.Status;

namespace ProjectUSI.Doctor.View
{
    public partial class FreeDaysWindow : Form
    {
        private FreeDaysRepository _freeDaysRepository = new FreeDaysRepository();
        public FreeDaysWindow()
        {
            InitializeComponent();
            InitListBox();
        }
        
        private void InitListBox()
        {
            List<FreeDays> freeDays = _freeDaysRepository.GetFreeDays();
            foreach (FreeDays freeDay in freeDays)
            {
                listBox1.Items.Add(freeDay);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            InitListBox();
        }

        private void instantReq_Click(object sender, EventArgs e)
        {
            List<FreeDays> freeDays = _freeDaysRepository.GetFreeDays();
            try
            {
                int index = listBox1.SelectedIndex;
                
                FreeDays selectedEl = freeDays.ElementAt(index);
                freeDays.Remove(selectedEl);

                string iDate = selectedEl.StartDate;
                DateTime oDate = Convert.ToDateTime(iDate);
                string jDate = selectedEl.EndDate;
                DateTime pDate = Convert.ToDateTime(jDate);

                if ((pDate.Day - oDate.Day) <= 5)
                {
                    selectedEl.Status = Model.Status.Accepted;
                    freeDays.Add(selectedEl);
                
                    listBox1.Items.Clear();
                    InitListBox();
                
                    File.WriteAllText(@"..\..\Doctor\Data\FreeDays.json", 
                        JsonConvert.SerializeObject(freeDays));
                }
                else
                {
                    MessageBox.Show("This request can't be instant because it's for more than 5 days!", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show("Please select which request you want to be instant.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Please select which request you want to be instant.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void createReq_Click(object sender, EventArgs e)
        {
            NewFreeDayWindow newFreeDayWindow = new NewFreeDayWindow();
            newFreeDayWindow.Show();
            listBox1.Items.Clear();
            InitListBox();
        }
    }
}