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
            var usersrole = (from user in hotelEntity.Users
                             where user.Email == email.Text && user.password == password.Text
                             select user.role_id).SingleOrDefault();
            try
            {
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
                        string connectionString = "Data Source=QuangTrieu;Initial Catalog=HotelManagementSystem;User ID={0};Password={1};";
                        if (Convert.ToInt32(usersrole) == 1)
                        {
                            hotelEntity.Database.Connection.ConnectionString = string.Format(connectionString, "testuser", "123");
                            new AdminInterface().ShowDialog();
                        }
                        else if (Convert.ToInt32(usersrole) == 2)
                        {
                            hotelEntity.Database.Connection.ConnectionString = string.Format(connectionString, "testuser2", "123");
                            new EmployeeInterface().ShowDialog();
                        }
                        else
                        {
                            hotelEntity.Database.Connection.ConnectionString = string.Format(connectionString, "testuser3", "123");
                            new CustomerInterface().ShowDialog();
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
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }
    }
}
