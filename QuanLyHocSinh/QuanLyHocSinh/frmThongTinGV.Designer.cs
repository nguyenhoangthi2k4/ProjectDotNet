namespace QuanLyHocSinh
{
    partial class frmThongTinGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinGV));
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblLopQL = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQueQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQueQuan.Location = new System.Drawing.Point(476, 62);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(105, 25);
            this.lblQueQuan.TabIndex = 0;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // lblLopQL
            // 
            this.lblLopQL.AutoSize = true;
            this.lblLopQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLopQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLopQL.Location = new System.Drawing.Point(28, 190);
            this.lblLopQL.Name = "lblLopQL";
            this.lblLopQL.Size = new System.Drawing.Size(124, 25);
            this.lblLopQL.TabIndex = 0;
            this.lblLopQL.Text = "Lớp Quản lý:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSoDT.Location = new System.Drawing.Point(268, 123);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(75, 25);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số ĐT:";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNamSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNamSinh.Location = new System.Drawing.Point(28, 123);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(100, 25);
            this.lblNamSinh.TabIndex = 0;
            this.lblNamSinh.Text = "Năm sinh:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmail.Location = new System.Drawing.Point(481, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHoTen.Location = new System.Drawing.Point(28, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(95, 25);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Thầy/Cô:";
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.White;
            this.btnQuanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuanLy.ForeColor = System.Drawing.Color.Red;
            this.btnQuanLy.Location = new System.Drawing.Point(344, 263);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(158, 43);
            this.btnQuanLy.TabIndex = 1;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamSinh.Location = new System.Drawing.Point(134, 122);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(128, 30);
            this.dtpNamSinh.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(134, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(341, 30);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQueQuan.Location = new System.Drawing.Point(583, 61);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(227, 30);
            this.txtQueQuan.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(553, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(257, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoDT.Location = new System.Drawing.Point(344, 122);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.ReadOnly = true;
            this.txtSoDT.Size = new System.Drawing.Size(131, 30);
            this.txtSoDT.TabIndex = 4;
            // 
            // cbMaLop
            // 
            this.cbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(158, 187);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(317, 33);
            this.cbMaLop.TabIndex = 5;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Magenta;
            this.pbLoading.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.pbLoading.Location = new System.Drawing.Point(33, 339);
            this.pbLoading.MarqueeAnimationSpeed = 120;
            this.pbLoading.Maximum = 150;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(777, 23);
            this.pbLoading.TabIndex = 6;
            // 
            // frmThongTinGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(838, 384);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.dtpNamSinh);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblLopQL);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblQueQuan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTinGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Giáo viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblLopQL;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}