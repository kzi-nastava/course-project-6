using System;
using System.Windows.Forms;
using ProjectUSI.Doctor.Repository;
using ProjectUSI.Doctor.View;
using ProjectUSI.Manager.View;
using ProjectUSI.Users.Controller;
using ProjectUSI.Users.Model;
using Patient;

namespace ProjectUSI.Users.View
{
    public partial class LoginWindow : Form
    {
        private UserController _controller;
        
        public LoginWindow()
        {
            _controller = new UserController(new UsersRepository());
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            string password = txtBoxPassword.Text;
            bool check;
            try
            {
                check = _controller.CheckUser(email, password);
                if (check == true)
                {
                    User user = _controller.GetUserByEmail(email);
                    switch (user.Role)
                    {
                        case Role.Manager:
                            ManagerMainWindow managerMainWindow = new ManagerMainWindow(user);
                            managerMainWindow.Show();
                            this.Dispose(false);
                            break;
                        case Role.Doctor:
                            AppointmentsRepository appointmentsRepository = new AppointmentsRepository();
                            MedicalRecordRepository medicalRecordRepository = new MedicalRecordRepository();
                            DoctorMainWindow doctorMainWindow = new DoctorMainWindow(appointmentsRepository, medicalRecordRepository);
                            doctorMainWindow.Show();
                            break;
                        case Role.Patient:
                            MainWindow mainWindow = new MainWindow(email, password);
                            mainWindow.Show();
                            break;
                        case Role.Secretary:
                            //TODO: otvoriti glavni prozor sekretara
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("User does not exist!");
            }

            
            
            
        }
    }
}