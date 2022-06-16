using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Doctor.Repository;

namespace ProjectUSI.Doctor.View
{
    public partial class NewFreeDayWindow : Form
    {
        private FreeDaysRepository _freeDaysRepository = new FreeDaysRepository();
        public NewFreeDayWindow()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            List<FreeDays> freeDays = _freeDaysRepository.GetFreeDays();
            FreeDays newFreeDay = new FreeDays();
            
            string iDate = startDate.Text;
            DateTime oDate = Convert.ToDateTime(iDate);
            DateTime now = DateTime.Now;
            DateTime date = now.Date;
            if ((oDate.Day - date.Day) >= 2)
            {
                newFreeDay.Doctor = nameAndLastName.Text;
                newFreeDay.Reason = reason.Text;
                newFreeDay.StartDate = startDate.Text;
                newFreeDay.EndDate = endDate.Text;
                newFreeDay.Status = Status.OnHold;
                if (_freeDaysRepository.IsAvailable(newFreeDay))
                {
                    freeDays.Add(newFreeDay);
            
                    _freeDaysRepository.Save();
            
                    MessageBox.Show("New request is successfully sent.", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You have appointments in this period!", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You can't ask for free days less than 2 days before!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}