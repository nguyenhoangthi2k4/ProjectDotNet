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
            this.pnDanhGia = new System.Windows.Forms.Panel();
            this.lblDanhGiaHK = new System.Windows.Forms.Label();
            this.grbThucHien = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btbThucHien = new System.Windows.Forms.Button();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.cbLoaiHK = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLoaiHK = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnDanhGia.SuspendLayout();
            this.grbThucHien.SuspendLayout();
            this.grbTTCT.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDanhGia
            // 
            this.pnDanhGia.Controls.Add(this.lblDanhGiaHK);
            this.pnDanhGia.Controls.Add(this.grbThucHien);
            this.pnDanhGia.Controls.Add(this.grbTTCT);
            this.pnDanhGia.Controls.Add(this.grbDanhSach);
            this.pnDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhGia.Location = new System.Drawing.Point(0, 0);
            this.pnDanhGia.Name = "pnDanhGia";
            this.pnDanhGia.Size = new System.Drawing.Size(1475, 600);
            this.pnDanhGia.TabIndex = 10;
            // 
            // lblDanhGiaHK
            // 
            this.lblDanhGiaHK.AutoSize = true;
            this.lblDanhGiaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGiaHK.Location = new System.Drawing.Point(24, 28);
            this.lblDanhGiaHK.Name = "lblDanhGiaHK";
            this.lblDanhGiaHK.Size = new System.Drawing.Size(417, 40);
            this.lblDanhGiaHK.TabIndex = 11;
            this.lblDanhGiaHK.Text = "ĐÁNH GIÁ HẠNH KIỂM";
            // 
            // grbThucHien
            // 
            this.grbThucHien.Controls.Add(this.btnHuy);
            this.grbThucHien.Controls.Add(this.btnLuu);
            this.grbThucHien.Controls.Add(this.btnSua);
            this.grbThucHien.Controls.Add(this.btbThucHien);
            this.grbThucHien.Location = new System.Drawing.Point(20, 300);
            this.grbThucHien.Name = "grbThucHien";
            this.grbThucHien.Size = new System.Drawing.Size(613, 130);
            this.grbThucHien.TabIndex = 2;
            this.grbThucHien.TabStop = false;
            this.grbThucHien.Text = "Thực hiện";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(318, 51);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 49);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(453, 51);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 49);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 51);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btbThucHien
            // 
            this.btbThucHien.Location = new System.Drawing.Point(44, 51);
            this.btbThucHien.Name = "btbThucHien";
            this.btbThucHien.Size = new System.Drawing.Size(118, 49);
            this.btbThucHien.TabIndex = 0;
            this.btbThucHien.Text = "Tìm kiếm";
            this.btbThucHien.UseVisualStyleBackColor = true;
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.txtHoTen);
            this.grbTTCT.Controls.Add(this.txtMaSo);
            this.grbTTCT.Controls.Add(this.cbLoaiHK);
            this.grbTTCT.Controls.Add(this.lblHoTen);
            this.grbTTCT.Controls.Add(this.lblLoaiHK);
            this.grbTTCT.Controls.Add(this.lblMaSo);
            this.grbTTCT.Location = new System.Drawing.Point(20, 89);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(613, 205);
            this.grbTTCT.TabIndex = 1;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(74, 97);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(211, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(74, 43);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(211, 26);
            this.txtMaSo.TabIndex = 3;
            // 
            // cbLoaiHK
            // 
            this.cbLoaiHK.FormattingEnabled = true;
            this.cbLoaiHK.Location = new System.Drawing.Point(403, 43);
            this.cbLoaiHK.Name = "cbLoaiHK";
            this.cbLoaiHK.Size = new System.Drawing.Size(165, 28);
            this.cbLoaiHK.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblLoaiHK
            // 
            this.lblLoaiHK.AutoSize = true;
            this.lblLoaiHK.Location = new System.Drawing.Point(308, 46);
            this.lblLoaiHK.Name = "lblLoaiHK";
            this.lblLoaiHK.Size = new System.Drawing.Size(89, 20);
            this.lblLoaiHK.TabIndex = 1;
            this.lblLoaiHK.Text = "Hạnh kiểm:";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(7, 46);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(56, 20);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(639, 90);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(824, 498);
            this.grbDanhSach.TabIndex = 0;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách lớp";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(818, 473);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // frmDanhGiaHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnDanhGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhGiaHanhKiem";
            this.Text = "frmDanhGiaHanhKiem";
            this.pnDanhGia.ResumeLayout(false);
            this.pnDanhGia.PerformLayout();
            this.grbThucHien.ResumeLayout(false);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhGia;
        private System.Windows.Forms.Label lblDanhGiaHK;
        private System.Windows.Forms.GroupBox grbThucHien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btbThucHien;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.ComboBox cbLoaiHK;
        private System.Windows.Forms.Label lblLoaiHK;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}