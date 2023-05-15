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
    public partial class FormCheckOut : Form
    {

        FormReceipt formReceipt = new FormReceipt();
        public FormCheckOut()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            var view = qlhotelEntity.Customers.ToList();
            dgvCustomer.DataSource = view;
            dgvCustomer.AutoGenerateColumns = true;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (formReceipt.IsDisposed)
            {
                formReceipt = new FormReceipt();
            }
            formReceipt.TopLevel = false;
            formReceipt.FormBorderStyle = FormBorderStyle.None;
            formReceipt.Dock = DockStyle.Fill;
            receptPanel.Controls.Add(formReceipt);
            receptPanel.Tag = formReceipt;
            receptPanel.BringToFront();
            formReceipt.BringToFront();
            closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            closeBtn.BringToFront();
            formReceipt.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            formReceipt.Close();
            closeBtn.SendToBack();
            closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            receptPanel.SendToBack();
           
            
        }
    }
}
