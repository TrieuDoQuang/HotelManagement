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
using System.Data.SqlClient;

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

        private bool checkLogin(string userEmail, string userPassword)
        {
            bool result = false;
            HotelManagementSystemEntities hotelEntity = new HotelManagementSystemEntities();
            string connectionString = "Data Source=DESKTOP-EP66OTM\\MSSQLSERVER01;Initial Catalog=HotelManagementSystem;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                string sql = "SELECT Email, password FROM Users";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString().Trim() == userEmail && reader.GetValue(1).ToString().Trim() == userPassword)
                            {
                                result = true;
                                string userName = userEmail.Split('@')[0];
                                connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                                connectionString = string.Format(connectionString, userName, userPassword);
                                hotelEntity.Database.Connection.ConnectionString = connectionString;
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            // HotelManagementSystemEntities hotelEntity = new eHotelManagementSystemEntities();
            string userEmail = email.Text;
            string userPassword = password.Text;
            try
            {
                if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userPassword))
                {
                    if (checkLogin(userEmail, userPassword))
                    {
                        MessageBox.Show("Login successfully, Connected as Admin!");
                        new AdminInterface().ShowDialog();
                        this.Hide();
                        base.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter email and password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

    }
}
