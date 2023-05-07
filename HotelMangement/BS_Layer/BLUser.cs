using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMangement.BS_Layer
{
    class BLUser
    {
        public DataTable TakeUser()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Users select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Người Dùng");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Mật khẩu");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Email");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Quyền");
       
            foreach (var p in us)
            {
                dt.Rows.Add(p.userID, p.Fullname, p.password, p.Birthday, p.Gender, p.Email, p.Phone_Number, p.Address,p.role_id);
            }
            return dt;
        }
        public DataTable FindUser(int ID,string Name)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Users select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("userID");
            dt.Columns.Add("Fullname");
            dt.Columns.Add("password");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone_Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("role_id");
            foreach (var p in us)
            {
                if(p.userID==ID && p.Fullname == Name)
                {
                    dt.Rows.Add(p.userID, p.Fullname, p.password, p.Birthday, p.Gender, p.Email, p.Phone_Number, p.Address, p.role_id);
                }
            }
            return dt;
        }
            public bool AddUser(int userID, string Fullname, string password, DateTime Birthday, bool Gender, string Email, string Phone_Number, string Address,int role_id, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            User us = new User();
            us.userID = userID;
            us.Fullname = Fullname;
            us.password = password;
            us.Birthday = Birthday;
            us.Gender = Gender;
            us.Email = Email;
            us.Phone_Number = Phone_Number;
            us.Address = Address;
            us.role_id = role_id;
            qlhotelEntity.Users.Add(us);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool DeleteUser(ref string err, int userID)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            User us = new User();
            us.userID = userID;
            qlhotelEntity.Users.Attach(us);
            qlhotelEntity.Users.Remove(us);
            qlhotelEntity.SaveChanges();
            return true;
        }
        public bool UpdateUser(int userID, string Fullname, string password, DateTime Birthday, bool Gender, string Email, string Phone_Number, string Address, int role_id, ref string err)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var usQuery = (from us in qlhotelEntity.Users
                             where us.userID == userID
                             select us).SingleOrDefault();
            if (usQuery != null)
            {
                usQuery.Fullname = Fullname;
                usQuery.password = password;
                usQuery.Birthday = Birthday;
                usQuery.Gender = Gender;
                usQuery.Email = Email;
                usQuery.Phone_Number = Phone_Number;
                usQuery.Address = Address;
                usQuery.role_id = role_id;
                qlhotelEntity.SaveChanges();
            }
            return true;
        }
    }
}
