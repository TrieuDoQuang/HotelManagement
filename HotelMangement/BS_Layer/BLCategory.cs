using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_CATEGORY(cateName);
                qlhotelEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteCate(ref string err, int cateID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_CATEGORY(cateID);
                qlhotelEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateCate(int cateID, string cateName, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_CATEGORY(cateID, cateName);
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
