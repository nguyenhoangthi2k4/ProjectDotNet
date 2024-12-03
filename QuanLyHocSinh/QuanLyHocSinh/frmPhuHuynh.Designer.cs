namespace QuanLyHocSinh
{
    partial class frmPhuHuynh
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
            this.pnPhuHuynh = new System.Windows.Forms.Panel();
            this.grbDanhSachPH = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPH = new System.Windows.Forms.DataGridView();
            this.grbThucHien = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.cbTenHS = new System.Windows.Forms.ComboBox();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.txtSoDTPH = new System.Windows.Forms.TextBox();
            this.lblQuanHe = new System.Windows.Forms.Label();
            this.lblSoDTPH = new System.Windows.Forms.Label();
            this.dtpNgaySinhPH = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinhPH = new System.Windows.Forms.ComboBox();
            this.txtHoTenPH = new System.Windows.Forms.TextBox();
            this.txtDiaChiPH = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.lblGioiTinhPH = new System.Windows.Forms.Label();
            this.lblNamSinhPH = new System.Windows.Forms.Label();
            this.lblDiaChiPH = new System.Windows.Forms.Label();
            this.lblHoTenPH = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblThongTinPH = new System.Windows.Forms.Label();
            this.pnPhuHuynh.SuspendLayout();
            this.grbDanhSachPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPH)).BeginInit();
            this.grbThucHien.SuspendLayout();
            this.grbTTCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPhuHuynh
            // 
            this.pnPhuHuynh.Controls.Add(this.grbDanhSachPH);
            this.pnPhuHuynh.Controls.Add(this.grbThucHien);
            this.pnPhuHuynh.Controls.Add(this.grbTTCT);
            this.pnPhuHuynh.Controls.Add(this.lblThongTinPH);
            this.pnPhuHuynh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPhuHuynh.Location = new System.Drawing.Point(0, 0);
            this.pnPhuHuynh.Name = "pnPhuHuynh";
            this.pnPhuHuynh.Size = new System.Drawing.Size(1475, 600);
            this.pnPhuHuynh.TabIndex = 5;
            // 
            // grbDanhSachPH
            // 
            this.grbDanhSachPH.Controls.Add(this.dgvDanhSachPH);
            this.grbDanhSachPH.Location = new System.Drawing.Point(570, 86);
            this.grbDanhSachPH.Name = "grbDanhSachPH";
            this.grbDanhSachPH.Size = new System.Drawing.Size(893, 502);
            this.grbDanhSachPH.TabIndex = 9;
            this.grbDanhSachPH.TabStop = false;
            this.grbDanhSachPH.Text = "Danh sách";
            // 
            // dgvDanhSachPH
            // 
            this.dgvDanhSachPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPH.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachPH.Name = "dgvDanhSachPH";
            this.dgvDanhSachPH.RowHeadersWidth = 62;
            this.dgvDanhSachPH.RowTemplate.Height = 28;
            this.dgvDanhSachPH.Size = new System.Drawing.Size(887, 477);
            this.dgvDanhSachPH.TabIndex = 0;
            // 
            // grbThucHien
            // 
            this.grbThucHien.Controls.Add(this.btnHuy);
            this.grbThucHien.Controls.Add(this.btnLuu);
            this.grbThucHien.Controls.Add(this.btnSua);
            this.grbThucHien.Controls.Add(this.btnNhap);
            this.grbThucHien.Location = new System.Drawing.Point(27, 415);
            this.grbThucHien.Name = "grbThucHien";
            this.grbThucHien.Size = new System.Drawing.Size(537, 143);
            this.grbThucHien.TabIndex = 8;
            this.grbThucHien.TabStop = false;
            this.grbThucHien.Text = "Thực hiện";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(284, 52);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 49);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(419, 52);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 49);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(146, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(10, 52);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(118, 49);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.cbTenHS);
            this.grbTTCT.Controls.Add(this.lblTenHS);
            this.grbTTCT.Controls.Add(this.txtQuanHe);
            this.grbTTCT.Controls.Add(this.txtSoDTPH);
            this.grbTTCT.Controls.Add(this.lblQuanHe);
            this.grbTTCT.Controls.Add(this.lblSoDTPH);
            this.grbTTCT.Controls.Add(this.dtpNgaySinhPH);
            this.grbTTCT.Controls.Add(this.cbGioiTinhPH);
            this.grbTTCT.Controls.Add(this.txtHoTenPH);
            this.grbTTCT.Controls.Add(this.txtDiaChiPH);
            this.grbTTCT.Controls.Add(this.txtMaSo);
            this.grbTTCT.Controls.Add(this.lblGioiTinhPH);
            this.grbTTCT.Controls.Add(this.lblNamSinhPH);
            this.grbTTCT.Controls.Add(this.lblDiaChiPH);
            this.grbTTCT.Controls.Add(this.lblHoTenPH);
            this.grbTTCT.Controls.Add(this.lblMaSo);
            this.grbTTCT.Location = new System.Drawing.Point(29, 86);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(535, 323);
            this.grbTTCT.TabIndex = 7;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // cbTenHS
            // 
            this.cbTenHS.FormattingEnabled = true;
            this.cbTenHS.Location = new System.Drawing.Point(299, 39);
            this.cbTenHS.Name = "cbTenHS";
            this.cbTenHS.Size = new System.Drawing.Size(198, 28);
            this.cbTenHS.TabIndex = 21;
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Location = new System.Drawing.Point(232, 42);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(67, 20);
            this.lblTenHS.TabIndex = 20;
            this.lblTenHS.Text = "Tên HS:";
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(361, 194);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(136, 26);
            this.txtQuanHe.TabIndex = 18;
            // 
            // txtSoDTPH
            // 
            this.txtSoDTPH.Location = new System.Drawing.Point(126, 194);
            this.txtSoDTPH.Name = "txtSoDTPH";
            this.txtSoDTPH.Size = new System.Drawing.Size(149, 26);
            this.txtSoDTPH.TabIndex = 19;
            // 
            // lblQuanHe
            // 
            this.lblQuanHe.AutoSize = true;
            this.lblQuanHe.Location = new System.Drawing.Point(281, 197);
            this.lblQuanHe.Name = "lblQuanHe";
            this.lblQuanHe.Size = new System.Drawing.Size(74, 20);
            this.lblQuanHe.TabIndex = 16;
            this.lblQuanHe.Text = "Quan hệ:";
            // 
            // lblSoDTPH
            // 
            this.lblSoDTPH.AutoSize = true;
            this.lblSoDTPH.Location = new System.Drawing.Point(11, 197);
            this.lblSoDTPH.Name = "lblSoDTPH";
            this.lblSoDTPH.Size = new System.Drawing.Size(110, 20);
            this.lblSoDTPH.TabIndex = 17;
            this.lblSoDTPH.Text = "Số điện thoại: ";
            // 
            // dtpNgaySinhPH
            // 
            this.dtpNgaySinhPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhPH.Location = new System.Drawing.Point(88, 141);
            this.dtpNgaySinhPH.Name = "dtpNgaySinhPH";
            this.dtpNgaySinhPH.Size = new System.Drawing.Size(187, 26);
            this.dtpNgaySinhPH.TabIndex = 15;
            // 
            // cbGioiTinhPH
            // 
            this.cbGioiTinhPH.FormattingEnabled = true;
            this.cbGioiTinhPH.Location = new System.Drawing.Point(361, 143);
            this.cbGioiTinhPH.Name = "cbGioiTinhPH";
            this.cbGioiTinhPH.Size = new System.Drawing.Size(136, 28);
            this.cbGioiTinhPH.TabIndex = 14;
            // 
            // txtHoTenPH
            // 
            this.txtHoTenPH.Location = new System.Drawing.Point(87, 91);
            this.txtHoTenPH.Name = "txtHoTenPH";
            this.txtHoTenPH.Size = new System.Drawing.Size(410, 26);
            this.txtHoTenPH.TabIndex = 13;
            // 
            // txtDiaChiPH
            // 
            this.txtDiaChiPH.Location = new System.Drawing.Point(88, 241);
            this.txtDiaChiPH.Multiline = true;
            this.txtDiaChiPH.Name = "txtDiaChiPH";
            this.txtDiaChiPH.Size = new System.Drawing.Size(409, 63);
            this.txtDiaChiPH.TabIndex = 10;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(88, 39);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(129, 26);
            this.txtMaSo.TabIndex = 8;
            // 
            // lblGioiTinhPH
            // 
            this.lblGioiTinhPH.AutoSize = true;
            this.lblGioiTinhPH.Location = new System.Drawing.Point(284, 146);
            this.lblGioiTinhPH.Name = "lblGioiTinhPH";
            this.lblGioiTinhPH.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinhPH.TabIndex = 7;
            this.lblGioiTinhPH.Text = "Giới tính:";
            // 
            // lblNamSinhPH
            // 
            this.lblNamSinhPH.AutoSize = true;
            this.lblNamSinhPH.Location = new System.Drawing.Point(11, 146);
            this.lblNamSinhPH.Name = "lblNamSinhPH";
            this.lblNamSinhPH.Size = new System.Drawing.Size(79, 20);
            this.lblNamSinhPH.TabIndex = 6;
            this.lblNamSinhPH.Text = "Năm sinh:";
            // 
            // lblDiaChiPH
            // 
            this.lblDiaChiPH.AutoSize = true;
            this.lblDiaChiPH.Location = new System.Drawing.Point(12, 244);
            this.lblDiaChiPH.Name = "lblDiaChiPH";
            this.lblDiaChiPH.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChiPH.TabIndex = 5;
            this.lblDiaChiPH.Text = "Địa chỉ:";
            // 
            // lblHoTenPH
            // 
            this.lblHoTenPH.AutoSize = true;
            this.lblHoTenPH.Location = new System.Drawing.Point(11, 94);
            this.lblHoTenPH.Name = "lblHoTenPH";
            this.lblHoTenPH.Size = new System.Drawing.Size(61, 20);
            this.lblHoTenPH.TabIndex = 1;
            this.lblHoTenPH.Text = "Họ tên:";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(11, 42);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(56, 20);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // lblThongTinPH
            // 
            this.lblThongTinPH.AutoSize = true;
            this.lblThongTinPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPH.Location = new System.Drawing.Point(21, 28);
            this.lblThongTinPH.Name = "lblThongTinPH";
            this.lblThongTinPH.Size = new System.Drawing.Size(467, 40);
            this.lblThongTinPH.TabIndex = 1;
            this.lblThongTinPH.Text = "THÔNG TIN PHỤ HUYNH ";
            // 
            // frmPhuHuynh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnPhuHuynh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhuHuynh";
            this.Text = "frmPhuHunh";
            this.pnPhuHuynh.ResumeLayout(false);
            this.pnPhuHuynh.PerformLayout();
            this.grbDanhSachPH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPH)).EndInit();
            this.grbThucHien.ResumeLayout(false);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPhuHuynh;
        private System.Windows.Forms.GroupBox grbDanhSachPH;
        private System.Windows.Forms.DataGridView dgvDanhSachPH;
        private System.Windows.Forms.GroupBox grbThucHien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.ComboBox cbTenHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.TextBox txtSoDTPH;
        private System.Windows.Forms.Label lblQuanHe;
        private System.Windows.Forms.Label lblSoDTPH;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhPH;
        private System.Windows.Forms.ComboBox cbGioiTinhPH;
        private System.Windows.Forms.TextBox txtHoTenPH;
        private System.Windows.Forms.TextBox txtDiaChiPH;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label lblGioiTinhPH;
        private System.Windows.Forms.Label lblNamSinhPH;
        private System.Windows.Forms.Label lblDiaChiPH;
        private System.Windows.Forms.Label lblHoTenPH;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblThongTinPH;
    }
}