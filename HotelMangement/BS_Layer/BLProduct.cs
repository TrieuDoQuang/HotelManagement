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
    public class BlProduct
    {
        public DataTable TakeProduct()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var tps =
            from p in qlhotelEntity.Products
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Product ID");
            dt.Columns.Add("cate ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Thumbnail");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Price");
            dt.Columns.Add("Amount");


            foreach (var p in tps)
            {
                dt.Rows.Add(p.pID, p.cate_ID,p.Title, p.Thumbnail, p.Decription, p.Price, p.Amount);
            }
            return dt;
        }
        public bool AddProduct(int pID, int cate_ID,string Title, string Thumbnail, string Decription, double Price, int Amount, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_PRODUCT(cate_ID,Title, Thumbnail, Decription, Price, Amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteProduct(ref string err, int pID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_PRODUCT(pID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateProduct(int pID, int cate_ID,string Title, string Thumbnail, string Decription, double Price, int Amount, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_PRODUCT(pID,cate_ID, Title, Thumbnail, Decription, Price, Amount);
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
