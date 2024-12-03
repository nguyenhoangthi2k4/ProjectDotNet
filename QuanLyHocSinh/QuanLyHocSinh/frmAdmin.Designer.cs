namespace QuanLyHocSinh
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMnuItemHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemDong = new System.Windows.Forms.ToolStripMenuItem();
            this.stMnuItemQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLHS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLTN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuItemHeThong,
            this.stMnuItemQLNH,
            this.tsMnuItemQLGV,
            this.tsMnuItemQLHS,
            this.tsMnuItemQLTN,
            this.tsMnuItemQLTK});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMnuItemHeThong
            // 
            this.tsMnuItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuItemDangXuat,
            this.tsMnuItemDong});
            this.tsMnuItemHeThong.Name = "tsMnuItemHeThong";
            this.tsMnuItemHeThong.Size = new System.Drawing.Size(103, 29);
            this.tsMnuItemHeThong.Text = "Hệ thống";
            // 
            // tsMnuItemDangXuat
            // 
            this.tsMnuItemDangXuat.Name = "tsMnuItemDangXuat";
            this.tsMnuItemDangXuat.Size = new System.Drawing.Size(224, 34);
            this.tsMnuItemDangXuat.Text = "Đăng &xuất";
            this.tsMnuItemDangXuat.Click += new System.EventHandler(this.tsMnuItemDangXuat_Click);
            // 
            // tsMnuItemDong
            // 
            this.tsMnuItemDong.Name = "tsMnuItemDong";
            this.tsMnuItemDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMnuItemDong.Size = new System.Drawing.Size(224, 34);
            this.tsMnuItemDong.Text = "&Đóng";
            this.tsMnuItemDong.Click += new System.EventHandler(this.tsMnuItemDong_Click);
            // 
            // stMnuItemQLNH
            // 
            this.stMnuItemQLNH.Name = "stMnuItemQLNH";
            this.stMnuItemQLNH.Size = new System.Drawing.Size(163, 29);
            this.stMnuItemQLNH.Text = "Quản lý năm học";
            this.stMnuItemQLNH.Click += new System.EventHandler(this.stMnuItemQLNH_Click);
            // 
            // tsMnuItemQLGV
            // 
            this.tsMnuItemQLGV.Name = "tsMnuItemQLGV";
            this.tsMnuItemQLGV.Size = new System.Drawing.Size(166, 29);
            this.tsMnuItemQLGV.Text = "Quản lý giáo viên";
            this.tsMnuItemQLGV.Click += new System.EventHandler(this.tsMnuItemQLGV_Click);
            // 
            // tsMnuItemQLHS
            // 
            this.tsMnuItemQLHS.Name = "tsMnuItemQLHS";
            this.tsMnuItemQLHS.Size = new System.Drawing.Size(160, 29);
            this.tsMnuItemQLHS.Text = "Quản lý học sinh";
            this.tsMnuItemQLHS.Click += new System.EventHandler(this.tsMnuItemQLHS_Click);
            // 
            // tsMnuItemQLTN
            // 
            this.tsMnuItemQLTN.Name = "tsMnuItemQLTN";
            this.tsMnuItemQLTN.Size = new System.Drawing.Size(165, 29);
            this.tsMnuItemQLTN.Text = "Quản lý thu ngân";
            // 
            // tsMnuItemQLTK
            // 
            this.tsMnuItemQLTK.Name = "tsMnuItemQLTK";
            this.tsMnuItemQLTK.Size = new System.Drawing.Size(167, 29);
            this.tsMnuItemQLTK.Text = "Quản lý tài khoản";
            this.tsMnuItemQLTK.Click += new System.EventHandler(this.tsMnuItemQLTK_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.Azure;
            this.pnContainer.Location = new System.Drawing.Point(0, 32);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1475, 600);
            this.pnContainer.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemDong;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemQLHS;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemQLGV;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.ToolStripMenuItem stMnuItemQLNH;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemQLTN;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemQLTK;
    }
}