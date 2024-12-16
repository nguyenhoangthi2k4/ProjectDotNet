namespace QuanLyHocSinh
{
    partial class frmDanhGiaHanhKiem
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
            this.lblDanhGiaHK = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbLoaiHK = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLoaiHK = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhGiaHK
            // 
            this.lblDanhGiaHK.AutoSize = true;
            this.lblDanhGiaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGiaHK.Location = new System.Drawing.Point(28, 48);
            this.lblDanhGiaHK.Name = "lblDanhGiaHK";
            this.lblDanhGiaHK.Size = new System.Drawing.Size(204, 40);
            this.lblDanhGiaHK.TabIndex = 7;
            this.lblDanhGiaHK.Text = "Hạnh Kiểm";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(593, 114);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(211, 30);
            this.txtHoTen.TabIndex = 2;
            // 
            // cbLoaiHK
            // 
            this.cbLoaiHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbLoaiHK.FormattingEnabled = true;
            this.cbLoaiHK.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu"});
            this.cbLoaiHK.Location = new System.Drawing.Point(961, 114);
            this.cbLoaiHK.Name = "cbLoaiHK";
            this.cbLoaiHK.Size = new System.Drawing.Size(165, 33);
            this.cbLoaiHK.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoTen.Location = new System.Drawing.Point(512, 117);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 25);
            this.lblHoTen.TabIndex = 16;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblLoaiHK
            // 
            this.lblLoaiHK.AutoSize = true;
            this.lblLoaiHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoaiHK.Location = new System.Drawing.Point(844, 117);
            this.lblLoaiHK.Name = "lblLoaiHK";
            this.lblLoaiHK.Size = new System.Drawing.Size(111, 25);
            this.lblLoaiHK.TabIndex = 17;
            this.lblLoaiHK.Text = "Hạnh kiểm:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1086, 563);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 46);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(912, 563);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 46);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.White;
            this.btnDanhGia.FlatAppearance.BorderSize = 0;
            this.btnDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhGia.Location = new System.Drawing.Point(736, 563);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(147, 46);
            this.btnDanhGia.TabIndex = 4;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.White;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(334, 114);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(127, 33);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "Cả năm",
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(133, 114);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(127, 33);
            this.cbHocKy.TabIndex = 0;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHocKy.Location = new System.Drawing.Point(30, 117);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(83, 25);
            this.lblHocKy.TabIndex = 8;
            this.lblHocKy.Text = "Học kỳ: ";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(32, 182);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1201, 360);
            this.dgvDanhSach.TabIndex = 9;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // frmDanhGiaHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1265, 644);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDanhGia);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbLoaiHK);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblLoaiHK);
            this.Controls.Add(this.lblDanhGiaHK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhGiaHanhKiem";
            this.Text = "frmDanhGiaHanhKiem";
            this.Click += new System.EventHandler(this.frmDanhGiaHanhKiem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhGiaHK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbLoaiHK;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLoaiHK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}