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
            this.tsMnuItemQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemToGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLHS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLTN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnuItemDangXuat_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuItemHeThong,
            this.stMnuItemQLNH,
            this.tsMnuItemQLLH,
            this.tsMnuItemToGV,
            this.tsMnuItemQLGV,
            this.tsMnuItemQLHS,
            this.tsMnuItemQLTN,
            this.tsMnuItemQLTK,
            this.tsMnuItemDangXuat_btn});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(213, 644);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMnuItemHeThong
            // 
            this.tsMnuItemHeThong.AutoSize = false;
            this.tsMnuItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuItemDangXuat,
            this.tsMnuItemDong});
            this.tsMnuItemHeThong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMnuItemHeThong.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemHeThong.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tsMnuItemHeThong.Name = "tsMnuItemHeThong";
            this.tsMnuItemHeThong.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tsMnuItemHeThong.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemHeThong.Text = "Hệ thống";
            this.tsMnuItemHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsMnuItemDangXuat
            // 
            this.tsMnuItemDangXuat.AutoSize = false;
            this.tsMnuItemDangXuat.BackColor = System.Drawing.Color.SteelBlue;
            this.tsMnuItemDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMnuItemDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemDangXuat.Name = "tsMnuItemDangXuat";
            this.tsMnuItemDangXuat.Size = new System.Drawing.Size(230, 40);
            this.tsMnuItemDangXuat.Text = "Đăng &xuất";
            this.tsMnuItemDangXuat.Click += new System.EventHandler(this.tsMnuItemDangXuat_Click);
            // 
            // tsMnuItemDong
            // 
            this.tsMnuItemDong.AutoSize = false;
            this.tsMnuItemDong.BackColor = System.Drawing.Color.SteelBlue;
            this.tsMnuItemDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMnuItemDong.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemDong.Name = "tsMnuItemDong";
            this.tsMnuItemDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMnuItemDong.Size = new System.Drawing.Size(230, 40);
            this.tsMnuItemDong.Text = "&Đóng";
            this.tsMnuItemDong.Click += new System.EventHandler(this.tsMnuItemDong_Click);
            // 
            // stMnuItemQLNH
            // 
            this.stMnuItemQLNH.AutoSize = false;
            this.stMnuItemQLNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stMnuItemQLNH.ForeColor = System.Drawing.Color.DarkBlue;
            this.stMnuItemQLNH.Name = "stMnuItemQLNH";
            this.stMnuItemQLNH.Size = new System.Drawing.Size(200, 50);
            this.stMnuItemQLNH.Text = "Năm học";
            this.stMnuItemQLNH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stMnuItemQLNH.Click += new System.EventHandler(this.stMnuItemQLNH_Click);
            // 
            // tsMnuItemQLLH
            // 
            this.tsMnuItemQLLH.AutoSize = false;
            this.tsMnuItemQLLH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemQLLH.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemQLLH.Name = "tsMnuItemQLLH";
            this.tsMnuItemQLLH.Padding = new System.Windows.Forms.Padding(10, 0, 6, 0);
            this.tsMnuItemQLLH.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemQLLH.Text = "Lớp học";
            this.tsMnuItemQLLH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemQLLH.Click += new System.EventHandler(this.tsMnuItemQLLH_Click);
            // 
            // tsMnuItemToGV
            // 
            this.tsMnuItemToGV.AutoSize = false;
            this.tsMnuItemToGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemToGV.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemToGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemToGV.Name = "tsMnuItemToGV";
            this.tsMnuItemToGV.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemToGV.Text = "Tổ Giáo Viên";
            this.tsMnuItemToGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemToGV.Click += new System.EventHandler(this.tsMnuItemToGV_Click);
            // 
            // tsMnuItemQLGV
            // 
            this.tsMnuItemQLGV.AutoSize = false;
            this.tsMnuItemQLGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemQLGV.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemQLGV.Name = "tsMnuItemQLGV";
            this.tsMnuItemQLGV.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemQLGV.Text = "Giáo viên";
            this.tsMnuItemQLGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemQLGV.Click += new System.EventHandler(this.tsMnuItemQLGV_Click);
            // 
            // tsMnuItemQLHS
            // 
            this.tsMnuItemQLHS.AutoSize = false;
            this.tsMnuItemQLHS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemQLHS.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemQLHS.Name = "tsMnuItemQLHS";
            this.tsMnuItemQLHS.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemQLHS.Text = "Học sinh";
            this.tsMnuItemQLHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemQLHS.Click += new System.EventHandler(this.tsMnuItemQLHS_Click);
            // 
            // tsMnuItemQLTN
            // 
            this.tsMnuItemQLTN.AutoSize = false;
            this.tsMnuItemQLTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemQLTN.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemQLTN.Name = "tsMnuItemQLTN";
            this.tsMnuItemQLTN.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemQLTN.Text = "Thu ngân";
            this.tsMnuItemQLTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsMnuItemQLTK
            // 
            this.tsMnuItemQLTK.AutoSize = false;
            this.tsMnuItemQLTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemQLTK.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemQLTK.Name = "tsMnuItemQLTK";
            this.tsMnuItemQLTK.Size = new System.Drawing.Size(200, 50);
            this.tsMnuItemQLTK.Text = "Tài khoản";
            this.tsMnuItemQLTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMnuItemQLTK.Click += new System.EventHandler(this.tsMnuItemQLTK_Click);
            // 
            // tsMnuItemDangXuat_btn
            // 
            this.tsMnuItemDangXuat_btn.AutoSize = false;
            this.tsMnuItemDangXuat_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsMnuItemDangXuat_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.tsMnuItemDangXuat_btn.Margin = new System.Windows.Forms.Padding(0, 130, 0, 0);
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
            this.Text = "Admin Quản lý học sinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemQLLH;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemDangXuat_btn;
        private System.Windows.Forms.ToolStripMenuItem tsMnuItemToGV;
    }
}