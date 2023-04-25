using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    public class BLService
    {
        public DataTable TakeService()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var tps =
            from p in qlhotelEntity.Services
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Service ID");
            dt.Columns.Add("Booking ID");
            dt.Columns.Add("Customer ID");
            dt.Columns.Add("Product ID");
            dt.Columns.Add("Price");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date of buy");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.serID, p.book_ID, p.customerID, p.product_ID, p.Price, p.Amount, p.Buy_Date);
            }
            return dt;
        }
        public bool AddService(int serID, int book_ID, int customerID, int product_ID, float Price, int Amount, DateTime Buy_Date, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();

            Service sv = new Service();
            sv.serID = serID;
            sv.book_ID = book_ID;
            sv.customerID = customerID;
            sv.product_ID = product_ID;
            sv.Price = Price;
            sv.Amount = Amount;
            sv.Buy_Date = Buy_Date;
            hotelEtity.Services.Add(sv);
            hotelEtity.SaveChanges();
            return true;

        }
        public bool DeleteService(ref string err, int serID)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            Service sv = new Service();
            sv.serID = serID;
            hotelEtity.Services.Attach(sv);
            hotelEtity.Services.Remove(sv);
            hotelEtity.SaveChanges();
            return true;
        }
        public bool UpdateService(int serID, int book_ID, int customerID, int product_ID, float Price, int Amount, DateTime Buy_Date, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            var tpQuery = (from sv in hotelEtity.Services
                           where sv.serID == serID
                           select sv).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.book_ID = book_ID;
                tpQuery.customerID = customerID;
                tpQuery.product_ID = product_ID;
                tpQuery.Price = Price;
                tpQuery.Amount = Amount;
                tpQuery.Buy_Date = Buy_Date;
                hotelEtity.SaveChanges();
            }
            return true;
        }
    }
}
