using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelMangement.DanhMucForm
{
    public partial class FormEmployeeServices : Form
    {
        int rAvai;
        int rBooked;
        int customerID;
        public FormEmployeeServices()
        {
            InitializeComponent();
            LoadDataAvai();
        }
        void LoadDataAvai()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var view = qlhotelEntity.VIEW_PRODUCT.ToList();
            dgvAvaiServices.DataSource = view;
            dgvAvaiServices.AutoGenerateColumns = true;     
            dgvAvaiServices.ColumnHeadersHeight = 30;
            dgvAvaiServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvaiServices_CellContentClick(null, null);
        }
        void LoadDataBooked()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            if (txtName.Text != null)
            {
                string name = txtName.Text;
                var pro = qlhotelEntity.FindServiceByName(name);
                dgvBookedServices.DataSource = pro;
                dgvBookedServices.ColumnHeadersHeight = 30;
                dgvBookedServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                customerID = ReturnCustomerID(name);
               
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            LoadDataBooked();
            dgvBookedServices_CellContentClick(null, null);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                int price = Convert.ToInt32(dgvAvaiServices.Rows[rAvai].Cells[0].Value.ToString()) * Convert.ToInt32(txtAmount.Text);
                var proce = qlhotelEntity.ADD_SERVICE(
                    Convert.ToInt32(txtBookID.Text),
                    customerID,
                    Convert.ToInt32(dgvAvaiServices.Rows[rAvai].Cells[0].Value.ToString()),
                    Convert.ToDouble(price),
                    Convert.ToInt32(txtAmount.Text),
                    DateTime.Now
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
            }
            LoadDataAvai();
            LoadDataBooked();
        }

        private void dgvAvaiServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rAvai = dgvAvaiServices.CurrentCell.RowIndex;
        }
        int ReturnCustomerID(string name)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Users select p;
            foreach (var p in us)
            {
                if(p.Fullname==name) return p.userID;
            }
            return 0;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            //    var proce = qlhotelEntity.DELETE_SERVICE(
            //        Convert.ToInt32(dgvBookedServices.Rows[rBooked].Cells[1].Value.ToString())
            //    );
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.InnerException.Message);
            //}
        }

        private void dgvBookedServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rBooked= dgvBookedServices.CurrentCell.RowIndex;
            LoadDataAvai();
            LoadDataBooked();
        }
    }
}
