using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    public class BLCategory
    {
        public DataTable TakeCate()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var tps =
            from p in qlhotelEntity.Categories
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Cate ID");
            dt.Columns.Add("Cate name");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.cateID, p.cateName);
            }
            return dt;
        }
        public bool AddCate(int cateID, string cateName, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();

            Category ct = new Category();   
            ct.cateID = cateID;
            ct.cateName = cateName;
            hotelEtity.Categories.Add(ct);
            hotelEtity.SaveChanges();
            return true;

        }
        public bool DeleteCate(ref string err, int cateID)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            Category ct = new Category();
            ct.cateID = cateID;
            hotelEtity.Categories.Attach(ct);
            hotelEtity.Categories.Remove(ct);
            hotelEtity.SaveChanges();
            return true;
        }
        public bool UpdateCate(int cateID, string cateName, ref string err)
        {
            HotelManagementSystemEntities hotelEtity = new HotelManagementSystemEntities();
            var tpQuery = (from ct in hotelEtity.Categories
                           where ct.cateID == cateID
                           select ct).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.cateName = cateName;
                hotelEtity.SaveChanges();
            }
            return true;
        }
    }
}
