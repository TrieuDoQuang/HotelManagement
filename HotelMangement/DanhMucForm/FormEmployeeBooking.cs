using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMangement.DanhMucForm
{
    public partial class FormEmployeeBooking : Form
    {
        public FormEmployeeBooking()
        {
            InitializeComponent();
            LoadAvaiRoom();
            LoadBookedRoom();
        }
        void LoadAvaiRoom()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var view = qlhotelEntity.Show_AvailableRoom.ToList();
            dgvAvaiRoom.DataSource = view;
            dgvAvaiRoom.AutoGenerateColumns = true;
            dgvAvaiRoom.ColumnHeadersHeight = 30;
            dgvAvaiRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        void LoadBookedRoom()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var view = qlhotelEntity.Show_BookedRoom.ToList();
            dgvBookedRoom.DataSource = view;
            dgvBookedRoom.AutoGenerateColumns = true;
            dgvBookedRoom.ColumnHeadersHeight = 30;
            dgvBookedRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
    
}
