﻿using System;
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
    public partial class FormReceipt : Form
    {

        public int currentCustomerID { get; set; }
   
        public FormReceipt()
        {
            InitializeComponent();
        }

        public FormReceipt(int currentCustomerID)
        {
            InitializeComponent();
            this.currentCustomerID = currentCustomerID;
        }
    }



}
