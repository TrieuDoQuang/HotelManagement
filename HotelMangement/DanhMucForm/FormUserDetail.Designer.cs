namespace HotelMangement.DanhMucForm
{
    partial class FormUserDetail
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
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvUSERDETAIL = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbook_ID = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtroom_ID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtcustomerID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERDETAIL)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(927, 598);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 28);
            this.btnReload.TabIndex = 131;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // dgvUSERDETAIL
            // 
            this.dgvUSERDETAIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUSERDETAIL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvUSERDETAIL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUSERDETAIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSERDETAIL.Location = new System.Drawing.Point(712, 62);
            this.dgvUSERDETAIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUSERDETAIL.Name = "dgvUSERDETAIL";
            this.dgvUSERDETAIL.RowHeadersWidth = 51;
            this.dgvUSERDETAIL.Size = new System.Drawing.Size(835, 442);
            this.dgvUSERDETAIL.TabIndex = 130;
            this.dgvUSERDETAIL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUSERDETAIL_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(785, 598);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 30);
            this.btnDelete.TabIndex = 136;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "room_ID:";
            // 
            // txtbook_ID
            // 
            this.txtbook_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbook_ID.Location = new System.Drawing.Point(300, 123);
            this.txtbook_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbook_ID.Name = "txtbook_ID";
            this.txtbook_ID.Size = new System.Drawing.Size(125, 26);
            this.txtbook_ID.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(33, 127);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(83, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "book_ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(335, 599);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 132;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtroom_ID
            // 
            this.txtroom_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom_ID.Location = new System.Drawing.Point(300, 192);
            this.txtroom_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtroom_ID.Name = "txtroom_ID";
            this.txtroom_ID.Size = new System.Drawing.Size(125, 26);
            this.txtroom_ID.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1064, 598);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 30);
            this.btnBack.TabIndex = 137;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(480, 598);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 30);
            this.btnSave.TabIndex = 134;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtcustomerID
            // 
            this.txtcustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerID.Location = new System.Drawing.Point(300, 257);
            this.txtcustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.Size = new System.Drawing.Size(125, 26);
            this.txtcustomerID.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(633, 598);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 30);
            this.btnCancel.TabIndex = 135;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "customerID:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel.Controls.Add(this.txtcustomerID);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtroom_ID);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtbook_ID);
            this.panel.Controls.Add(this.lb1);
            this.panel.Location = new System.Drawing.Point(165, 62);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(471, 442);
            this.panel.TabIndex = 138;
            // 
            // FormUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1712, 690);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvUSERDETAIL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUserDetail";
            this.Text = "FormUserDetail";
            this.Load += new System.EventHandler(this.FormUserDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERDETAIL)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvUSERDETAIL;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbook_ID;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtroom_ID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtcustomerID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel;
    }
}