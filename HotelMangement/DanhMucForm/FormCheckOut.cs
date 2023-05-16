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
        int rAvai;
        int currentCustomerID;

        FormReceipt formReceipt = new FormReceipt();
        public FormCheckOut()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            HotelManagementSystemEntities qlhotelEntity = new HotelManagementSystemEntities();
            string nameToFind = txtFindName.Text;
            List<View_CustomerCheckOut> view = null;

            if (string.IsNullOrEmpty(nameToFind))
            {
                view = qlhotelEntity.View_CustomerCheckOut.ToList();
            }
            else
            {
                var searchResults = qlhotelEntity.FindCustomerByFullName(nameToFind).ToList();
                view = searchResults.Select(result => new View_CustomerCheckOut
                {
                    cID = result.cID,
                    Fullname = result.Fullname,
                    Email = result.Email,
                    Phone_Number = result.Phone_Number,
                    room_No = result.room_No,
                    Check_In = result.Check_In,
                    Check_Out = result.Check_Out
                }).ToList();
            }
           
            dgvCustomer.DataSource = view;
            dgvCustomer.AutoGenerateColumns = true;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.Columns[0].HeaderText = "Customer ID";
            dgvCustomer.Columns[1].HeaderText = "Customer Name";
            dgvCustomer.Columns[3].HeaderText = "Phone Number";
            dgvCustomer.Columns[4].HeaderText = "Room Number";
            dgvCustomer.Columns[5].HeaderText = "Check In Date";
            dgvCustomer.Columns[6].HeaderText = "Check Out Date";
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (formReceipt.IsDisposed)
            {
                formReceipt = new FormReceipt(currentCustomerID);
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

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rAvai = dgvCustomer.CurrentCell.RowIndex;
            this.txtCName.Text = dgvCustomer.Rows[rAvai].Cells[1].Value.ToString();
            this.txtRoom.Text = dgvCustomer.Rows[rAvai].Cells[4].Value.ToString();
            currentCustomerID = Convert.ToInt32(dgvCustomer.Rows[rAvai].Cells[0].Value);
            Console.WriteLine(currentCustomerID);
            DateTime checkIn = DateTime.Parse(dgvCustomer.Rows[rAvai].Cells[5].Value.ToString());
            DateTime checkOut = DateTime.Parse(dgvCustomer.Rows[rAvai].Cells[6].Value.ToString());
            TimeSpan duration = checkOut - checkIn;
            this.txtStayingDays.Text = duration.Days.ToString() + " Days";
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
