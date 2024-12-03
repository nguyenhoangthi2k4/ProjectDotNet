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
            this.tsMnItemDanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemPhuHuynh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDiemSo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.mnuStudentManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStudentManagement
            // 
            this.mnuStudentManagement.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuStudentManagement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStudentManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnItemHeThong,
            this.tsMnItemQuanLy,
            this.tsMnItemDiemSo,
            this.tsMnItemDanhGia,
            this.tsMnItemThuNgan,
            this.tsMnuItemPhuHuynh,
            this.tsMnuItemTTCN});
            this.mnuStudentManagement.Location = new System.Drawing.Point(0, 0);
            this.mnuStudentManagement.Name = "mnuStudentManagement";
            this.mnuStudentManagement.Size = new System.Drawing.Size(1478, 33);
            this.mnuStudentManagement.TabIndex = 0;
            this.mnuStudentManagement.Text = "menuStrip1";
            // 
            // tsMnItemHeThong
            // 
            this.tsMnItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnItemDangXuat,
            this.tsMmnItemDong});
            this.tsMnItemHeThong.Name = "tsMnItemHeThong";
            this.tsMnItemHeThong.Size = new System.Drawing.Size(103, 29);
            this.tsMnItemHeThong.Text = "&Hệ thống";
            // 
            // tsMnItemDangXuat
            // 
            this.tsMnItemDangXuat.Name = "tsMnItemDangXuat";
            this.tsMnItemDangXuat.Size = new System.Drawing.Size(224, 34);
            this.tsMnItemDangXuat.Text = "Đăng &xuất";
            this.tsMnItemDangXuat.Click += new System.EventHandler(this.tsMnItemDangXuat_Click);
            // 
            // tsMmnItemDong
            // 
            this.tsMmnItemDong.Name = "tsMmnItemDong";
            this.tsMmnItemDong.ShortcutKeyDisplayString = "";
            this.tsMmnItemDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMmnItemDong.Size = new System.Drawing.Size(224, 34);
            this.tsMmnItemDong.Text = "&Đóng";
            this.tsMmnItemDong.Click += new System.EventHandler(this.tsMmnItemDong_Click);
            // 
            // tsMnItemQuanLy
            // 
            this.tsMnItemQuanLy.Name = "tsMnItemQuanLy";
            this.tsMnItemQuanLy.Size = new System.Drawing.Size(94, 29);
            this.tsMnItemQuanLy.Text = "&Quản lý ";
            this.tsMnItemQuanLy.Click += new System.EventHandler(this.tsMnItemQuanLy_Click);
            // 
            // tsMnItemDanhGia
            // 
            this.tsMnItemDanhGia.Name = "tsMnItemDanhGia";
            this.tsMnItemDanhGia.Size = new System.Drawing.Size(99, 29);
            this.tsMnItemDanhGia.Text = "&Đánh giá";
            this.tsMnItemDanhGia.Click += new System.EventHandler(this.tsMnItemDanhGia_Click);
            // 
            // tsMnItemThuNgan
            // 
            this.tsMnItemThuNgan.Name = "tsMnItemThuNgan";
            this.tsMnItemThuNgan.Size = new System.Drawing.Size(102, 29);
            this.tsMnItemThuNgan.Text = "Thu &ngân";
            this.tsMnItemThuNgan.Click += new System.EventHandler(this.tsMnItemThuNgan_Click);
            // 
            // tsMnuItemPhuHuynh
            // 
            this.tsMnuItemPhuHuynh.Name = "tsMnuItemPhuHuynh";
            this.tsMnuItemPhuHuynh.Size = new System.Drawing.Size(112, 29);
            this.tsMnuItemPhuHuynh.Text = "&Phụ huynh";
            this.tsMnuItemPhuHuynh.Click += new System.EventHandler(this.tsMnuItemPhuHuynh_Click);
            // 
            // tsMnuItemTTCN
            // 
            this.tsMnuItemTTCN.Name = "tsMnuItemTTCN";
            this.tsMnuItemTTCN.Size = new System.Drawing.Size(170, 29);
            this.tsMnuItemTTCN.Text = "&Thông tin cá nhân";
            this.tsMnuItemTTCN.Click += new System.EventHandler(this.tsMuItemTTCN_Click);
            // 
            // tsMnItemDiemSo
            // 
            this.tsMnItemDiemSo.Name = "tsMnItemDiemSo";
            this.tsMnItemDiemSo.Size = new System.Drawing.Size(94, 29);
            this.tsMnItemDiemSo.Text = "&Điểm số";
            this.tsMnItemDiemSo.Click += new System.EventHandler(this.tsMnItemDiemSo_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Location = new System.Drawing.Point(0, 36);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1475, 600);
            this.pnContainer.TabIndex = 1;
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.mnuStudentManagement);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý học sinh";
            this.mnuStudentManagement.ResumeLayout(false);
            this.mnuStudentManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStudentManagement;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMmnItemDong;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDanhGia;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemThuNgan;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemTTCN;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDiemSo;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemPhuHuynh;
    }
}