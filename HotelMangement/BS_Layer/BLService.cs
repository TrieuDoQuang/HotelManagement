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
        public bool AddService(int serID, int book_ID, int customerID, int product_ID, double Price, int Amount, DateTime Buy_Date, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_SERVICE(book_ID, customerID, product_ID, Price, Amount, Buy_Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteService(ref string err, int serID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_SERVICE(serID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateService(int serID, int book_ID, int customerID, int product_ID, double Price, int Amount, DateTime Buy_Date, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_SERVICE(serID, book_ID, customerID, product_ID, Price, Amount, Buy_Date);
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
