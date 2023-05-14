using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();

            Booking bk = new Booking();
            bk.bookID = bookID;
            bk.staff_ID = staffID;
            bk.customer_ID = cusID;
            bk.Check_In = checkIn;
            bk.Check_Out = checkOut;
            hotelEtity.Bookings.Add(bk);
            hotelEtity.SaveChanges();
            return true;

        }
        public bool DeleteBooking(ref string err, int bookID)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            Booking bk = new Booking();
            bk.bookID = bookID;
            hotelEtity.Bookings.Attach(bk);
            hotelEtity.Bookings.Remove(bk);
            hotelEtity.SaveChanges();
            return true;
        }
        public bool UpdateBooking(int bookID, int staffID, int cusID, DateTime checkIn, DateTime checkOut, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            var tpQuery = (from bk in hotelEtity.Bookings
                           where bk.bookID == bookID
                           select bk).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.staff_ID = staffID;
                tpQuery.customer_ID = cusID;
                tpQuery.Check_In = checkIn;
                tpQuery.Check_Out = checkOut;
                hotelEtity.SaveChanges();
            }
            return true;
        }
    }
}
