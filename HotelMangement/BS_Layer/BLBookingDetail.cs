using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_BOOKING_DETAIL(book_ID, room_ID, Price, Unit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool DeleteBookingDetail(ref string err, int book_ID,int room_ID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_BOOKING_DETAIL(book_ID, room_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateBookingDetail(int book_ID, int room_ID, double Price, int Unit, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_BOOKING_DETAIL(book_ID, room_ID, Price, Unit);
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
