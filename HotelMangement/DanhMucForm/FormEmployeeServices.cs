using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
            var view = qlhotelEntity.View_AvailableProduct.ToList();
            dgvAvaiServices.DataSource = view;
            dgvAvaiServices.AutoGenerateColumns = true;
            dgvAvaiServices.ColumnHeadersHeight = 30;
            dgvAvaiServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvaiServices.Columns[0].HeaderText = "Product ID";
            dgvAvaiServices.Columns[1].HeaderText = "Product Name";
            dgvAvaiServices_CellClick(null, null);
        }
        void LoadDataBooked()
        {
            if (txtName.Text != null)
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                string name = txtName.Text;
                //var pro = qlhotelEntity.Database.ExecuteSqlCommand($"Exec FindServiceByName N'{name}'");
                var pro = qlhotelEntity.Database.SqlQuery<ServiceModel>("FindServiceByName @Name", new SqlParameter("@Name", name)).ToList();
                dgvBookedServices.DataSource = pro;
                dgvBookedServices.ColumnHeadersHeight = 30;
                dgvBookedServices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvBookedServices_CellClick(null, null);
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            LoadDataBooked();
            customerID = ReturnCustomerID(txtName.Text);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_ADD_SERVICE(
                    Convert.ToInt32(txtBookID.Text),
                    customerID,
                    Convert.ToInt32(dgvAvaiServices.Rows[rAvai].Cells[0].Value.ToString()),
                    Convert.ToDouble(dgvAvaiServices.Rows[rAvai].Cells[2].Value.ToString()),
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

        private void dgvAvaiServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rAvai = dgvAvaiServices.CurrentCell.RowIndex;
            this.txtNameProduct.Text = dgvAvaiServices.Rows[rAvai].Cells[1].Value.ToString();
        }
        int ReturnCustomerID(string name)
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var us = from p in qlhotelEntity.Customers select p;
            foreach (var p in us)
            {
                if (p.Fullname == name) return p.cID;
            }
            return 0;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
                var proce = qlhotelEntity.SP_DELETE_SERVICE(
                    Convert.ToInt32(dgvBookedServices.Rows[rBooked].Cells[0].Value.ToString())
                );
                LoadDataAvai();
                LoadDataBooked();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
            }
        }

        private void dgvBookedServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rBooked = dgvBookedServices.CurrentCell.RowIndex;
        }
        public class ServiceModel
        {
            [DisplayName("Service ID")]
            public int serID { get; set; }

            [DisplayName("Customer Name")]
            public string Fullname { get; set; }

            [DisplayName("Product Name")]
            public string ProductName { get; set; }

            [DisplayName("Booking ID")]
            public int book_ID { get; set; }
            public int Amount { get; set; }
            public double Price { get; set; }

            [DisplayName("Buy Date")]
            public DateTime Buy_Date { get; set; }
        }
        public class MyDbContext : DbContext
        {
            public DbSet<ServiceModel> Services { get; set; }
        }
    }
}
