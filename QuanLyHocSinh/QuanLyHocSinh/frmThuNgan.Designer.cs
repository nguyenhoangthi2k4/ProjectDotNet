namespace QuanLyHocSinh
{
    partial class frmThuNgan
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
            this.pnThuNgan = new System.Windows.Forms.Panel();
            this.lblThuNgan = new System.Windows.Forms.Label();
            this.grbThucHien = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbTTCTTN = new System.Windows.Forms.GroupBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.lblHocPhi = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.lblTTBHYT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grbDanhSachTN = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachTN = new System.Windows.Forms.DataGridView();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.lblTTHP = new System.Windows.Forms.Label();
            this.cbTTHP = new System.Windows.Forms.ComboBox();
            this.cbTTBHYT = new System.Windows.Forms.ComboBox();
            this.lblTimKiemHS = new System.Windows.Forms.Label();
            this.txtTimKiemHS = new System.Windows.Forms.TextBox();
            this.lblNgayDongHP = new System.Windows.Forms.Label();
            this.dtpNgayDongHP = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDongBHYT = new System.Windows.Forms.Label();
            this.dtpNgayDongBHYT = new System.Windows.Forms.DateTimePicker();
            this.pnThuNgan.SuspendLayout();
            this.grbThucHien.SuspendLayout();
            this.grbTTCTTN.SuspendLayout();
            this.grbDanhSachTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTN)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThuNgan
            // 
            this.pnThuNgan.Controls.Add(this.lblThuNgan);
            this.pnThuNgan.Controls.Add(this.grbThucHien);
            this.pnThuNgan.Controls.Add(this.grbTTCTTN);
            this.pnThuNgan.Controls.Add(this.grbDanhSachTN);
            this.pnThuNgan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThuNgan.Location = new System.Drawing.Point(0, 0);
            this.pnThuNgan.Name = "pnThuNgan";
            this.pnThuNgan.Size = new System.Drawing.Size(1475, 600);
            this.pnThuNgan.TabIndex = 11;
            // 
            // lblThuNgan
            // 
            this.lblThuNgan.AutoSize = true;
            this.lblThuNgan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgan.Location = new System.Drawing.Point(21, 28);
            this.lblThuNgan.Name = "lblThuNgan";
            this.lblThuNgan.Size = new System.Drawing.Size(445, 40);
            this.lblThuNgan.TabIndex = 3;
            this.lblThuNgan.Text = "DANH SÁCH THU NGÂN";
            // 
            // grbThucHien
            // 
            this.grbThucHien.Controls.Add(this.btnTimKiem);
            this.grbThucHien.Controls.Add(this.txtTimKiemHS);
            this.grbThucHien.Controls.Add(this.lblTimKiemHS);
            this.grbThucHien.Location = new System.Drawing.Point(22, 460);
            this.grbThucHien.Name = "grbThucHien";
            this.grbThucHien.Size = new System.Drawing.Size(550, 101);
            this.grbThucHien.TabIndex = 2;
            this.grbThucHien.TabStop = false;
            this.grbThucHien.Text = "Thực hiện";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(426, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 49);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grbTTCTTN
            // 
            this.grbTTCTTN.Controls.Add(this.dtpNgayDongBHYT);
            this.grbTTCTTN.Controls.Add(this.dtpNgayDongHP);
            this.grbTTCTTN.Controls.Add(this.cbTTBHYT);
            this.grbTTCTTN.Controls.Add(this.cbTTHP);
            this.grbTTCTTN.Controls.Add(this.txtBHYT);
            this.grbTTCTTN.Controls.Add(this.lblNgayDongBHYT);
            this.grbTTCTTN.Controls.Add(this.txtHocPhi);
            this.grbTTCTTN.Controls.Add(this.lblNgayDongHP);
            this.grbTTCTTN.Controls.Add(this.lblHocPhi);
            this.grbTTCTTN.Controls.Add(this.lblHocKy);
            this.grbTTCTTN.Controls.Add(this.txtHoTen);
            this.grbTTCTTN.Controls.Add(this.cbHocKy);
            this.grbTTCTTN.Controls.Add(this.lblTTHP);
            this.grbTTCTTN.Controls.Add(this.lblBHYT);
            this.grbTTCTTN.Controls.Add(this.lblTTBHYT);
            this.grbTTCTTN.Controls.Add(this.lblHoTen);
            this.grbTTCTTN.Location = new System.Drawing.Point(20, 88);
            this.grbTTCTTN.Name = "grbTTCTTN";
            this.grbTTCTTN.Size = new System.Drawing.Size(552, 351);
            this.grbTTCTTN.TabIndex = 1;
            this.grbTTCTTN.TabStop = false;
            this.grbTTCTTN.Text = "Thông tin chi tiết";
            // 
            // txtBHYT
            // 
            this.txtBHYT.Location = new System.Drawing.Point(85, 243);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(183, 26);
            this.txtBHYT.TabIndex = 5;
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.AutoSize = true;
            this.lblHocPhi.Location = new System.Drawing.Point(10, 148);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(67, 20);
            this.lblHocPhi.TabIndex = 4;
            this.lblHocPhi.Text = "Học phí:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(10, 48);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(57, 20);
            this.lblHocKy.TabIndex = 4;
            this.lblHocKy.Text = "Học kì:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(83, 96);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(456, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(83, 45);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(151, 28);
            this.cbHocKy.TabIndex = 2;
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.Location = new System.Drawing.Point(10, 248);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(56, 20);
            this.lblBHYT.TabIndex = 1;
            this.lblBHYT.Text = "BHYT:";
            // 
            // lblTTBHYT
            // 
            this.lblTTBHYT.AutoSize = true;
            this.lblTTBHYT.Location = new System.Drawing.Point(286, 248);
            this.lblTTBHYT.Name = "lblTTBHYT";
            this.lblTTBHYT.Size = new System.Drawing.Size(84, 20);
            this.lblTTBHYT.TabIndex = 1;
            this.lblTTBHYT.Text = "Tình trạng:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 98);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // grbDanhSachTN
            // 
            this.grbDanhSachTN.Controls.Add(this.dgvDanhSachTN);
            this.grbDanhSachTN.Location = new System.Drawing.Point(593, 88);
            this.grbDanhSachTN.Name = "grbDanhSachTN";
            this.grbDanhSachTN.Size = new System.Drawing.Size(870, 500);
            this.grbDanhSachTN.TabIndex = 0;
            this.grbDanhSachTN.TabStop = false;
            this.grbDanhSachTN.Text = "Danh sách lớp";
            // 
            // dgvDanhSachTN
            // 
            this.dgvDanhSachTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachTN.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachTN.Name = "dgvDanhSachTN";
            this.dgvDanhSachTN.RowHeadersWidth = 62;
            this.dgvDanhSachTN.RowTemplate.Height = 28;
            this.dgvDanhSachTN.Size = new System.Drawing.Size(864, 475);
            this.dgvDanhSachTN.TabIndex = 0;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(83, 145);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(185, 26);
            this.txtHocPhi.TabIndex = 5;
            // 
            // lblTTHP
            // 
            this.lblTTHP.AutoSize = true;
            this.lblTTHP.Location = new System.Drawing.Point(286, 146);
            this.lblTTHP.Name = "lblTTHP";
            this.lblTTHP.Size = new System.Drawing.Size(84, 20);
            this.lblTTHP.TabIndex = 1;
            this.lblTTHP.Text = "Tình trạng:";
            // 
            // cbTTHP
            // 
            this.cbTTHP.FormattingEnabled = true;
            this.cbTTHP.Location = new System.Drawing.Point(386, 143);
            this.cbTTHP.Name = "cbTTHP";
            this.cbTTHP.Size = new System.Drawing.Size(153, 28);
            this.cbTTHP.TabIndex = 6;
            // 
            // cbTTBHYT
            // 
            this.cbTTBHYT.FormattingEnabled = true;
            this.cbTTBHYT.Location = new System.Drawing.Point(386, 245);
            this.cbTTBHYT.Name = "cbTTBHYT";
            this.cbTTBHYT.Size = new System.Drawing.Size(153, 28);
            this.cbTTBHYT.TabIndex = 6;
            // 
            // lblTimKiemHS
            // 
            this.lblTimKiemHS.AutoSize = true;
            this.lblTimKiemHS.Location = new System.Drawing.Point(18, 50);
            this.lblTimKiemHS.Name = "lblTimKiemHS";
            this.lblTimKiemHS.Size = new System.Drawing.Size(143, 20);
            this.lblTimKiemHS.TabIndex = 0;
            this.lblTimKiemHS.Text = "Họ tên HS cần tìm:";
            // 
            // txtTimKiemHS
            // 
            this.txtTimKiemHS.Location = new System.Drawing.Point(167, 47);
            this.txtTimKiemHS.Name = "txtTimKiemHS";
            this.txtTimKiemHS.Size = new System.Drawing.Size(253, 26);
            this.txtTimKiemHS.TabIndex = 3;
            // 
            // lblNgayDongHP
            // 
            this.lblNgayDongHP.AutoSize = true;
            this.lblNgayDongHP.Location = new System.Drawing.Point(10, 198);
            this.lblNgayDongHP.Name = "lblNgayDongHP";
            this.lblNgayDongHP.Size = new System.Drawing.Size(89, 20);
            this.lblNgayDongHP.TabIndex = 4;
            this.lblNgayDongHP.Text = "Ngày đóng:";
            // 
            // dtpNgayDongHP
            // 
            this.dtpNgayDongHP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDongHP.Location = new System.Drawing.Point(105, 194);
            this.dtpNgayDongHP.Name = "dtpNgayDongHP";
            this.dtpNgayDongHP.Size = new System.Drawing.Size(265, 26);
            this.dtpNgayDongHP.TabIndex = 7;
            // 
            // lblNgayDongBHYT
            // 
            this.lblNgayDongBHYT.AutoSize = true;
            this.lblNgayDongBHYT.Location = new System.Drawing.Point(10, 298);
            this.lblNgayDongBHYT.Name = "lblNgayDongBHYT";
            this.lblNgayDongBHYT.Size = new System.Drawing.Size(89, 20);
            this.lblNgayDongBHYT.TabIndex = 4;
            this.lblNgayDongBHYT.Text = "Ngày đóng:";
            // 
            // dtpNgayDongBHYT
            // 
            this.dtpNgayDongBHYT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDongBHYT.Location = new System.Drawing.Point(105, 292);
            this.dtpNgayDongBHYT.Name = "dtpNgayDongBHYT";
            this.dtpNgayDongBHYT.Size = new System.Drawing.Size(265, 26);
            this.dtpNgayDongBHYT.TabIndex = 7;
            // 
            // frmThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnThuNgan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThuNgan";
            this.Text = "frmThuNgan";
            this.pnThuNgan.ResumeLayout(false);
            this.pnThuNgan.PerformLayout();
            this.grbThucHien.ResumeLayout(false);
            this.grbThucHien.PerformLayout();
            this.grbTTCTTN.ResumeLayout(false);
            this.grbTTCTTN.PerformLayout();
            this.grbDanhSachTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThuNgan;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.GroupBox grbThucHien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbTTCTTN;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.Label lblHocPhi;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblBHYT;
        private System.Windows.Forms.Label lblTTBHYT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grbDanhSachTN;
        private System.Windows.Forms.DataGridView dgvDanhSachTN;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label lblTTHP;
        private System.Windows.Forms.TextBox txtTimKiemHS;
        private System.Windows.Forms.Label lblTimKiemHS;
        private System.Windows.Forms.ComboBox cbTTBHYT;
        private System.Windows.Forms.ComboBox cbTTHP;
        private System.Windows.Forms.DateTimePicker dtpNgayDongBHYT;
        private System.Windows.Forms.DateTimePicker dtpNgayDongHP;
        private System.Windows.Forms.Label lblNgayDongBHYT;
        private System.Windows.Forms.Label lblNgayDongHP;
    }
}