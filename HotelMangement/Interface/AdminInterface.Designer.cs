namespace HotelMangement.Interface
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.userDetailBtn = new FontAwesome.Sharp.IconButton();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.serviceBtn = new FontAwesome.Sharp.IconButton();
            this.bookingBtn = new FontAwesome.Sharp.IconButton();
            this.roomBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.leftPanel.Controls.Add(this.userDetailBtn);
            this.leftPanel.Controls.Add(this.productBtn);
            this.leftPanel.Controls.Add(this.serviceBtn);
            this.leftPanel.Controls.Add(this.bookingBtn);
            this.leftPanel.Controls.Add(this.roomBtn);
            this.leftPanel.Controls.Add(this.userBtn);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 1000);
            this.leftPanel.TabIndex = 2;
            // 
            // userDetailBtn
            // 
            this.userDetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDetailBtn.FlatAppearance.BorderSize = 0;
            this.userDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDetailBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.userDetailBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.Location = new System.Drawing.Point(0, 756);
            this.userDetailBtn.Name = "userDetailBtn";
            this.userDetailBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.userDetailBtn.Size = new System.Drawing.Size(300, 98);
            this.userDetailBtn.TabIndex = 14;
            this.userDetailBtn.Text = "User Detail";
            this.userDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userDetailBtn.UseVisualStyleBackColor = true;
            this.userDetailBtn.Click += new System.EventHandler(this.userDetailBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.productBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 658);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(300, 98);
            this.productBtn.TabIndex = 13;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.serviceBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serviceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.Location = new System.Drawing.Point(0, 560);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.serviceBtn.Size = new System.Drawing.Size(300, 98);
            this.serviceBtn.TabIndex = 12;
            this.serviceBtn.Text = "Services";
            this.serviceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingBtn.FlatAppearance.BorderSize = 0;
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.bookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.Location = new System.Drawing.Point(0, 462);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bookingBtn.Size = new System.Drawing.Size(300, 98);
            this.bookingBtn.TabIndex = 11;
            this.bookingBtn.Text = "Booking Detail";
            this.bookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.roomBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.Location = new System.Drawing.Point(0, 364);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.roomBtn.Size = new System.Drawing.Size(300, 98);
            this.roomBtn.TabIndex = 10;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.userBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 266);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(300, 98);
            this.userBtn.TabIndex = 9;
            this.userBtn.Text = "Users List";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 266);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(38, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(221, 198);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(300, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1642, 90);
            this.topPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 90);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1642, 910);
            this.mainPanel.TabIndex = 4;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1000);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private FontAwesome.Sharp.IconButton userBtn;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton serviceBtn;
        private FontAwesome.Sharp.IconButton bookingBtn;
        private FontAwesome.Sharp.IconButton roomBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton userDetailBtn;
    }
}