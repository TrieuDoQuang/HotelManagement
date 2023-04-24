using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            UserDetail uD = new UserDetail();
            uD.book_ID = book_ID; uD.room_ID = room_ID; uD.customerID = customerID;
            qlhotelEntity.UserDetails.Add(uD);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool DeleteUserDetail(ref string err, int book_ID,int room_ID,int customerID)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            UserDetail uD = new UserDetail();
            uD.book_ID = book_ID;
            uD.room_ID = room_ID;
            uD.customerID = customerID;
            qlhotelEntity.UserDetails.Attach(uD);
            qlhotelEntity.UserDetails.Remove(uD);
            qlhotelEntity.SaveChanges();
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
