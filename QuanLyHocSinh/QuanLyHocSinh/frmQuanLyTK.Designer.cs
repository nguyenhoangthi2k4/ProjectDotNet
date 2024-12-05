namespace QuanLyHocSinh
{
    partial class frmQuanLyTK
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
            this.pnQLTK = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblQLTK = new System.Windows.Forms.Label();
            this.pnQLTK.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbTTCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnQLTK
            // 
            this.pnQLTK.Controls.Add(this.groupBox2);
            this.pnQLTK.Controls.Add(this.btnLuu);
            this.pnQLTK.Controls.Add(this.btnHuy);
            this.pnQLTK.Controls.Add(this.grbTTCT);
            this.pnQLTK.Controls.Add(this.btnSua);
            this.pnQLTK.Controls.Add(this.lblQLTK);
            this.pnQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnQLTK.Location = new System.Drawing.Point(0, 0);
            this.pnQLTK.Name = "pnQLTK";
            this.pnQLTK.Size = new System.Drawing.Size(1475, 600);
            this.pnQLTK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(419, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 504);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1038, 479);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(288, 423);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 45);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(155, 423);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 45);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.cbQuyen);
            this.grbTTCT.Controls.Add(this.txtMatKhau);
            this.grbTTCT.Controls.Add(this.txtTenDN);
            this.grbTTCT.Controls.Add(this.txtMaSo);
            this.grbTTCT.Controls.Add(this.lblQuyen);
            this.grbTTCT.Controls.Add(this.lblTenDN);
            this.grbTTCT.Controls.Add(this.lblMatKhau);
            this.grbTTCT.Controls.Add(this.lblMaSo);
            this.grbTTCT.Location = new System.Drawing.Point(25, 84);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(367, 311);
            this.grbTTCT.TabIndex = 1;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin";
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Location = new System.Drawing.Point(146, 210);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(200, 28);
            this.cbQuyen.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(146, 167);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 26);
            this.txtMatKhau.TabIndex = 4;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(146, 118);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(200, 26);
            this.txtTenDN.TabIndex = 4;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(146, 72);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(200, 26);
            this.txtMaSo.TabIndex = 4;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(17, 213);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(59, 20);
            this.lblQuyen.TabIndex = 3;
            this.lblQuyen.Text = "Quyền:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(17, 121);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(123, 20);
            this.lblTenDN.TabIndex = 1;
            this.lblTenDN.Text = "Tên Đăng nhập:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(17, 167);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(79, 20);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(17, 75);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(56, 20);
            this.lblMaSo.TabIndex = 1;
            this.lblMaSo.Text = "Mã số:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(25, 423);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblQLTK
            // 
            this.lblQLTK.AutoSize = true;
            this.lblQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTK.Location = new System.Drawing.Point(21, 28);
            this.lblQLTK.Name = "lblQLTK";
            this.lblQLTK.Size = new System.Drawing.Size(394, 40);
            this.lblQLTK.TabIndex = 0;
            this.lblQLTK.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // frmQuanLyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnQLTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTK";
            this.Text = "frmQuanLyTaiKhoan";
            this.pnQLTK.ResumeLayout(false);
            this.pnQLTK.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnQLTK;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblQLTK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbQuyen;
    }
}