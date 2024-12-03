namespace QuanLyHocSinh
{
    partial class frmQuanLyGV
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.cbToGV = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbTruongTo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtMonGD = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.lblMonGD = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblToGV = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnCha = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbToGV = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachToGV = new System.Windows.Forms.DataGridView();
            this.lblTruongTo = new System.Windows.Forms.Label();
            this.lblPCToGV = new System.Windows.Forms.Label();
            this.lblMaTo = new System.Windows.Forms.Label();
            this.lblTenTo = new System.Windows.Forms.Label();
            this.txtTenTo = new System.Windows.Forms.TextBox();
            this.txtMaToGV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDanhSachGV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnCha.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbToGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(629, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 46);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(321, 91);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(150, 26);
            this.txtMatKhau.TabIndex = 20;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(99, 91);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(139, 26);
            this.txtTenDN.TabIndex = 19;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(244, 94);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(79, 20);
            this.lblMatKhau.TabIndex = 18;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(14, 94);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(67, 20);
            this.lblTenDN.TabIndex = 17;
            this.lblTenDN.Text = "Tên ĐN:";
            // 
            // cbToGV
            // 
            this.cbToGV.FormattingEnabled = true;
            this.cbToGV.Location = new System.Drawing.Point(309, 55);
            this.cbToGV.Name = "cbToGV";
            this.cbToGV.Size = new System.Drawing.Size(162, 28);
            this.cbToGV.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(1295, 53);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(145, 26);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // cbTruongTo
            // 
            this.cbTruongTo.FormattingEnabled = true;
            this.cbTruongTo.Location = new System.Drawing.Point(718, 68);
            this.cbTruongTo.Name = "cbTruongTo";
            this.cbTruongTo.Size = new System.Drawing.Size(228, 28);
            this.cbTruongTo.TabIndex = 14;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(544, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(164, 26);
            this.txtHoTen.TabIndex = 13;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(1072, 55);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(139, 26);
            this.txtSoDT.TabIndex = 11;
            // 
            // txtMonGD
            // 
            this.txtMonGD.Location = new System.Drawing.Point(793, 55);
            this.txtMonGD.Name = "txtMonGD";
            this.txtMonGD.Size = new System.Drawing.Size(162, 26);
            this.txtMonGD.TabIndex = 8;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(99, 55);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(139, 26);
            this.txtMaSo.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(477, 94);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(1217, 58);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.txtNgaySinh.TabIndex = 6;
            this.txtNgaySinh.Text = "Ngày sinh:";
            // 
            // lblMonGD
            // 
            this.lblMonGD.AutoSize = true;
            this.lblMonGD.Location = new System.Drawing.Point(714, 58);
            this.lblMonGD.Name = "lblMonGD";
            this.lblMonGD.Size = new System.Drawing.Size(73, 20);
            this.lblMonGD.TabIndex = 0;
            this.lblMonGD.Text = "Môn GD:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(961, 58);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(110, 20);
            this.lblSoDT.TabIndex = 4;
            this.lblSoDT.Text = "Số điện thoại: ";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(14, 58);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(56, 20);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(477, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblToGV
            // 
            this.lblToGV.AutoSize = true;
            this.lblToGV.Location = new System.Drawing.Point(244, 58);
            this.lblToGV.Name = "lblToGV";
            this.lblToGV.Size = new System.Drawing.Size(59, 20);
            this.lblToGV.TabIndex = 0;
            this.lblToGV.Text = "Tổ GV:";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 490);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1434, 442);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 59);
            this.panel1.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(321, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(475, 8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 46);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(12, 8);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(148, 46);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(167, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 46);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnCha
            // 
            this.pnCha.AutoScroll = true;
            this.pnCha.BackColor = System.Drawing.Color.Azure;
            this.pnCha.Controls.Add(this.panel4);
            this.pnCha.Controls.Add(this.dgvDanhSach);
            this.pnCha.Controls.Add(this.panel3);
            this.pnCha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCha.Location = new System.Drawing.Point(0, 59);
            this.pnCha.Name = "pnCha";
            this.pnCha.Size = new System.Drawing.Size(1475, 541);
            this.pnCha.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbToGV);
            this.panel4.Controls.Add(this.lblTruongTo);
            this.panel4.Controls.Add(this.lblPCToGV);
            this.panel4.Controls.Add(this.lblMaTo);
            this.panel4.Controls.Add(this.lblTenTo);
            this.panel4.Controls.Add(this.txtTenTo);
            this.panel4.Controls.Add(this.cbTruongTo);
            this.panel4.Controls.Add(this.txtMaToGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1449, 337);
            this.panel4.TabIndex = 13;
            // 
            // grbToGV
            // 
            this.grbToGV.Controls.Add(this.dgvDanhSachToGV);
            this.grbToGV.Location = new System.Drawing.Point(3, 111);
            this.grbToGV.Name = "grbToGV";
            this.grbToGV.Size = new System.Drawing.Size(1446, 223);
            this.grbToGV.TabIndex = 15;
            this.grbToGV.TabStop = false;
            this.grbToGV.Text = "Danh sách Tổ GV";
            // 
            // dgvDanhSachToGV
            // 
            this.dgvDanhSachToGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachToGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachToGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachToGV.Location = new System.Drawing.Point(9, 22);
            this.dgvDanhSachToGV.Name = "dgvDanhSachToGV";
            this.dgvDanhSachToGV.ReadOnly = true;
            this.dgvDanhSachToGV.RowHeadersWidth = 62;
            this.dgvDanhSachToGV.RowTemplate.Height = 28;
            this.dgvDanhSachToGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachToGV.Size = new System.Drawing.Size(1431, 195);
            this.dgvDanhSachToGV.TabIndex = 0;
            // 
            // lblTruongTo
            // 
            this.lblTruongTo.AutoSize = true;
            this.lblTruongTo.Location = new System.Drawing.Point(631, 71);
            this.lblTruongTo.Name = "lblTruongTo";
            this.lblTruongTo.Size = new System.Drawing.Size(81, 20);
            this.lblTruongTo.TabIndex = 1;
            this.lblTruongTo.Text = "Trưởng tổ:";
            // 
            // lblPCToGV
            // 
            this.lblPCToGV.AutoSize = true;
            this.lblPCToGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCToGV.Location = new System.Drawing.Point(14, 14);
            this.lblPCToGV.Name = "lblPCToGV";
            this.lblPCToGV.Size = new System.Drawing.Size(376, 37);
            this.lblPCToGV.TabIndex = 0;
            this.lblPCToGV.Text = "Phân công Tổ giáo viên";
            // 
            // lblMaTo
            // 
            this.lblMaTo.AutoSize = true;
            this.lblMaTo.Location = new System.Drawing.Point(14, 71);
            this.lblMaTo.Name = "lblMaTo";
            this.lblMaTo.Size = new System.Drawing.Size(53, 20);
            this.lblMaTo.TabIndex = 0;
            this.lblMaTo.Text = "Mã tổ:";
            // 
            // lblTenTo
            // 
            this.lblTenTo.AutoSize = true;
            this.lblTenTo.Location = new System.Drawing.Point(334, 73);
            this.lblTenTo.Name = "lblTenTo";
            this.lblTenTo.Size = new System.Drawing.Size(58, 20);
            this.lblTenTo.TabIndex = 0;
            this.lblTenTo.Text = "Tên tổ:";
            // 
            // txtTenTo
            // 
            this.txtTenTo.Location = new System.Drawing.Point(398, 70);
            this.txtTenTo.Name = "txtTenTo";
            this.txtTenTo.Size = new System.Drawing.Size(184, 26);
            this.txtTenTo.TabIndex = 8;
            // 
            // txtMaToGV
            // 
            this.txtMaToGV.Location = new System.Drawing.Point(73, 68);
            this.txtMaToGV.Name = "txtMaToGV";
            this.txtMaToGV.Size = new System.Drawing.Size(184, 26);
            this.txtMaToGV.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.lblDanhSachGV);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.lblDiaChi);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.txtSoDT);
            this.panel3.Controls.Add(this.cbGioiTinh);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.lblSoDT);
            this.panel3.Controls.Add(this.txtNgaySinh);
            this.panel3.Controls.Add(this.lblMatKhau);
            this.panel3.Controls.Add(this.txtMonGD);
            this.panel3.Controls.Add(this.txtMaSo);
            this.panel3.Controls.Add(this.txtTenDN);
            this.panel3.Controls.Add(this.lblMonGD);
            this.panel3.Controls.Add(this.lblGioiTinh);
            this.panel3.Controls.Add(this.lblToGV);
            this.panel3.Controls.Add(this.lblTenDN);
            this.panel3.Controls.Add(this.lblMaSo);
            this.panel3.Controls.Add(this.cbToGV);
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(this.lblHoTen);
            this.panel3.Location = new System.Drawing.Point(3, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1443, 141);
            this.panel3.TabIndex = 12;
            // 
            // lblDanhSachGV
            // 
            this.lblDanhSachGV.AutoSize = true;
            this.lblDanhSachGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachGV.Location = new System.Drawing.Point(9, 3);
            this.lblDanhSachGV.Name = "lblDanhSachGV";
            this.lblDanhSachGV.Size = new System.Drawing.Size(333, 37);
            this.lblDanhSachGV.TabIndex = 21;
            this.lblDanhSachGV.Text = "Danh sách Giáo viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(793, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(329, 26);
            this.txtDiaChi.TabIndex = 14;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(716, 97);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1186, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(1128, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(544, 91);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(164, 28);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // frmQuanLyGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnCha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyGV";
            this.Text = "frmQLGV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnCha.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grbToGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachToGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbToGV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbTruongTo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtMonGD;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.Label lblMonGD;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToGV;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnCha;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTruongTo;
        private System.Windows.Forms.Label lblPCToGV;
        private System.Windows.Forms.Label lblMaTo;
        private System.Windows.Forms.Label lblTenTo;
        private System.Windows.Forms.TextBox txtTenTo;
        private System.Windows.Forms.TextBox txtMaToGV;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.GroupBox grbToGV;
        private System.Windows.Forms.DataGridView dgvDanhSachToGV;
        private System.Windows.Forms.Label lblDanhSachGV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
    }
}