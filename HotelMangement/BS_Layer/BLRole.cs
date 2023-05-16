using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace HotelMangement.BS_Layer
{
    class BLRole
    {
        public DataTable TakeRole()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var ro = from p in qlhotelEntity.Roles select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("rID");
            dt.Columns.Add("rName");
            foreach (var p in ro)
            {
                dt.Rows.Add(p.rID, p.rName);
            }
            return dt;
        }
        public bool AddRole(int rID, string rName, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_ADD_ROLE(rName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool DeleteRole(ref string err, int rID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_DELETE_ROLE(rID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateRole(int rID, string rName, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_UPDATE_ROLE(rID, rName);
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
