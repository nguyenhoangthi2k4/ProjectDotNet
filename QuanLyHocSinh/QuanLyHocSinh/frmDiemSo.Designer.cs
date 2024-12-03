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
            this.pnDiemSo = new System.Windows.Forms.Panel();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grbThucHien = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grbNhapDiem = new System.Windows.Forms.GroupBox();
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
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblQLDS = new System.Windows.Forms.Label();
            this.pnDiemSo.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbThucHien.SuspendLayout();
            this.grbNhapDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDiemSo
            // 
            this.pnDiemSo.Controls.Add(this.grbDanhSach);
            this.pnDiemSo.Controls.Add(this.grbThucHien);
            this.pnDiemSo.Controls.Add(this.grbNhapDiem);
            this.pnDiemSo.Controls.Add(this.lblQLDS);
            this.pnDiemSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDiemSo.Location = new System.Drawing.Point(0, 0);
            this.pnDiemSo.Name = "pnDiemSo";
            this.pnDiemSo.Size = new System.Drawing.Size(1475, 600);
            this.pnDiemSo.TabIndex = 0;
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(505, 84);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(958, 504);
            this.grbDanhSach.TabIndex = 10;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(952, 479);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // grbThucHien
            // 
            this.grbThucHien.Controls.Add(this.btnLuu);
            this.grbThucHien.Controls.Add(this.btnHuy);
            this.grbThucHien.Controls.Add(this.btnSua);
            this.grbThucHien.Controls.Add(this.btnNhap);
            this.grbThucHien.Location = new System.Drawing.Point(25, 480);
            this.grbThucHien.Name = "grbThucHien";
            this.grbThucHien.Size = new System.Drawing.Size(464, 105);
            this.grbThucHien.TabIndex = 9;
            this.grbThucHien.TabStop = false;
            this.grbThucHien.Text = "Thực hiện";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(353, 37);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(241, 37);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 40);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(129, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(17, 37);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(92, 40);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // grbNhapDiem
            // 
            this.grbNhapDiem.Controls.Add(this.cbHocKy);
            this.grbNhapDiem.Controls.Add(this.txtDTB);
            this.grbNhapDiem.Controls.Add(this.txtSinh);
            this.grbNhapDiem.Controls.Add(this.txtGDCD);
            this.grbNhapDiem.Controls.Add(this.txtNgNgu);
            this.grbNhapDiem.Controls.Add(this.txtDia);
            this.grbNhapDiem.Controls.Add(this.txtLy);
            this.grbNhapDiem.Controls.Add(this.txtSu);
            this.grbNhapDiem.Controls.Add(this.txtVan);
            this.grbNhapDiem.Controls.Add(this.lblDTB);
            this.grbNhapDiem.Controls.Add(this.lblSinh);
            this.grbNhapDiem.Controls.Add(this.txtHoa);
            this.grbNhapDiem.Controls.Add(this.lblDia);
            this.grbNhapDiem.Controls.Add(this.lblGDCD);
            this.grbNhapDiem.Controls.Add(this.lblLy);
            this.grbNhapDiem.Controls.Add(this.lblNgNgu);
            this.grbNhapDiem.Controls.Add(this.lblSu);
            this.grbNhapDiem.Controls.Add(this.txtToan);
            this.grbNhapDiem.Controls.Add(this.lblVan);
            this.grbNhapDiem.Controls.Add(this.lblHoa);
            this.grbNhapDiem.Controls.Add(this.txtHoTen);
            this.grbNhapDiem.Controls.Add(this.txtNamHoc);
            this.grbNhapDiem.Controls.Add(this.lblToan);
            this.grbNhapDiem.Controls.Add(this.lblHocKy);
            this.grbNhapDiem.Controls.Add(this.lblNamHoc);
            this.grbNhapDiem.Controls.Add(this.lblHoTen);
            this.grbNhapDiem.Location = new System.Drawing.Point(25, 84);
            this.grbNhapDiem.Name = "grbNhapDiem";
            this.grbNhapDiem.Size = new System.Drawing.Size(464, 361);
            this.grbNhapDiem.TabIndex = 7;
            this.grbNhapDiem.TabStop = false;
            this.grbNhapDiem.Text = "Nhập điểm";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(319, 29);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(129, 28);
            this.cbHocKy.TabIndex = 19;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(319, 315);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(129, 26);
            this.txtDTB.TabIndex = 18;
            // 
            // txtSinh
            // 
            this.txtSinh.Location = new System.Drawing.Point(319, 222);
            this.txtSinh.Name = "txtSinh";
            this.txtSinh.Size = new System.Drawing.Size(129, 26);
            this.txtSinh.TabIndex = 18;
            // 
            // txtGDCD
            // 
            this.txtGDCD.Location = new System.Drawing.Point(92, 315);
            this.txtGDCD.Name = "txtGDCD";
            this.txtGDCD.Size = new System.Drawing.Size(129, 26);
            this.txtGDCD.TabIndex = 18;
            // 
            // txtNgNgu
            // 
            this.txtNgNgu.Location = new System.Drawing.Point(92, 222);
            this.txtNgNgu.Name = "txtNgNgu";
            this.txtNgNgu.Size = new System.Drawing.Size(129, 26);
            this.txtNgNgu.TabIndex = 18;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(319, 267);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(129, 26);
            this.txtDia.TabIndex = 18;
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(319, 174);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(129, 26);
            this.txtLy.TabIndex = 18;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(92, 267);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(129, 26);
            this.txtSu.TabIndex = 18;
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(92, 174);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(129, 26);
            this.txtVan.TabIndex = 18;
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(242, 318);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(45, 20);
            this.lblDTB.TabIndex = 16;
            this.lblDTB.Text = "ĐTB:";
            // 
            // lblSinh
            // 
            this.lblSinh.AutoSize = true;
            this.lblSinh.Location = new System.Drawing.Point(242, 225);
            this.lblSinh.Name = "lblSinh";
            this.lblSinh.Size = new System.Drawing.Size(75, 20);
            this.lblSinh.TabIndex = 16;
            this.lblSinh.Text = "Sinh học:";
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(319, 126);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(129, 26);
            this.txtHoa.TabIndex = 18;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(242, 270);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(51, 20);
            this.lblDia.TabIndex = 16;
            this.lblDia.Text = "Địa lý:";
            // 
            // lblGDCD
            // 
            this.lblGDCD.AutoSize = true;
            this.lblGDCD.Location = new System.Drawing.Point(15, 318);
            this.lblGDCD.Name = "lblGDCD";
            this.lblGDCD.Size = new System.Drawing.Size(61, 20);
            this.lblGDCD.TabIndex = 16;
            this.lblGDCD.Text = "GDCD:";
            // 
            // lblLy
            // 
            this.lblLy.AutoSize = true;
            this.lblLy.Location = new System.Drawing.Point(242, 177);
            this.lblLy.Name = "lblLy";
            this.lblLy.Size = new System.Drawing.Size(52, 20);
            this.lblLy.TabIndex = 16;
            this.lblLy.Text = "Vật lý:";
            // 
            // lblNgNgu
            // 
            this.lblNgNgu.AutoSize = true;
            this.lblNgNgu.Location = new System.Drawing.Point(15, 225);
            this.lblNgNgu.Name = "lblNgNgu";
            this.lblNgNgu.Size = new System.Drawing.Size(62, 20);
            this.lblNgNgu.TabIndex = 16;
            this.lblNgNgu.Text = "NgNgữ:";
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Location = new System.Drawing.Point(15, 270);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(63, 20);
            this.lblSu.TabIndex = 16;
            this.lblSu.Text = "Lịch sử:";
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(92, 126);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(129, 26);
            this.txtToan.TabIndex = 18;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(15, 177);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(62, 20);
            this.lblVan.TabIndex = 16;
            this.lblVan.Text = "NgVăn:";
            // 
            // lblHoa
            // 
            this.lblHoa.AutoSize = true;
            this.lblHoa.Location = new System.Drawing.Point(242, 129);
            this.lblHoa.Name = "lblHoa";
            this.lblHoa.Size = new System.Drawing.Size(73, 20);
            this.lblHoa.TabIndex = 16;
            this.lblHoa.Text = "Hóa học:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(92, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(356, 26);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(92, 29);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(129, 26);
            this.txtNamHoc.TabIndex = 18;
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(15, 129);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(49, 20);
            this.lblToan.TabIndex = 16;
            this.lblToan.Text = "Toán:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(242, 32);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(65, 20);
            this.lblHocKy.TabIndex = 17;
            this.lblHocKy.Text = "Học kỳ: ";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Location = new System.Drawing.Point(15, 32);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(76, 20);
            this.lblNamHoc.TabIndex = 16;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 81);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblQLDS
            // 
            this.lblQLDS.AutoSize = true;
            this.lblQLDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDS.Location = new System.Drawing.Point(21, 28);
            this.lblQLDS.Name = "lblQLDS";
            this.lblQLDS.Size = new System.Drawing.Size(479, 40);
            this.lblQLDS.TabIndex = 0;
            this.lblQLDS.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            // 
            // frmDiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 600);
            this.Controls.Add(this.pnDiemSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemSo";
            this.Text = "frmDiemSo";
            this.pnDiemSo.ResumeLayout(false);
            this.pnDiemSo.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbThucHien.ResumeLayout(false);
            this.grbNhapDiem.ResumeLayout(false);
            this.grbNhapDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDiemSo;
        private System.Windows.Forms.Label lblQLDS;
        private System.Windows.Forms.GroupBox grbNhapDiem;
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
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbThucHien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}