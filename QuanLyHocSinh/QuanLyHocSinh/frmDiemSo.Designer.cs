namespace QuanLyHocSinh
{
    partial class frmDiemSo
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblQLDS = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtSinh = new System.Windows.Forms.TextBox();
            this.txtGDCD = new System.Windows.Forms.TextBox();
            this.txtNgNgu = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblSinh = new System.Windows.Forms.Label();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblGDCD = new System.Windows.Forms.Label();
            this.lblLy = new System.Windows.Forms.Label();
            this.lblNgNgu = new System.Windows.Forms.Label();
            this.lblSu = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblHoa = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(34, 205);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1201, 327);
            this.dgvDanhSach.TabIndex = 21;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // lblQLDS
            // 
            this.lblQLDS.AutoSize = true;
            this.lblQLDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDS.Location = new System.Drawing.Point(28, 48);
            this.lblQLDS.Name = "lblQLDS";
            this.lblQLDS.Size = new System.Drawing.Size(162, 40);
            this.lblQLDS.TabIndex = 6;
            this.lblQLDS.Text = "Điểm Số";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "Cả năm",
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(132, 112);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(127, 33);
            this.cbHocKy.TabIndex = 0;
            // 
            // txtDTB
            // 
            this.txtDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDTB.Location = new System.Drawing.Point(1178, 154);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(55, 30);
            this.txtDTB.TabIndex = 12;
            // 
            // txtSinh
            // 
            this.txtSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSinh.Location = new System.Drawing.Point(736, 154);
            this.txtSinh.Name = "txtSinh";
            this.txtSinh.Size = new System.Drawing.Size(55, 30);
            this.txtSinh.TabIndex = 6;
            // 
            // txtGDCD
            // 
            this.txtGDCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGDCD.Location = new System.Drawing.Point(1032, 154);
            this.txtGDCD.Name = "txtGDCD";
            this.txtGDCD.Size = new System.Drawing.Size(55, 30);
            this.txtGDCD.TabIndex = 10;
            // 
            // txtNgNgu
            // 
            this.txtNgNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNgNgu.Location = new System.Drawing.Point(1178, 115);
            this.txtNgNgu.Name = "txtNgNgu";
            this.txtNgNgu.Size = new System.Drawing.Size(55, 30);
            this.txtNgNgu.TabIndex = 11;
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDia.Location = new System.Drawing.Point(883, 154);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(55, 30);
            this.txtDia.TabIndex = 8;
            // 
            // txtLy
            // 
            this.txtLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLy.Location = new System.Drawing.Point(883, 115);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(55, 30);
            this.txtLy.TabIndex = 7;
            // 
            // txtSu
            // 
            this.txtSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSu.Location = new System.Drawing.Point(1032, 115);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(55, 30);
            this.txtSu.TabIndex = 9;
            // 
            // txtVan
            // 
            this.txtVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVan.Location = new System.Drawing.Point(564, 154);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(55, 30);
            this.txtVan.TabIndex = 4;
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDTB.Location = new System.Drawing.Point(1101, 157);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(58, 25);
            this.lblDTB.TabIndex = 31;
            this.lblDTB.Text = "ĐTB:";
            // 
            // lblSinh
            // 
            this.lblSinh.AutoSize = true;
            this.lblSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSinh.Location = new System.Drawing.Point(639, 157);
            this.lblSinh.Name = "lblSinh";
            this.lblSinh.Size = new System.Drawing.Size(95, 25);
            this.lblSinh.TabIndex = 4;
            this.lblSinh.Text = "Sinh học:";
            // 
            // txtHoa
            // 
            this.txtHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoa.Location = new System.Drawing.Point(736, 115);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(55, 30);
            this.txtHoa.TabIndex = 5;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDia.Location = new System.Drawing.Point(810, 157);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(66, 25);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "Địa lý:";
            // 
            // lblGDCD
            // 
            this.lblGDCD.AutoSize = true;
            this.lblGDCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGDCD.Location = new System.Drawing.Point(955, 157);
            this.lblGDCD.Name = "lblGDCD";
            this.lblGDCD.Size = new System.Drawing.Size(76, 25);
            this.lblGDCD.TabIndex = 11;
            this.lblGDCD.Text = "GDCD:";
            // 
            // lblLy
            // 
            this.lblLy.AutoSize = true;
            this.lblLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLy.Location = new System.Drawing.Point(810, 118);
            this.lblLy.Name = "lblLy";
            this.lblLy.Size = new System.Drawing.Size(67, 25);
            this.lblLy.TabIndex = 6;
            this.lblLy.Text = "Vật lý:";
            // 
            // lblNgNgu
            // 
            this.lblNgNgu.AutoSize = true;
            this.lblNgNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNgNgu.Location = new System.Drawing.Point(1101, 118);
            this.lblNgNgu.Name = "lblNgNgu";
            this.lblNgNgu.Size = new System.Drawing.Size(79, 25);
            this.lblNgNgu.TabIndex = 25;
            this.lblNgNgu.Text = "NgNgữ:";
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSu.Location = new System.Drawing.Point(951, 118);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(80, 25);
            this.lblSu.TabIndex = 10;
            this.lblSu.Text = "Lịch sử:";
            // 
            // txtToan
            // 
            this.txtToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtToan.Location = new System.Drawing.Point(564, 115);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(55, 30);
            this.txtToan.TabIndex = 3;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVan.Location = new System.Drawing.Point(479, 157);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(79, 25);
            this.lblVan.TabIndex = 23;
            this.lblVan.Text = "NgVăn:";
            // 
            // lblHoa
            // 
            this.lblHoa.AutoSize = true;
            this.lblHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoa.Location = new System.Drawing.Point(639, 118);
            this.lblHoa.Name = "lblHoa";
            this.lblHoa.Size = new System.Drawing.Size(91, 25);
            this.lblHoa.TabIndex = 3;
            this.lblHoa.Text = "Hóa học:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(132, 154);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(335, 30);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToan.Location = new System.Drawing.Point(479, 118);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(64, 25);
            this.lblToan.TabIndex = 21;
            this.lblToan.Text = "Toán:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHocKy.Location = new System.Drawing.Point(29, 112);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(83, 25);
            this.lblHocKy.TabIndex = 7;
            this.lblHocKy.Text = "Học kỳ: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoTen.Location = new System.Drawing.Point(30, 157);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 25);
            this.lblHoTen.TabIndex = 20;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.White;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(340, 112);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(127, 33);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.White;
            this.btnNhapDiem.FlatAppearance.BorderSize = 0;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapDiem.Location = new System.Drawing.Point(734, 563);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(147, 46);
            this.btnNhapDiem.TabIndex = 13;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(910, 563);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 46);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmDiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1265, 644);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtSinh);
            this.Controls.Add(this.txtGDCD);
            this.Controls.Add(this.txtNgNgu);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.txtSu);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblSinh);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblGDCD);
            this.Controls.Add(this.lblLy);
            this.Controls.Add(this.lblNgNgu);
            this.Controls.Add(this.lblSu);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.lblHoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lblQLDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemSo";
            this.Text = "frmDiemSo";
            this.Click += new System.EventHandler(this.frmDiemSo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lblQLDS;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtSinh;
        private System.Windows.Forms.TextBox txtGDCD;
        private System.Windows.Forms.TextBox txtNgNgu;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblSinh;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblGDCD;
        private System.Windows.Forms.Label lblLy;
        private System.Windows.Forms.Label lblNgNgu;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblHoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}