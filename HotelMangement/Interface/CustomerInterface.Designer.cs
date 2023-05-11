namespace HotelMangement.Interface
{
    partial class CustomerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkOutBtn = new FontAwesome.Sharp.IconButton();
            this.serviceBtn = new FontAwesome.Sharp.IconButton();
            this.bookingBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1942, 1000);
            this.mainPanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(413, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1016, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khi nhap mong muon thi se pop up thong tin phong khach san cai nao available cai " +
    " nao unavailable";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.topPanel.Controls.Add(this.checkOutBtn);
            this.topPanel.Controls.Add(this.serviceBtn);
            this.topPanel.Controls.Add(this.bookingBtn);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1942, 127);
            this.topPanel.TabIndex = 7;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.checkOutBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.Location = new System.Drawing.Point(1080, 0);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.checkOutBtn.Size = new System.Drawing.Size(270, 127);
            this.checkOutBtn.TabIndex = 14;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.serviceBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serviceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.Location = new System.Drawing.Point(810, 0);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.serviceBtn.Size = new System.Drawing.Size(270, 127);
            this.serviceBtn.TabIndex = 13;
            this.serviceBtn.Text = "Services";
            this.serviceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingBtn.FlatAppearance.BorderSize = 0;
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.bookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.Location = new System.Drawing.Point(540, 0);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bookingBtn.Size = new System.Drawing.Size(270, 127);
            this.bookingBtn.TabIndex = 12;
            this.bookingBtn.Text = "Booking Room";
            this.bookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 127);
            this.panel1.TabIndex = 0;
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1000);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInterface";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton checkOutBtn;
        private FontAwesome.Sharp.IconButton serviceBtn;
        private FontAwesome.Sharp.IconButton bookingBtn;
        private System.Windows.Forms.Panel panel1;
    }
}