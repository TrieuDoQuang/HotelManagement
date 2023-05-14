using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelMangement.BS_Layer
{
    public class BLBooking
    {
        public DataTable TakeBooking()
        {
            HotelManagementSystemEntities hotelEntity = new HotelManagementSystemEntities();
            var tps =
            from p in hotelEntity.Bookings
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Book ID");
            dt.Columns.Add("Staff ID");
            dt.Columns.Add("customer ID");
            dt.Columns.Add("Check In");
            dt.Columns.Add("Check Out");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.bookID, p.staff_ID, p.customer_ID, p.Check_In, p.Check_Out);
            }
            return dt;
        }
        public bool AddBooking(int bookID, int staffID, int cusID, DateTime checkIn, DateTime checkOut, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_BOOKING(staffID, cusID, checkIn, checkOut);
                qlhotelEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteBooking(ref string err, int bookID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_BOOKING(bookID);
                qlhotelEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateBooking(int bookID, int staffID, int cusID, DateTime checkIn, DateTime checkOut, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_BOOKING(bookID, staffID, cusID, checkIn, checkOut);
                qlhotelEntity.SaveChanges();
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
