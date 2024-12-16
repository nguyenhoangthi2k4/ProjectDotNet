namespace QuanLyHocSinh
{
    partial class frmQuanLyTN
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
            this.dtpNgayDongBHYT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDongHP = new System.Windows.Forms.DateTimePicker();
            this.cbTTBHYT = new System.Windows.Forms.ComboBox();
            this.cbTTHP = new System.Windows.Forms.ComboBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.lblHocPhi = new System.Windows.Forms.Label();
            this.lblTTHP = new System.Windows.Forms.Label();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.lblTTBHYT = new System.Windows.Forms.Label();
            this.dgvDanhSachTN = new System.Windows.Forms.DataGridView();
            this.lblThuNgan = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cbMaNH = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayDongBHYT
            // 
            this.dtpNgayDongBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayDongBHYT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDongBHYT.Location = new System.Drawing.Point(982, 148);
            this.dtpNgayDongBHYT.Name = "dtpNgayDongBHYT";
            this.dtpNgayDongBHYT.Size = new System.Drawing.Size(175, 30);
            this.dtpNgayDongBHYT.TabIndex = 8;
            // 
            // dtpNgayDongHP
            // 
            this.dtpNgayDongHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayDongHP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDongHP.Location = new System.Drawing.Point(982, 109);
            this.dtpNgayDongHP.Name = "dtpNgayDongHP";
            this.dtpNgayDongHP.Size = new System.Drawing.Size(175, 30);
            this.dtpNgayDongHP.TabIndex = 7;
            // 
            // cbTTBHYT
            // 
            this.cbTTBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTTBHYT.FormattingEnabled = true;
            this.cbTTBHYT.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.cbTTBHYT.Location = new System.Drawing.Point(739, 148);
            this.cbTTBHYT.Name = "cbTTBHYT";
            this.cbTTBHYT.Size = new System.Drawing.Size(200, 33);
            this.cbTTBHYT.TabIndex = 6;
            // 
            // cbTTHP
            // 
            this.cbTTHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTTHP.FormattingEnabled = true;
            this.cbTTHP.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.cbTTHP.Location = new System.Drawing.Point(739, 106);
            this.cbTTHP.Name = "cbTTHP";
            this.cbTTHP.Size = new System.Drawing.Size(200, 33);
            this.cbTTHP.TabIndex = 5;
            // 
            // txtBHYT
            // 
            this.txtBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBHYT.Location = new System.Drawing.Point(442, 151);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(168, 30);
            this.txtBHYT.TabIndex = 4;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHocPhi.Location = new System.Drawing.Point(442, 111);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(168, 30);
            this.txtHocPhi.TabIndex = 3;
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.AutoSize = true;
            this.lblHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHocPhi.Location = new System.Drawing.Point(355, 115);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(84, 25);
            this.lblHocPhi.TabIndex = 34;
            this.lblHocPhi.Text = "Học phí:";
            // 
            // lblTTHP
            // 
            this.lblTTHP.AutoSize = true;
            this.lblTTHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTTHP.Location = new System.Drawing.Point(627, 115);
            this.lblTTHP.Name = "lblTTHP";
            this.lblTTHP.Size = new System.Drawing.Size(106, 25);
            this.lblTTHP.TabIndex = 27;
            this.lblTTHP.Text = "Tình trạng:";
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBHYT.Location = new System.Drawing.Point(355, 153);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(71, 25);
            this.lblBHYT.TabIndex = 28;
            this.lblBHYT.Text = "BHYT:";
            // 
            // lblTTBHYT
            // 
            this.lblTTBHYT.AutoSize = true;
            this.lblTTBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTTBHYT.Location = new System.Drawing.Point(627, 155);
            this.lblTTBHYT.Name = "lblTTBHYT";
            this.lblTTBHYT.Size = new System.Drawing.Size(106, 25);
            this.lblTTBHYT.TabIndex = 29;
            this.lblTTBHYT.Text = "Tình trạng:";
            // 
            // dgvDanhSachTN
            // 
            this.dgvDanhSachTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTN.Location = new System.Drawing.Point(1, 69);
            this.dgvDanhSachTN.MultiSelect = false;
            this.dgvDanhSachTN.Name = "dgvDanhSachTN";
            this.dgvDanhSachTN.ReadOnly = true;
            this.dgvDanhSachTN.RowHeadersWidth = 62;
            this.dgvDanhSachTN.RowTemplate.Height = 28;
            this.dgvDanhSachTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachTN.Size = new System.Drawing.Size(1174, 327);
            this.dgvDanhSachTN.TabIndex = 50;
            this.dgvDanhSachTN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTN_CellContentClick);
            // 
            // lblThuNgan
            // 
            this.lblThuNgan.AutoSize = true;
            this.lblThuNgan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgan.Location = new System.Drawing.Point(28, 48);
            this.lblThuNgan.Name = "lblThuNgan";
            this.lblThuNgan.Size = new System.Drawing.Size(357, 40);
            this.lblThuNgan.TabIndex = 25;
            this.lblThuNgan.Text = "Danh sách thu ngân";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaSo.Location = new System.Drawing.Point(29, 114);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(79, 25);
            this.lblMaSo.TabIndex = 26;
            this.lblMaSo.Text = "Mã HS:";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaSo.Location = new System.Drawing.Point(105, 112);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(224, 30);
            this.txtMaSo.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = global::QuanLyHocSinh.Properties.Resources.diskette;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(1090, 564);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 46);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = global::QuanLyHocSinh.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(936, 564);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 46);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(292, 564);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(148, 46);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(48, 570);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(231, 30);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.Color.White;
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Image = global::QuanLyHocSinh.Properties.Resources.account_maintenance;
            this.btnThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThayDoi.Location = new System.Drawing.Point(782, 564);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(148, 46);
            this.btnThayDoi.TabIndex = 9;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvDanhSachTN);
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Controls.Add(this.lblHocKy);
            this.panel1.Controls.Add(this.cbMaNH);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.lblMaNH);
            this.panel1.Location = new System.Drawing.Point(36, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 327);
            this.panel1.TabIndex = 0;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(368, 19);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(129, 33);
            this.cbHocKy.TabIndex = 2;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHocKy.Location = new System.Drawing.Point(280, 22);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(82, 25);
            this.lblHocKy.TabIndex = 27;
            this.lblHocKy.Text = "Học Kỳ:";
            // 
            // cbMaNH
            // 
            this.cbMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaNH.FormattingEnabled = true;
            this.cbMaNH.Location = new System.Drawing.Point(132, 19);
            this.cbMaNH.Name = "cbMaNH";
            this.cbMaNH.Size = new System.Drawing.Size(129, 33);
            this.cbMaNH.TabIndex = 0;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.White;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(579, 18);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(118, 37);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaNH.Location = new System.Drawing.Point(4, 22);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(132, 25);
            this.lblMaNH.TabIndex = 27;
            this.lblMaNH.Text = "Mã Năm Học:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(105, 150);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(224, 30);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoTen.Location = new System.Drawing.Point(29, 153);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 25);
            this.lblHoTen.TabIndex = 52;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // frmQuanLyTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1265, 644);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dtpNgayDongBHYT);
            this.Controls.Add(this.dtpNgayDongHP);
            this.Controls.Add(this.cbTTBHYT);
            this.Controls.Add(this.cbTTHP);
            this.Controls.Add(this.txtBHYT);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.lblHocPhi);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.lblTTHP);
            this.Controls.Add(this.lblBHYT);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.lblTTBHYT);
            this.Controls.Add(this.lblThuNgan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTN";
            this.Text = "frmThuNgan";
            this.Click += new System.EventHandler(this.frmQuanLyTN_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayDongBHYT;
        private System.Windows.Forms.DateTimePicker dtpNgayDongHP;
        private System.Windows.Forms.ComboBox cbTTBHYT;
        private System.Windows.Forms.ComboBox cbTTHP;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label lblHocPhi;
        private System.Windows.Forms.Label lblTTHP;
        private System.Windows.Forms.Label lblBHYT;
        private System.Windows.Forms.Label lblTTBHYT;
        private System.Windows.Forms.DataGridView dgvDanhSachTN;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaNH;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}