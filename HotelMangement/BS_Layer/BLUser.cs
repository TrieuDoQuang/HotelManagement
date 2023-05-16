using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelMangement.BS_Layer
{
    class BLUser
    {
        public DataTable TakeUser()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Users select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("User ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Password");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("Role");
       
            foreach (var p in us)
            {
                dt.Rows.Add(p.userID, p.Fullname, p.password, p.Birthday, p.Gender, p.Email, p.Phone_Number, p.Address,p.role_id);
            }
            return dt;
        }
        public DataTable FindUser(int ID,string Name)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Users select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("userID");
            dt.Columns.Add("Fullname");
            dt.Columns.Add("password");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone_Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("role_id");
            foreach (var p in us)
            {
                if(p.userID==ID && p.Fullname == Name)
                {
                    dt.Rows.Add(p.userID, p.Fullname, p.password, p.Birthday, p.Gender, p.Email, p.Phone_Number, p.Address, p.role_id);
                }
            }
            return dt;
        }
        public bool AddUser(int userID, string Fullname, string password, DateTime Birthday, bool Gender, string Email, string Phone_Number, string Address,int role_id, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_ADD_USER(Fullname, Birthday, Gender, Email, Phone_Number, Address, role_id, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool DeleteUser(ref string err, int userID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_DELETE_USER(userID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateUser(int userID, string Fullname, string password, DateTime Birthday, bool Gender, string Email, string Phone_Number, string Address, int role_id, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_UPDATE_USER(userID,Fullname,Birthday,Gender,Email,Phone_Number,Address,role_id, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
    }
}
