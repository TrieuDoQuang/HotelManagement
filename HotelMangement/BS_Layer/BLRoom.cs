using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    class BLRoom
    {
        public DataTable TakeRoom()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var roo = from p in qlhotelEntity.Rooms select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("roomID");
            dt.Columns.Add("room_No");
            dt.Columns.Add("Type");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Price");
            foreach (var p in roo)
            {
                dt.Rows.Add(p.roomID, p.room_No, p.Type, p.Capacity, p.Price);
            }
            return dt;
        }
        public bool AddRoom(int roomID, string room_No, string Type, int Capacity, double Price, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            Room roo = new Room();
            roo.roomID = roomID;
            roo.room_No = room_No;
            roo.Type = Type;
            roo.Capacity = Capacity;
            roo.Price = Price;
            qlhotelEntity.Rooms.Add(roo);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool DeleteRoom(ref string err, int roomID)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            Room roo = new Room();
            roo.roomID = roomID;
            qlhotelEntity.Rooms.Attach(roo);
            qlhotelEntity.Rooms.Remove(roo);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool UpdateRoom(int roomID, string room_No, string Type, int Capacity, double Price, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var rooQuery = (from roo in qlhotelEntity.Rooms
                           where roo.roomID == roomID
                           select roo).SingleOrDefault();
            if (rooQuery != null)
            {
                rooQuery.room_No = room_No;
                rooQuery.Type = Type;
                rooQuery.Capacity = Capacity;
                rooQuery.Price = Price;
                qlhotelEntity.SaveChanges();
            }
            return true;
        }
    }
}
