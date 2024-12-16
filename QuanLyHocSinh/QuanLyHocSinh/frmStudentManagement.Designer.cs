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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
            this.mnuStudentManagement = new System.Windows.Forms.MenuStrip();
            this.tsMnItemThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.tsMnItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDiemSo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItemDanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemDangXuat_btn = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsMnItemQuanLy,
            this.tsMnItemDiemSo,
            this.tsMnItemDanhGia,
            this.tsMnItemThuNgan,
            this.tsMnuItemDangXuat_btn});
            this.mnuStudentManagement.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuStudentManagement.Location = new System.Drawing.Point(0, 0);
            this.mnuStudentManagement.Name = "mnuStudentManagement";
            this.mnuStudentManagement.Size = new System.Drawing.Size(213, 644);
            this.mnuStudentManagement.TabIndex = 0;
            this.mnuStudentManagement.Text = "menuStrip1";
            // 
            // tsMnItemThuNgan
            // 
            this.tsMnItemThuNgan.AutoSize = false;
            this.tsMnItemThuNgan.Name = "tsMnItemThuNgan";
            this.tsMnItemThuNgan.Size = new System.Drawing.Size(206, 4);
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
            // tsMnItemQuanLy
            // 
            this.tsMnItemQuanLy.AutoSize = false;
            this.tsMnItemQuanLy.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnItemQuanLy.Image = global::QuanLyHocSinh.Properties.Resources.classroom;
            this.tsMnItemQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsMnItemQuanLy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMnItemQuanLy.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsMnItemQuanLy.Margin = new System.Windows.Forms.Padding(0, 60, 0, 0);
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
            this.tsMnItemDiemSo.Image = global::QuanLyHocSinh.Properties.Resources.score;
            this.tsMnItemDiemSo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tsMnItemDanhGia.Image = global::QuanLyHocSinh.Properties.Resources.stamp;
            this.tsMnItemDanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsMnItemDanhGia.Name = "tsMnItemDanhGia";
            this.tsMnItemDanhGia.Size = new System.Drawing.Size(200, 50);
            this.tsMnItemDanhGia.Text = "Đánh giá";
            this.tsMnItemDanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnItemDanhGia.Click += new System.EventHandler(this.tsMnItemDanhGia_Click);
            // 
            // tsMnuItemDangXuat_btn
            // 
            this.tsMnuItemDangXuat_btn.AutoSize = false;
            this.tsMnuItemDangXuat_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemDangXuat_btn.Image = global::QuanLyHocSinh.Properties.Resources.exit;
            this.tsMnuItemDangXuat_btn.Margin = new System.Windows.Forms.Padding(0, 320, 0, 0);
            this.tsMnuItemDangXuat_btn.Name = "tsMnuItemDangXuat_btn";
            this.tsMnuItemDangXuat_btn.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemDangXuat_btn.Text = "Đăng xuất";
            this.tsMnuItemDangXuat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemDangXuat_btn.Click += new System.EventHandler(this.tsMnuItemDangXuat_btn_Click);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.mnuStudentManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý học sinh";
            this.mnuStudentManagement.ResumeLayout(false);
            this.mnuStudentManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStudentManagement;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDanhGia;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemThuNgan;
        private System.Windows.Forms.ToolStripMenuItem tsMnItemDiemSo;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemDangXuat_btn;
        private System.Windows.Forms.Panel pnContainer;
    }
}