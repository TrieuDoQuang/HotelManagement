using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HotelMangement.DanhMucForm;


namespace HotelMangement.Interface
{
    public partial class EmployeeInterface : Form
    {
        private Form currentChildForm;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public EmployeeInterface()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployeeBooking());
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployeeServices());
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCheckOut());
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
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
