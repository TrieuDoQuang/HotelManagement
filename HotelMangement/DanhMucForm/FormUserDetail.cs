using HotelMangement.BS_Layer;
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
    public partial class FormUserDetail : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLUserDetail dbUD = new BLUserDetail();
        public FormUserDetail()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                DataTable dataTable = dbUD.TakeUserDetail();

                // Change the column name
                dataTable.Columns["book_ID"].ColumnName = "Mã phòng";
                dataTable.Columns["room_ID"].ColumnName = "Số phòng";
                dataTable.Columns["customerID"].ColumnName = "Mã khách hàng";
                // Set the DataSource of the DataGridView
                dgvUSERDETAIL.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtbook_ID.ResetText();
                this.txtroom_ID.ResetText();
                this.txtcustomerID.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvUSERDETAIL_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table USERDETAIL. Lỗi rồi!!!");
            }
        }
        private void FormUserDetail_Load(object sender, EventArgs e)
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
            this.txtbook_ID.ResetText();
            this.txtroom_ID.ResetText();
            this.txtcustomerID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtbook_ID.Focus();
        }
        private void dgvUSERDETAIL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvUSERDETAIL.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtbook_ID.Text =
            dgvUSERDETAIL.Rows[r].Cells[0].Value.ToString();
            this.txtroom_ID.Text =
            dgvUSERDETAIL.Rows[r].Cells[1].Value.ToString();
            this.txtcustomerID.Text =
            dgvUSERDETAIL.Rows[r].Cells[2].Value.ToString();
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
            this.txtroom_ID.ResetText();
            this.txtcustomerID.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvUSERDETAIL_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLUserDetail blUd = new BLUserDetail();
                    blUd.AddUserDetail(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtroom_ID.Text), Convert.ToInt32(this.txtcustomerID.Text), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLUserDetail blUd = new BLUserDetail();
                blUd.UpdateUserDetail(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtroom_ID.Text), Convert.ToInt32(this.txtcustomerID.Text), ref err);
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
                int r = dgvUSERDETAIL.CurrentCell.RowIndex;
                string strUD1 =
                dgvUSERDETAIL.Rows[r].Cells[0].Value.ToString();
                string strUD2 =
                dgvUSERDETAIL.Rows[r].Cells[1].Value.ToString();
                string strUD3 =
                dgvUSERDETAIL.Rows[r].Cells[2].Value.ToString();
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
                    dbUD.DeleteUserDetail(ref err, Convert.ToInt32(strUD1), Convert.ToInt32(strUD2), Convert.ToInt32(strUD3));
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvUSERDETAIL_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.updateBtn.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtUserID
            this.txtbook_ID.Enabled = false;
            this.txtbook_ID.Focus();
        }
    }
}
