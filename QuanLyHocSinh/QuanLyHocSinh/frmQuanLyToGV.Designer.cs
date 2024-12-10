namespace QuanLyHocSinh
{
    partial class frmQuanLyToGV
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
            this.txtMaToGV = new System.Windows.Forms.TextBox();
            this.cbTruongTo = new System.Windows.Forms.ComboBox();
            this.txtTenTo = new System.Windows.Forms.TextBox();
            this.lblTenTo = new System.Windows.Forms.Label();
            this.lblMaTo = new System.Windows.Forms.Label();
            this.lblPCToGV = new System.Windows.Forms.Label();
            this.lblTruongTo = new System.Windows.Forms.Label();
            this.dgvDanhSachToGV = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaToGV
            // 
            this.txtMaToGV.BackColor = System.Drawing.Color.White;
            this.txtMaToGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaToGV.Location = new System.Drawing.Point(103, 120);
            this.txtMaToGV.Name = "txtMaToGV";
            this.txtMaToGV.Size = new System.Drawing.Size(184, 30);
            this.txtMaToGV.TabIndex = 8;
            // 
            // cbTruongTo
            // 
            this.cbTruongTo.BackColor = System.Drawing.Color.White;
            this.cbTruongTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTruongTo.FormattingEnabled = true;
            this.cbTruongTo.Location = new System.Drawing.Point(780, 120);
            this.cbTruongTo.Name = "cbTruongTo";
            this.cbTruongTo.Size = new System.Drawing.Size(228, 33);
            this.cbTruongTo.TabIndex = 14;
            // 
            // txtTenTo
            // 
            this.txtTenTo.BackColor = System.Drawing.Color.White;
            this.txtTenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenTo.Location = new System.Drawing.Point(413, 120);
            this.txtTenTo.Name = "txtTenTo";
            this.txtTenTo.Size = new System.Drawing.Size(218, 30);
            this.txtTenTo.TabIndex = 8;
            // 
            // lblTenTo
            // 
            this.lblTenTo.AutoSize = true;
            this.lblTenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTenTo.Location = new System.Drawing.Point(333, 123);
            this.lblTenTo.Name = "lblTenTo";
            this.lblTenTo.Size = new System.Drawing.Size(74, 25);
            this.lblTenTo.TabIndex = 0;
            this.lblTenTo.Text = "Tên tổ:";
            // 
            // lblMaTo
            // 
            this.lblMaTo.AutoSize = true;
            this.lblMaTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaTo.Location = new System.Drawing.Point(30, 123);
            this.lblMaTo.Name = "lblMaTo";
            this.lblMaTo.Size = new System.Drawing.Size(67, 25);
            this.lblMaTo.TabIndex = 0;
            this.lblMaTo.Text = "Mã tổ:";
            // 
            // lblPCToGV
            // 
            this.lblPCToGV.AutoSize = true;
            this.lblPCToGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblPCToGV.Location = new System.Drawing.Point(28, 48);
            this.lblPCToGV.Name = "lblPCToGV";
            this.lblPCToGV.Size = new System.Drawing.Size(367, 40);
            this.lblPCToGV.TabIndex = 0;
            this.lblPCToGV.Text = "Quản lý Tổ giáo viên";
            // 
            // lblTruongTo
            // 
            this.lblTruongTo.AutoSize = true;
            this.lblTruongTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTruongTo.Location = new System.Drawing.Point(672, 123);
            this.lblTruongTo.Name = "lblTruongTo";
            this.lblTruongTo.Size = new System.Drawing.Size(102, 25);
            this.lblTruongTo.TabIndex = 1;
            this.lblTruongTo.Text = "Trưởng tổ:";
            // 
            // dgvDanhSachToGV
            // 
            this.dgvDanhSachToGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachToGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachToGV.Location = new System.Drawing.Point(35, 181);
            this.dgvDanhSachToGV.MultiSelect = false;
            this.dgvDanhSachToGV.Name = "dgvDanhSachToGV";
            this.dgvDanhSachToGV.ReadOnly = true;
            this.dgvDanhSachToGV.RowHeadersWidth = 62;
            this.dgvDanhSachToGV.RowTemplate.Height = 28;
            this.dgvDanhSachToGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachToGV.Size = new System.Drawing.Size(1193, 350);
            this.dgvDanhSachToGV.TabIndex = 0;
            this.dgvDanhSachToGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachToGV_CellContentClick);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1081, 567);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 46);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(905, 567);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 46);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(729, 567);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 46);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(553, 567);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 46);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyToGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1265, 644);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachToGV);
            this.Controls.Add(this.lblTruongTo);
            this.Controls.Add(this.lblPCToGV);
            this.Controls.Add(this.txtMaToGV);
            this.Controls.Add(this.lblMaTo);
            this.Controls.Add(this.cbTruongTo);
            this.Controls.Add(this.lblTenTo);
            this.Controls.Add(this.txtTenTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyToGV";
            this.Text = "frmToGV";
            this.Click += new System.EventHandler(this.frmQuanLyToGV_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaToGV;
        private System.Windows.Forms.ComboBox cbTruongTo;
        private System.Windows.Forms.TextBox txtTenTo;
        private System.Windows.Forms.Label lblTenTo;
        private System.Windows.Forms.Label lblMaTo;
        private System.Windows.Forms.Label lblPCToGV;
        private System.Windows.Forms.Label lblTruongTo;
        private System.Windows.Forms.DataGridView dgvDanhSachToGV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}