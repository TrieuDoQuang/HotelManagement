using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMangement.Interface;

namespace HotelMangement
{
    public partial class FormLogin : Form
    {
        int role = 1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            HotelManagementSystemEntities hotelEntity = new HotelManagementSystemEntities();
            var userEmail = (from user in hotelEntity.Users
                             where user.Email == email.Text
                             select user).SingleOrDefault();

            var userPassword = (from user in hotelEntity.Users
                         where user.password == password.Text
                         select user).SingleOrDefault();
            
            if (userPassword != null || userEmail != null)
            {
                if (userEmail == null)
                {
                    MessageBox.Show("Wrong username!");
                    this.Close();
                }
                else if (userPassword == null)
                {
                    MessageBox.Show("Wrong password!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login successfully!");
                    this.Text = "Login successfully!";
                    this.Hide();
                    if (role == 1)
                    {       
                        new AdminInterface { }.ShowDialog();
                    }
                    else if(role == 2)
                    {
                        new EmployeeInterface { }.ShowDialog();
                    }
                    base.Close();
                }
            }
            else
            {
                MessageBox.Show("User is not existed!");
                this.password.ResetText();
                this.email.ResetText();
            }
        }
    }
}
