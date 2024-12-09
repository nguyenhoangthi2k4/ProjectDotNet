namespace QuanLyHocSinh
{
    partial class frmQuanLyLopHoc
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhanCongLopHoc = new System.Windows.Forms.Label();
            this.cbMaNH = new System.Windows.Forms.ComboBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.cbGVCN = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaNHLH = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(64, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 519);
            this.panel3.TabIndex = 6;
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
            // 
            // cbGVCN
            // 
            this.cbGVCN.FormattingEnabled = true;
            this.cbGVCN.Location = new System.Drawing.Point(996, 83);
            this.cbGVCN.Name = "cbGVCN";
            this.cbGVCN.Size = new System.Drawing.Size(207, 28);
            this.cbGVCN.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(399, 83);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(183, 26);
            this.txtMaLop.TabIndex = 1;
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
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(621, 86);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(65, 20);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(689, 83);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(183, 26);
            this.txtTenLop.TabIndex = 2;
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
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(928, 86);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(59, 20);
            this.lblGVCN.TabIndex = 2;
            this.lblGVCN.Text = "GVCN:";
            // 
            // frmQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 562);
            this.Controls.Add(this.panel3);
            this.Name = "frmQuanLyLopHoc";
            this.Text = "frmQuanLyLopHoc";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPhanCongLopHoc;
        private System.Windows.Forms.ComboBox cbMaNH;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.ComboBox cbGVCN;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaNHLH;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblGVCN;
    }
}