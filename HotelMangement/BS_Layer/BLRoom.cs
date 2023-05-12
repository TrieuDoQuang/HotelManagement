using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelMangement.BS_Layer
{
    class BLRoom
    {
        public DataTable TakeRoom()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var roo = from p in qlhotelEntity.Rooms select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Room ID");
            dt.Columns.Add("Room Number");
            dt.Columns.Add("Room Type");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Price");
            foreach (var p in roo)
            {
                dt.Rows.Add(p.roomID, p.room_No, p.Type, p.Capacity, p.Price);
            }
            return dt;
        }
        public DataTable FindRoom(string room_no)
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
                if(p.room_No==room_no) dt.Rows.Add(p.roomID, p.room_No, p.Type, p.Capacity, p.Price);
            }
            return dt;
        }
        public bool AddRoom(int roomID, string room_No, string Type, int Capacity, double Price, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.ADD_ROOM(room_No, Type, Capacity, Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool DeleteRoom(ref string err, int roomID)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.DELETE_ROOM(roomID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateRoom(int roomID, string room_No, string Type, int Capacity, double Price, ref string err)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.UPDATE_ROOM(roomID, room_No, Type, Capacity, Price);
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
