namespace QuanLyHocSinh
{
    partial class frmStudentManagement
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
            this.mnuStudentManagement = new System.Windows.Forms.MenuStrip();
            this.tsMnItemHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMmnItemDong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDiemSo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemPhuHuynh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemDangXuat_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.mnuStudentManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStudentManagement
            // 
            this.mnuStudentManagement.AutoSize = false;
            this.mnuStudentManagement.BackColor = System.Drawing.Color.SlateGray;
            this.mnuStudentManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuStudentManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mnuStudentManagement.GripMargin = new System.Windows.Forms.Padding(3);
            this.mnuStudentManagement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStudentManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnItemHeThong,
            this.tsMnItemQuanLy,
            this.tsMnItemDiemSo,
            this.tsMnItemDanhGia,
            this.tsMnItemThuNgan,
            this.tsMnuItemPhuHuynh,
            this.tsMnuItemTTCN,
            this.tsMnuItemDangXuat_btn});
            this.mnuStudentManagement.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuStudentManagement.Location = new System.Drawing.Point(0, 0);
            this.mnuStudentManagement.Name = "mnuStudentManagement";
            this.mnuStudentManagement.Size = new System.Drawing.Size(213, 644);
            this.mnuStudentManagement.TabIndex = 0;
            this.mnuStudentManagement.Text = "menuStrip1";
            // 
            // tsMnItemHeThong
            // 
            this.tsMnItemHeThong.AutoSize = false;
            this.tsMnItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnItemDangXuat,
            this.tsMmnItemDong});
            this.tsMnItemHeThong.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemHeThong.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tsMnItemHeThong.Name = "tsMnItemHeThong";
            this.tsMnItemHeThong.Size = new System.Drawing.Size(200, 50);
            this.tsMnItemHeThong.Text = "Hệ thống";
            this.tsMnItemHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsMnItemDangXuat
            // 
            this.tsMnItemDangXuat.BackColor = System.Drawing.Color.SteelBlue;
            this.tsMnItemDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsMnItemDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemDangXuat.Name = "tsMnItemDangXuat";
            this.tsMnItemDangXuat.Size = new System.Drawing.Size(270, 36);
            this.tsMnItemDangXuat.Text = "Đăng &xuất";
            this.tsMnItemDangXuat.Click += new System.EventHandler(this.tsMnItemDangXuat_Click);
            // 
            // tsMmnItemDong
            // 
            this.tsMmnItemDong.BackColor = System.Drawing.Color.SteelBlue;
            this.tsMmnItemDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsMmnItemDong.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMmnItemDong.Name = "tsMmnItemDong";
            this.tsMmnItemDong.ShortcutKeyDisplayString = "";
            this.tsMmnItemDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMmnItemDong.Size = new System.Drawing.Size(270, 36);
            this.tsMmnItemDong.Text = "Đóng";
            this.tsMmnItemDong.Click += new System.EventHandler(this.tsMmnItemDong_Click);
            // 
            // tsMnItemQuanLy
            // 
            this.tsMnItemQuanLy.AutoSize = false;
            this.tsMnItemQuanLy.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemQuanLy.Name = "tsMnItemQuanLy";
            this.tsMnItemQuanLy.Size = new System.Drawing.Size(200, 50);
            this.tsMnItemQuanLy.Text = "Quản lý ";
            this.tsMnItemQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemQuanLy.Click += new System.EventHandler(this.tsMnItemQuanLy_Click);
            // 
            // tsMnItemDiemSo
            // 
            this.tsMnItemDiemSo.AutoSize = false;
            this.tsMnItemDiemSo.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemDiemSo.Name = "tsMnItemDiemSo";
            this.tsMnItemDiemSo.Size = new System.Drawing.Size(200, 50);
            this.tsMnItemDiemSo.Text = "Điểm số";
            this.tsMnItemDiemSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemDiemSo.Click += new System.EventHandler(this.tsMnItemDiemSo_Click);
            // 
            // tsMnItemDanhGia
            // 
            this.tsMnItemDanhGia.AutoSize = false;
            this.tsMnItemDanhGia.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemDanhGia.Name = "tsMnItemDanhGia";
            this.tsMnItemDanhGia.Size = new System.Drawing.Size(200, 50);
            this.tsMnItemDanhGia.Text = "Đánh giá";
            this.tsMnItemDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemDanhGia.Click += new System.EventHandler(this.tsMnItemDanhGia_Click);
            // 
            // tsMnItemThuNgan
            // 
            this.tsMnItemThuNgan.AutoSize = false;
            this.tsMnItemThuNgan.Name = "tsMnItemThuNgan";
            this.tsMnItemThuNgan.Size = new System.Drawing.Size(206, 4);
            this.tsMnItemThuNgan.Click += new System.EventHandler(this.tsMnItemThuNgan_Click);
            // 
            // tsMnuItemPhuHuynh
            // 
            this.tsMnuItemPhuHuynh.AutoSize = false;
            this.tsMnuItemPhuHuynh.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemPhuHuynh.Name = "tsMnuItemPhuHuynh";
            this.tsMnuItemPhuHuynh.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemPhuHuynh.Text = "Phụ huynh";
            this.tsMnuItemPhuHuynh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemPhuHuynh.Click += new System.EventHandler(this.tsMnuItemPhuHuynh_Click);
            // 
            // tsMnuItemTTCN
            // 
            this.tsMnuItemTTCN.AutoSize = false;
            this.tsMnuItemTTCN.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemTTCN.Name = "tsMnuItemTTCN";
            this.tsMnuItemTTCN.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemTTCN.Text = "Thông tin";
            this.tsMnuItemTTCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemTTCN.Click += new System.EventHandler(this.tsMuItemTTCN_Click);
            // 
            // tsMnuItemDangXuat_btn
            // 
            this.tsMnuItemDangXuat_btn.AutoSize = false;
            this.tsMnuItemDangXuat_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemDangXuat_btn.Margin = new System.Windows.Forms.Padding(0, 220, 0, 0);
            this.tsMnuItemDangXuat_btn.Name = "tsMnuItemDangXuat_btn";
            this.tsMnuItemDangXuat_btn.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemDangXuat_btn.Text = "Đăng xuất";
            this.tsMnuItemDangXuat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.SystemColors.Window;
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(213, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1265, 644);
            this.pnContainer.TabIndex = 2;
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.mnuStudentManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý học sinh";
            this.mnuStudentManagement.ResumeLayout(false);
            this.mnuStudentManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStudentManagement;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMmnItemDong;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDanhGia;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemThuNgan;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemTTCN;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDiemSo;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemPhuHuynh;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemDangXuat_btn;
        private System.Windows.Forms.Panel pnContainer;
    }
}