using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    class BLBookingDetail
    {
        public DataTable TakeBookingDetail()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var boDe = from p in qlhotelEntity.BookingDetails select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("book_ID");
            dt.Columns.Add("room_ID");
            dt.Columns.Add("Price");
            dt.Columns.Add("Unit");
            foreach (var p in boDe)
            {
                dt.Rows.Add(p.book_ID, p.room_ID, p.Price, p.Unit);
            }
            return dt;
        }
        public bool AddBookingDetail(int book_ID, int room_ID, double Price, int Unit, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            BookingDetail boDe = new BookingDetail();
            boDe.book_ID = book_ID;
            boDe.room_ID = room_ID;
            boDe.Price = Price;
            boDe.Unit = Unit;
            qlhotelEntity.BookingDetails.Add(boDe);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool DeleteBookingDetail(ref string err, int book_ID,int room_ID)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            BookingDetail boDe = new BookingDetail();
            boDe.book_ID = book_ID;
            boDe.room_ID = room_ID;
            qlhotelEntity.BookingDetails.Attach(boDe);
            qlhotelEntity.BookingDetails.Remove(boDe);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool UpdateBookingDetail(int book_ID, int room_ID, double Price, int Unit, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var rooQuery = (from boDe in qlhotelEntity.BookingDetails
                            where boDe.book_ID == book_ID
                            && boDe.room_ID == room_ID
                            select boDe).SingleOrDefault();
            if (rooQuery != null)
            {
                rooQuery.Price = Price;
                rooQuery.Unit = Unit;
                qlhotelEntity.SaveChanges();
            }
            return true;
        }
    }
}
