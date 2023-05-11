using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HotelMangement.Interface;

namespace HotelMangement
{
    public partial class FormLogin : Form
    {
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

            var usersRole = (from user in hotelEntity.Users
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
                        
                        if (Convert.ToInt32(usersRole) == 1)
                        {
                            hotelEntity.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["HotelManagementSystemEntities_Admin"].ConnectionString;
                            hotelEntity.Database.Connection.Open();
                            if (hotelEntity.Database.Connection.State == System.Data.ConnectionState.Open)
                            {
                                MessageBox.Show("Login succesfully, Connected as Admin!");
                                new AdminInterface().ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Connection failed");
                            }
                        }
                        else if (Convert.ToInt32(usersRole) == 2)
                        {
                            hotelEntity.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["HotelManagementSystemEntities_Employee"].ConnectionString;
                            hotelEntity.Database.Connection.Open();
                            if (hotelEntity.Database.Connection.State == System.Data.ConnectionState.Open)
                            {
                                MessageBox.Show("Login succesfully, Connected as Employee!");
                                new EmployeeInterface().ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Connection failed");
                            }
                        }
                        else
                        {
                            hotelEntity.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["HotelManagementSystemEntities_Customer"].ConnectionString; ;
                            hotelEntity.Database.Connection.Open();
                            if (hotelEntity.Database.Connection.State == System.Data.ConnectionState.Open)
                            {
                                MessageBox.Show("Login succesfully, Connected as Customer!");
                                new CustomerInterface().ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Connection failed");
                            }
                        }
                        this.Hide();
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
