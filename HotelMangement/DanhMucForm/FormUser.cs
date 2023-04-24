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
    public partial class FormUser : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLUser dbU = new BLUser();
        public FormUser()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvUSER.DataSource = dbU.TakeUser();
                // Thay đổi độ rộng cột
                dgvUSER.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtuserID.ResetText();
                this.txtFullname.ResetText();
                this.txtBirthday.ResetText();
                this.txtGender.ResetText();
                this.txtEmail.ResetText();
                this.txtPhone_Number.ResetText();
                this.txtAddress.ResetText();
                this.txtrole_id.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvUSER_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table USER. Lỗi rồi!!!");
            }
        }
        private void FromUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtuserID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtuserID.ResetText();
            this.txtFullname.ResetText();
            this.txtBirthday.ResetText();
            this.txtGender.ResetText();
            this.txtEmail.ResetText();
            this.txtPhone_Number.ResetText();
            this.txtAddress.ResetText();
            this.txtrole_id.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtUserID
            this.txtuserID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvUSER_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtUserID
            this.txtuserID.Enabled = false;
            this.txtFullname.Focus();

        }
        private void dgvUSER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvUSER.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtuserID.Text =
            dgvUSER.Rows[r].Cells[0].Value.ToString();
            this.txtFullname.Text =
            dgvUSER.Rows[r].Cells[1].Value.ToString();
            this.txtBirthday.Text =
            dgvUSER.Rows[r].Cells[2].Value.ToString();
            this.txtGender.Text =
            dgvUSER.Rows[r].Cells[3].Value.ToString();
            this.txtEmail.Text =
            dgvUSER.Rows[r].Cells[4].Value.ToString();
            this.txtPhone_Number.Text =
            dgvUSER.Rows[r].Cells[5].Value.ToString();
            this.txtAddress.Text =
            dgvUSER.Rows[r].Cells[6].Value.ToString();
            this.txtrole_id.Text =
            dgvUSER.Rows[r].Cells[7].Value.ToString();
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
            this.txtuserID.ResetText();
            this.txtFullname.ResetText();
            this.txtBirthday.ResetText();
            this.txtGender.ResetText();
            this.txtEmail.ResetText();
            this.txtPhone_Number.ResetText();
            this.txtAddress.ResetText();
            this.txtrole_id.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvUSER_CellClick(null, null);
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
                    BLUser blU = new BLUser();
                    blU.AddUser(Convert.ToInt32(this.txtuserID.Text), this.txtFullname.Text, DateTime.Parse(this.txtBirthday.Text), bool.Parse(this.txtGender.Text), this.txtEmail.Text,this.txtPhone_Number.Text, this.txtAddress.Text,Convert.ToInt32(this.txtrole_id.Text), ref err);
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
                BLUser blU = new BLUser();
                blU.UpdateUser(Convert.ToInt32(this.txtuserID.Text), this.txtFullname.Text, DateTime.Parse(this.txtBirthday.Text), bool.Parse(this.txtGender.Text), this.txtEmail.Text, this.txtPhone_Number.Text, this.txtAddress.Text, Convert.ToInt32(this.txtrole_id.Text), ref err);
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
                int r = dgvUSER.CurrentCell.RowIndex;
                string strU =
                dgvUSER.Rows[r].Cells[0].Value.ToString();
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
                    dbU.DeleteUser(ref err, Convert.ToInt32(strU));
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
