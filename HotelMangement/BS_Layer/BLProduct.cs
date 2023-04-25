using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dt.Columns.Add("Thumbnail");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Price");
            dt.Columns.Add("Amount");


            foreach (var p in tps)
            {
                dt.Rows.Add(p.pID, p.cate_ID, p.Thumbnail, p.Decription, p.Price, p.Amount);
            }
            return dt;
        }
        public bool AddProduct(int pID, int cate_ID, string Thumbnail, string Decription, float Price, int Amount, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();

            Product pro = new Product();
            pro.pID = pID;
            pro.cate_ID = cate_ID;
            pro.Thumbnail = Thumbnail;
            pro.Decription = Decription;
            pro.Price = Price;
            pro.Amount = Amount;
            hotelEtity.Products.Add(pro);
            hotelEtity.SaveChanges();
            return true;

        }
        public bool DeleteProduct(ref string err, int pID)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            Product pro = new Product();
            pro.pID = pID;
            hotelEtity.Products.Attach(pro);
            hotelEtity.Products.Remove(pro);
            hotelEtity.SaveChanges();
            return true;
        }
        public bool UpdateProduct(int pID, int cate_ID, string Thumbnail, string Decription, float Price, int Amount, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            var tpQuery = (from pro in hotelEtity.Products
                           where pro.pID == pID
                           select pro).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.cate_ID = cate_ID;
                tpQuery.Thumbnail = Thumbnail;
                tpQuery.Decription = Decription;
                tpQuery.Price = Price;
                tpQuery.Amount = Amount;
                hotelEtity.SaveChanges();
            }
            return true;
        }
    }
}
