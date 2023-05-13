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
    class BLUserDetail
    {
        public DataTable TakeUserDetail()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var ud = from p in qlhotelEntity.UserDetails select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("book_ID");
            dt.Columns.Add("room_ID");
            dt.Columns.Add("customerID");
            foreach (var p in ud)
            {
                dt.Rows.Add(p.book_ID, p.room_ID,p.customerID);
            }
            return dt;
        }
        public bool AddUserDetail(int book_ID, int room_ID,int customerID, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_USER_DETAIL(book_ID, room_ID, customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool DeleteUserDetail(ref string err, int book_ID,int room_ID,int customerID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_USER_DETAIL(book_ID, room_ID, customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateUserDetail(int book_ID, int room_ID,int customerID, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var udQuery = (from uD in qlhotelEntity.UserDetails
                           where uD.book_ID == book_ID
                           select uD).SingleOrDefault();
            if (udQuery != null)
            {
                udQuery.room_ID = room_ID;
                udQuery.customerID = customerID;
                qlhotelEntity.SaveChanges();
            }
            return true;
        }
    }
}
