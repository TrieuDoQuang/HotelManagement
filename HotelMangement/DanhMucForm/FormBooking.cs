﻿using System;
using HotelMangement.BS_Layer;
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
    public partial class FormBooking : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;

        BLBooking dbBooking = new BLBooking();
        public FormBooking()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                DataTable dataTable = dbBooking.TakeBooking();

                dgvBOOKING.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtbook_ID.ResetText();
                this.txtStaff_ID.ResetText();
                this.txtCustomer_ID.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvBOOKING_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table BOOKINGDETAIL. Lỗi rồi!!!");
            }
        }
        private void FormBooking_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtbook_ID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newBookingID = Convert.ToInt32(dgvBOOKING.Rows[dgvBOOKING.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtbook_ID.Text = newBookingID.ToString();
            this.txtStaff_ID.ResetText();
            this.txtCustomer_ID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtStaff_ID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvBOOKING_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtbook_ID.Enabled = false;
            this.txtStaff_ID.Enabled = false;
            this.txtCustomer_ID.Focus();

        }
        private void dgvBOOKING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvBOOKING.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtbook_ID.Text =
            dgvBOOKING.Rows[r].Cells[0].Value.ToString();
            this.txtStaff_ID.Text =
            dgvBOOKING.Rows[r].Cells[1].Value.ToString();
            this.txtCustomer_ID.Text =
            dgvBOOKING.Rows[r].Cells[2].Value.ToString();
            this.dtpCheckIn.Text =
            dgvBOOKING.Rows[r].Cells[3].Value.ToString();
            this.dtpCheckOut.Text =
            dgvBOOKING.Rows[r].Cells[4].Value.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtbook_ID.ResetText();
            this.txtStaff_ID.ResetText();
            this.txtCustomer_ID.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvBOOKING_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLBooking bk = new BLBooking();
                if (bk.AddBooking(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtStaff_ID.Text), Convert.ToInt32(this.txtCustomer_ID.Text), dtpCheckIn.Value, dtpCheckOut.Value, ref err))
                    MessageBox.Show("Add successfully");
                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLBooking bk = new BLBooking();
                bk.UpdateBooking(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtStaff_ID.Text), Convert.ToInt32(this.txtCustomer_ID.Text), dtpCheckIn.Value, dtpCheckOut.Value, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvBOOKING.CurrentCell.RowIndex;
                string strBD1 =
                dgvBOOKING.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbBooking.DeleteBooking(ref err, Convert.ToInt32(strBD1));
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
    }
}
