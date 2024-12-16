namespace QuanLyHocSinh
{
    partial class frmQuanLyNH
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
            this.components = new System.ComponentModel.Container();
            this.lblQuanLyNamHoc = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.dgvDanhSachNH = new System.Windows.Forms.DataGridView();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.toolTipMaNH = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyNamHoc
            // 
            this.lblQuanLyNamHoc.AutoSize = true;
            this.lblQuanLyNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNamHoc.Location = new System.Drawing.Point(28, 48);
            this.lblQuanLyNamHoc.Name = "lblQuanLyNamHoc";
            this.lblQuanLyNamHoc.Size = new System.Drawing.Size(310, 40);
            this.lblQuanLyNamHoc.TabIndex = 0;
            this.lblQuanLyNamHoc.Text = "Quản lý Năm học";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(439, 120);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(156, 33);
            this.cbHocKy.TabIndex = 2;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(165, 120);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(148, 30);
            this.txtNamHoc.TabIndex = 1;
            this.toolTipMaNH.SetToolTip(this.txtNamHoc, "Mã phải đủ 5 kí tự");
            this.txtNamHoc.TextChanged += new System.EventHandler(this.txtNamHoc_TextChanged);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(355, 123);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(78, 25);
            this.lblHocKy.TabIndex = 17;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // dgvDanhSachNH
            // 
            this.dgvDanhSachNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachNH.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDanhSachNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNH.Location = new System.Drawing.Point(35, 181);
            this.dgvDanhSachNH.MultiSelect = false;
            this.dgvDanhSachNH.Name = "dgvDanhSachNH";
            this.dgvDanhSachNH.ReadOnly = true;
            this.dgvDanhSachNH.RowHeadersWidth = 62;
            this.dgvDanhSachNH.RowTemplate.Height = 28;
            this.dgvDanhSachNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNH.Size = new System.Drawing.Size(1195, 433);
            this.dgvDanhSachNH.TabIndex = 19;
            this.dgvDanhSachNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNH_CellContentClick);
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNH.Location = new System.Drawing.Point(30, 123);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(129, 25);
            this.lblMaNH.TabIndex = 6;
            this.lblMaNH.Text = "Mã Năm học:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyHocSinh.Properties.Resources.diskette;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(817, 114);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 46);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::QuanLyHocSinh.Properties.Resources.plus;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.Location = new System.Drawing.Point(645, 114);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(147, 46);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmQuanLyNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1265, 644);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.lblQuanLyNamHoc);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.dgvDanhSachNH);
            this.Controls.Add(this.lblMaNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNH";
            this.Text = "frmQuanLyNH";
            this.Click += new System.EventHandler(this.frmQuanLyNH_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyNamHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.DataGridView dgvDanhSachNH;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.ToolTip toolTipMaNH;
    }
}