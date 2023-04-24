using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    class BLRole
    {
        public DataTable TakeRole()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var ro = from p in qlhotelEntity.Roles select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("rID");
            dt.Columns.Add("rName");
            foreach (var p in ro)
            {
                dt.Rows.Add(p.rID, p.rName);
            }
            return dt;
        }
        public bool AddRole(int rID, string rName, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            Role Ro = new Role();
            Ro.rID = rID; Ro.rName = rName;
            qlhotelEntity.Roles.Add(Ro);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool DeleteRole(ref string err, int rID)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            Role Ro = new Role();
            Ro.rID = rID;
            qlhotelEntity.Roles.Attach(Ro);
            qlhotelEntity.Roles.Remove(Ro);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool UpdateRole(int rID, string rName, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var roQuery = (from Ro in qlhotelEntity.Roles
                           where Ro.rID == rID
                           select Ro).SingleOrDefault();
            if (roQuery != null)
            {
                roQuery.rName = rName;
                qlhotelEntity.SaveChanges();
            }
            return true;
        }
    }
}
