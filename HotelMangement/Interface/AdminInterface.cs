using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMangement.DanhMucForm;

namespace HotelMangement.Interface
{
    public partial class AdminInterface : Form
    {

        private Form currentChildForm;
        public AdminInterface()
        {
            InitializeComponent();
        }


        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBookingDetail());
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUser());
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRoom());
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormService());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProduct());
        }

        private void userDetailBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUserDetail());
        }

        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
    }
}
