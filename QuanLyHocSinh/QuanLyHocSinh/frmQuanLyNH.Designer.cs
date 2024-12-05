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
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.grbNamHoc = new System.Windows.Forms.GroupBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachNH = new System.Windows.Forms.DataGridView();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.btnThemNH = new System.Windows.Forms.Button();
            this.btnLuuNH = new System.Windows.Forms.Button();
            this.grbLopHoc = new System.Windows.Forms.GroupBox();
            this.cbGVCN = new System.Windows.Forms.ComboBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.txtMaHNLH = new System.Windows.Forms.TextBox();
            this.btnLuuLH = new System.Windows.Forms.Button();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.btnHuyLH = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btnSuaLH = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaNHLH = new System.Windows.Forms.Label();
            this.pnNamHoc = new System.Windows.Forms.Panel();
            this.grbNamHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).BeginInit();
            this.grbLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.pnNamHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(21, 28);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(194, 40);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "NĂM HỌC";
            // 
            // grbNamHoc
            // 
            this.grbNamHoc.Controls.Add(this.cbHocKy);
            this.grbNamHoc.Controls.Add(this.dgvDanhSachNH);
            this.grbNamHoc.Controls.Add(this.txtNamHoc);
            this.grbNamHoc.Controls.Add(this.lblHocKy);
            this.grbNamHoc.Controls.Add(this.lblMaNH);
            this.grbNamHoc.Controls.Add(this.btnThemNH);
            this.grbNamHoc.Controls.Add(this.btnLuuNH);
            this.grbNamHoc.Location = new System.Drawing.Point(28, 89);
            this.grbNamHoc.Name = "grbNamHoc";
            this.grbNamHoc.Size = new System.Drawing.Size(432, 482);
            this.grbNamHoc.TabIndex = 1;
            this.grbNamHoc.TabStop = false;
            this.grbNamHoc.Text = "Năm học";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(101, 100);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(151, 28);
            this.cbHocKy.TabIndex = 3;
            // 
            // dgvDanhSachNH
            // 
            this.dgvDanhSachNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNH.Location = new System.Drawing.Point(6, 172);
            this.dgvDanhSachNH.Name = "dgvDanhSachNH";
            this.dgvDanhSachNH.ReadOnly = true;
            this.dgvDanhSachNH.RowHeadersWidth = 62;
            this.dgvDanhSachNH.RowTemplate.Height = 28;
            this.dgvDanhSachNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNH.Size = new System.Drawing.Size(420, 304);
            this.dgvDanhSachNH.TabIndex = 4;
            this.dgvDanhSachNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNH_CellContentClick);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(101, 47);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(151, 26);
            this.txtNamHoc.TabIndex = 0;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(23, 103);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(61, 20);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Location = new System.Drawing.Point(23, 50);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(62, 20);
            this.lblMaNH.TabIndex = 1;
            this.lblMaNH.Text = "Mã NH:";
            // 
            // btnThemNH
            // 
            this.btnThemNH.Location = new System.Drawing.Point(273, 44);
            this.btnThemNH.Name = "btnThemNH";
            this.btnThemNH.Size = new System.Drawing.Size(136, 33);
            this.btnThemNH.TabIndex = 4;
            this.btnThemNH.Text = "Thêm";
            this.btnThemNH.UseVisualStyleBackColor = true;
            this.btnThemNH.Click += new System.EventHandler(this.btnThemNH_Click);
            // 
            // btnLuuNH
            // 
            this.btnLuuNH.Location = new System.Drawing.Point(273, 97);
            this.btnLuuNH.Name = "btnLuuNH";
            this.btnLuuNH.Size = new System.Drawing.Size(136, 33);
            this.btnLuuNH.TabIndex = 5;
            this.btnLuuNH.Text = "Lưu";
            this.btnLuuNH.UseVisualStyleBackColor = true;
            this.btnLuuNH.Click += new System.EventHandler(this.btnLuuNH_Click);
            // 
            // grbLopHoc
            // 
            this.grbLopHoc.Controls.Add(this.cbGVCN);
            this.grbLopHoc.Controls.Add(this.dgvLopHoc);
            this.grbLopHoc.Controls.Add(this.txtMaHNLH);
            this.grbLopHoc.Controls.Add(this.btnLuuLH);
            this.grbLopHoc.Controls.Add(this.btnThemLH);
            this.grbLopHoc.Controls.Add(this.lblGVCN);
            this.grbLopHoc.Controls.Add(this.btnHuyLH);
            this.grbLopHoc.Controls.Add(this.lblMaLop);
            this.grbLopHoc.Controls.Add(this.btnSuaLH);
            this.grbLopHoc.Controls.Add(this.txtMaLop);
            this.grbLopHoc.Controls.Add(this.txtTenLop);
            this.grbLopHoc.Controls.Add(this.lblTenLop);
            this.grbLopHoc.Controls.Add(this.lblMaNHLH);
            this.grbLopHoc.Location = new System.Drawing.Point(499, 89);
            this.grbLopHoc.Name = "grbLopHoc";
            this.grbLopHoc.Size = new System.Drawing.Size(946, 482);
            this.grbLopHoc.TabIndex = 2;
            this.grbLopHoc.TabStop = false;
            this.grbLopHoc.Text = "Lớp học";
            // 
            // cbGVCN
            // 
            this.cbGVCN.FormattingEnabled = true;
            this.cbGVCN.Location = new System.Drawing.Point(403, 100);
            this.cbGVCN.Name = "cbGVCN";
            this.cbGVCN.Size = new System.Drawing.Size(183, 28);
            this.cbGVCN.TabIndex = 3;
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(6, 172);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.RowHeadersWidth = 62;
            this.dgvLopHoc.RowTemplate.Height = 28;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(934, 304);
            this.dgvLopHoc.TabIndex = 8;
            // 
            // txtMaHNLH
            // 
            this.txtMaHNLH.Location = new System.Drawing.Point(96, 47);
            this.txtMaHNLH.Name = "txtMaHNLH";
            this.txtMaHNLH.Size = new System.Drawing.Size(183, 26);
            this.txtMaHNLH.TabIndex = 0;
            // 
            // btnLuuLH
            // 
            this.btnLuuLH.Location = new System.Drawing.Point(806, 100);
            this.btnLuuLH.Name = "btnLuuLH";
            this.btnLuuLH.Size = new System.Drawing.Size(97, 30);
            this.btnLuuLH.TabIndex = 7;
            this.btnLuuLH.Text = "Lưu";
            this.btnLuuLH.UseVisualStyleBackColor = true;
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(688, 31);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(97, 30);
            this.btnThemLH.TabIndex = 4;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = true;
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(335, 103);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(59, 20);
            this.lblGVCN.TabIndex = 2;
            this.lblGVCN.Text = "GVCN:";
            // 
            // btnHuyLH
            // 
            this.btnHuyLH.Location = new System.Drawing.Point(806, 31);
            this.btnHuyLH.Name = "btnHuyLH";
            this.btnHuyLH.Size = new System.Drawing.Size(97, 30);
            this.btnHuyLH.TabIndex = 6;
            this.btnHuyLH.Text = "Hủy";
            this.btnHuyLH.UseVisualStyleBackColor = true;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(335, 50);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(66, 20);
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // btnSuaLH
            // 
            this.btnSuaLH.Location = new System.Drawing.Point(688, 100);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(97, 30);
            this.btnSuaLH.TabIndex = 5;
            this.btnSuaLH.Text = "Sửa";
            this.btnSuaLH.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(403, 47);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(183, 26);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(96, 100);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(183, 26);
            this.txtTenLop.TabIndex = 2;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(28, 103);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(65, 20);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // lblMaNHLH
            // 
            this.lblMaNHLH.AutoSize = true;
            this.lblMaNHLH.Location = new System.Drawing.Point(28, 53);
            this.lblMaNHLH.Name = "lblMaNHLH";
            this.lblMaNHLH.Size = new System.Drawing.Size(62, 20);
            this.lblMaNHLH.TabIndex = 1;
            this.lblMaNHLH.Text = "Mã NH:";
            // 
            // pnNamHoc
            // 
            this.pnNamHoc.Controls.Add(this.lblNamHoc);
            this.pnNamHoc.Controls.Add(this.grbLopHoc);
            this.pnNamHoc.Controls.Add(this.grbNamHoc);
            this.pnNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNamHoc.Location = new System.Drawing.Point(0, 0);
            this.pnNamHoc.Name = "pnNamHoc";
            this.pnNamHoc.Size = new System.Drawing.Size(1475, 600);
            this.pnNamHoc.TabIndex = 3;
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
            this.grbNamHoc.ResumeLayout(false);
            this.grbNamHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).EndInit();
            this.grbLopHoc.ResumeLayout(false);
            this.grbLopHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.pnNamHoc.ResumeLayout(false);
            this.pnNamHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.GroupBox grbNamHoc;
        private System.Windows.Forms.GroupBox grbLopHoc;
        private System.Windows.Forms.Panel pnNamHoc;
        private System.Windows.Forms.DataGridView dgvDanhSachNH;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.Button btnThemNH;
        private System.Windows.Forms.Button btnLuuNH;
        private System.Windows.Forms.TextBox txtMaHNLH;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaNHLH;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnLuuLH;
        private System.Windows.Forms.Button btnSuaLH;
        private System.Windows.Forms.Button btnHuyLH;
        private System.Windows.Forms.ComboBox cbGVCN;
        private System.Windows.Forms.ComboBox cbHocKy;
    }
}