namespace QuanLyHocSinh
{
    partial class frmQuanLyNH
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
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachNH = new System.Windows.Forms.DataGridView();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.cbGVCN = new System.Windows.Forms.ComboBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaNHLH = new System.Windows.Forms.Label();
            this.pnNamHoc = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhanCongLopHoc = new System.Windows.Forms.Label();
            this.cbMaNH = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPhanConNamHoc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.pnNamHoc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(369, 89);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(151, 28);
            this.cbHocKy.TabIndex = 3;
            // 
            // dgvDanhSachNH
            // 
            this.dgvDanhSachNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNH.Location = new System.Drawing.Point(12, 123);
            this.dgvDanhSachNH.Name = "dgvDanhSachNH";
            this.dgvDanhSachNH.ReadOnly = true;
            this.dgvDanhSachNH.RowHeadersWidth = 62;
            this.dgvDanhSachNH.RowTemplate.Height = 28;
            this.dgvDanhSachNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNH.Size = new System.Drawing.Size(761, 205);
            this.dgvDanhSachNH.TabIndex = 4;
            this.dgvDanhSachNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNH_CellContentClick);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(116, 88);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(129, 26);
            this.txtNamHoc.TabIndex = 0;
            this.txtNamHoc.TextChanged += new System.EventHandler(this.txtNamHoc_TextChanged);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(302, 92);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(61, 20);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Location = new System.Drawing.Point(8, 91);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(102, 20);
            this.lblMaNH.TabIndex = 1;
            this.lblMaNH.Text = "Mã Năm học:";
            // 
            // cbGVCN
            // 
            this.cbGVCN.FormattingEnabled = true;
            this.cbGVCN.Location = new System.Drawing.Point(996, 83);
            this.cbGVCN.Name = "cbGVCN";
            this.cbGVCN.Size = new System.Drawing.Size(207, 28);
            this.cbGVCN.TabIndex = 3;
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(12, 128);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.RowHeadersWidth = 62;
            this.dgvLopHoc.RowTemplate.Height = 28;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(1428, 388);
            this.dgvLopHoc.TabIndex = 8;
            this.dgvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellContentClick);
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(928, 86);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(59, 20);
            this.lblGVCN.TabIndex = 2;
            this.lblGVCN.Text = "GVCN:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(331, 86);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(66, 20);
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(399, 83);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(183, 26);
            this.txtMaLop.TabIndex = 1;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(689, 83);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(183, 26);
            this.txtTenLop.TabIndex = 2;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(621, 86);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(65, 20);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // lblMaNHLH
            // 
            this.lblMaNHLH.AutoSize = true;
            this.lblMaNHLH.Location = new System.Drawing.Point(12, 86);
            this.lblMaNHLH.Name = "lblMaNHLH";
            this.lblMaNHLH.Size = new System.Drawing.Size(102, 20);
            this.lblMaNHLH.TabIndex = 1;
            this.lblMaNHLH.Text = "Mã Năm học:";
            // 
            // pnNamHoc
            // 
            this.pnNamHoc.Controls.Add(this.panel2);
            this.pnNamHoc.Controls.Add(this.panel1);
            this.pnNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNamHoc.Location = new System.Drawing.Point(0, 0);
            this.pnNamHoc.Name = "pnNamHoc";
            this.pnNamHoc.Size = new System.Drawing.Size(1475, 600);
            this.pnNamHoc.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 541);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPhanCongLopHoc);
            this.panel3.Controls.Add(this.cbMaNH);
            this.panel3.Controls.Add(this.dgvLopHoc);
            this.panel3.Controls.Add(this.cbGVCN);
            this.panel3.Controls.Add(this.txtMaLop);
            this.panel3.Controls.Add(this.lblMaNHLH);
            this.panel3.Controls.Add(this.lblTenLop);
            this.panel3.Controls.Add(this.txtTenLop);
            this.panel3.Controls.Add(this.lblMaLop);
            this.panel3.Controls.Add(this.lblGVCN);
            this.panel3.Location = new System.Drawing.Point(0, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1443, 519);
            this.panel3.TabIndex = 5;
            // 
            // lblPhanCongLopHoc
            // 
            this.lblPhanCongLopHoc.AutoSize = true;
            this.lblPhanCongLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCongLopHoc.Location = new System.Drawing.Point(9, 18);
            this.lblPhanCongLopHoc.Name = "lblPhanCongLopHoc";
            this.lblPhanCongLopHoc.Size = new System.Drawing.Size(344, 40);
            this.lblPhanCongLopHoc.TabIndex = 9;
            this.lblPhanCongLopHoc.Text = "Phân công Lớp học";
            // 
            // cbMaNH
            // 
            this.cbMaNH.FormattingEnabled = true;
            this.cbMaNH.Location = new System.Drawing.Point(116, 83);
            this.cbMaNH.Name = "cbMaNH";
            this.cbMaNH.Size = new System.Drawing.Size(151, 28);
            this.cbMaNH.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPhanConNamHoc);
            this.panel4.Controls.Add(this.cbHocKy);
            this.panel4.Controls.Add(this.txtNamHoc);
            this.panel4.Controls.Add(this.lblHocKy);
            this.panel4.Controls.Add(this.dgvDanhSachNH);
            this.panel4.Controls.Add(this.lblMaNH);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1443, 337);
            this.panel4.TabIndex = 4;
            // 
            // lblPhanConNamHoc
            // 
            this.lblPhanConNamHoc.AutoSize = true;
            this.lblPhanConNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanConNamHoc.Location = new System.Drawing.Point(9, 19);
            this.lblPhanConNamHoc.Name = "lblPhanConNamHoc";
            this.lblPhanConNamHoc.Size = new System.Drawing.Size(360, 40);
            this.lblPhanConNamHoc.TabIndex = 5;
            this.lblPhanConNamHoc.Text = "Phân công Năm học";
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
            this.panel1.TabIndex = 14;
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            // frmQuanLyNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnNamHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNH";
            this.Text = "frmQuanLyNH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.pnNamHoc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnNamHoc;
        private System.Windows.Forms.DataGridView dgvDanhSachNH;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaNHLH;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cbGVCN;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPhanConNamHoc;
        private System.Windows.Forms.Label lblPhanCongLopHoc;
        private System.Windows.Forms.ComboBox cbMaNH;
    }
}