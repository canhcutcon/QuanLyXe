namespace QuanLyXe
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grTTKH_ThongTin = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grTTKH_ChucNang = new System.Windows.Forms.GroupBox();
            this.btnTTKH_Xoa = new System.Windows.Forms.Button();
            this.btnTTKH_Sua = new System.Windows.Forms.Button();
            this.btnTTKH_Luu = new System.Windows.Forms.Button();
            this.btnTTKH_Them = new System.Windows.Forms.Button();
            this.grTTKH_DanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvTTKH_Show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTTKH_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radTimTheoSoDienThoai = new System.Windows.Forms.RadioButton();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.grTTKH_ThongTin.SuspendLayout();
            this.grTTKH_ChucNang.SuspendLayout();
            this.grTTKH_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTKH_Show)).BeginInit();
            this.grTTKH_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grTTKH_ThongTin
            // 
            this.grTTKH_ThongTin.BackColor = System.Drawing.Color.Silver;
            this.grTTKH_ThongTin.Controls.Add(this.txtSoDienThoai);
            this.grTTKH_ThongTin.Controls.Add(this.txtCMND);
            this.grTTKH_ThongTin.Controls.Add(this.txtDiaChi);
            this.grTTKH_ThongTin.Controls.Add(this.txtTenKhachHang);
            this.grTTKH_ThongTin.Controls.Add(this.txtMaKhachHang);
            this.grTTKH_ThongTin.Controls.Add(this.label1);
            this.grTTKH_ThongTin.Controls.Add(this.label6);
            this.grTTKH_ThongTin.Controls.Add(this.label5);
            this.grTTKH_ThongTin.Controls.Add(this.label4);
            this.grTTKH_ThongTin.Controls.Add(this.label3);
            this.grTTKH_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grTTKH_ThongTin.Location = new System.Drawing.Point(697, 84);
            this.grTTKH_ThongTin.Name = "grTTKH_ThongTin";
            this.grTTKH_ThongTin.Size = new System.Drawing.Size(371, 351);
            this.grTTKH_ThongTin.TabIndex = 9;
            this.grTTKH_ThongTin.TabStop = false;
            this.grTTKH_ThongTin.Text = "Thông tin";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(167, 231);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(187, 26);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(167, 287);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(187, 26);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(167, 174);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(187, 26);
            this.txtDiaChi.TabIndex = 2;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(167, 118);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(187, 26);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(167, 48);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(187, 26);
            this.txtMaKhachHang.TabIndex = 0;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng:";
            // 
            // grTTKH_ChucNang
            // 
            this.grTTKH_ChucNang.BackColor = System.Drawing.Color.Silver;
            this.grTTKH_ChucNang.Controls.Add(this.btnThoat);
            this.grTTKH_ChucNang.Controls.Add(this.btnTTKH_Xoa);
            this.grTTKH_ChucNang.Controls.Add(this.btnTTKH_Sua);
            this.grTTKH_ChucNang.Controls.Add(this.btnTTKH_Luu);
            this.grTTKH_ChucNang.Controls.Add(this.btnTTKH_Them);
            this.grTTKH_ChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grTTKH_ChucNang.Location = new System.Drawing.Point(12, 441);
            this.grTTKH_ChucNang.Name = "grTTKH_ChucNang";
            this.grTTKH_ChucNang.Size = new System.Drawing.Size(1056, 107);
            this.grTTKH_ChucNang.TabIndex = 11;
            this.grTTKH_ChucNang.TabStop = false;
            this.grTTKH_ChucNang.Text = "Chức năng";
            this.grTTKH_ChucNang.Enter += new System.EventHandler(this.grTTKH_ChucNang_Enter);
            // 
            // btnTTKH_Xoa
            // 
            this.btnTTKH_Xoa.BackColor = System.Drawing.Color.White;
            this.btnTTKH_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTKH_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTKH_Xoa.Location = new System.Drawing.Point(647, 32);
            this.btnTTKH_Xoa.Name = "btnTTKH_Xoa";
            this.btnTTKH_Xoa.Size = new System.Drawing.Size(126, 53);
            this.btnTTKH_Xoa.TabIndex = 3;
            this.btnTTKH_Xoa.Text = "Xóa";
            this.btnTTKH_Xoa.UseVisualStyleBackColor = false;
            this.btnTTKH_Xoa.Click += new System.EventHandler(this.btnTTKH_Xoa_Click);
            // 
            // btnTTKH_Sua
            // 
            this.btnTTKH_Sua.BackColor = System.Drawing.Color.White;
            this.btnTTKH_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTKH_Sua.Location = new System.Drawing.Point(446, 32);
            this.btnTTKH_Sua.Name = "btnTTKH_Sua";
            this.btnTTKH_Sua.Size = new System.Drawing.Size(126, 53);
            this.btnTTKH_Sua.TabIndex = 2;
            this.btnTTKH_Sua.Text = "Lưu Sửa";
            this.btnTTKH_Sua.UseVisualStyleBackColor = false;
            this.btnTTKH_Sua.Click += new System.EventHandler(this.btnTTKH_Sua_Click);
            // 
            // btnTTKH_Luu
            // 
            this.btnTTKH_Luu.BackColor = System.Drawing.Color.White;
            this.btnTTKH_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTKH_Luu.Location = new System.Drawing.Point(234, 32);
            this.btnTTKH_Luu.Name = "btnTTKH_Luu";
            this.btnTTKH_Luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTTKH_Luu.Size = new System.Drawing.Size(126, 53);
            this.btnTTKH_Luu.TabIndex = 1;
            this.btnTTKH_Luu.Text = "Lưu Thêm";
            this.btnTTKH_Luu.UseVisualStyleBackColor = false;
            this.btnTTKH_Luu.Click += new System.EventHandler(this.btnTTKH_Luu_Click);
            // 
            // btnTTKH_Them
            // 
            this.btnTTKH_Them.BackColor = System.Drawing.Color.White;
            this.btnTTKH_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTKH_Them.Location = new System.Drawing.Point(34, 32);
            this.btnTTKH_Them.Name = "btnTTKH_Them";
            this.btnTTKH_Them.Size = new System.Drawing.Size(126, 53);
            this.btnTTKH_Them.TabIndex = 0;
            this.btnTTKH_Them.Text = "Thêm       ";
            this.btnTTKH_Them.UseVisualStyleBackColor = false;
            this.btnTTKH_Them.Click += new System.EventHandler(this.btnTTKH_Them_Click);
            // 
            // grTTKH_DanhSach
            // 
            this.grTTKH_DanhSach.Controls.Add(this.dtgvTTKH_Show);
            this.grTTKH_DanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grTTKH_DanhSach.Location = new System.Drawing.Point(12, 84);
            this.grTTKH_DanhSach.Name = "grTTKH_DanhSach";
            this.grTTKH_DanhSach.Size = new System.Drawing.Size(679, 351);
            this.grTTKH_DanhSach.TabIndex = 12;
            this.grTTKH_DanhSach.TabStop = false;
            this.grTTKH_DanhSach.Text = "Danh sách";
            // 
            // dtgvTTKH_Show
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTTKH_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvTTKH_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTTKH_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvTTKH_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTTKH_Show.Location = new System.Drawing.Point(3, 22);
            this.dtgvTTKH_Show.Name = "dtgvTTKH_Show";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTTKH_Show.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvTTKH_Show.RowHeadersVisible = false;
            this.dtgvTTKH_Show.RowHeadersWidth = 51;
            this.dtgvTTKH_Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTTKH_Show.Size = new System.Drawing.Size(673, 326);
            this.dtgvTTKH_Show.TabIndex = 0;
            this.dtgvTTKH_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTTKH_Show_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã khách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "CMND";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 81;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // grTTKH_TimKiem
            // 
            this.grTTKH_TimKiem.BackColor = System.Drawing.Color.Silver;
            this.grTTKH_TimKiem.Controls.Add(this.btnTimKiem);
            this.grTTKH_TimKiem.Controls.Add(this.txtTimKiem);
            this.grTTKH_TimKiem.Controls.Add(this.radTimTheoSoDienThoai);
            this.grTTKH_TimKiem.Controls.Add(this.radTimTheoTen);
            this.grTTKH_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grTTKH_TimKiem.Location = new System.Drawing.Point(12, 12);
            this.grTTKH_TimKiem.Name = "grTTKH_TimKiem";
            this.grTTKH_TimKiem.Size = new System.Drawing.Size(921, 66);
            this.grTTKH_TimKiem.TabIndex = 10;
            this.grTTKH_TimKiem.TabStop = false;
            this.grTTKH_TimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(717, 18);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = " ";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(341, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(341, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // radTimTheoSoDienThoai
            // 
            this.radTimTheoSoDienThoai.AutoSize = true;
            this.radTimTheoSoDienThoai.Location = new System.Drawing.Point(92, 39);
            this.radTimTheoSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoSoDienThoai.Name = "radTimTheoSoDienThoai";
            this.radTimTheoSoDienThoai.Size = new System.Drawing.Size(182, 24);
            this.radTimTheoSoDienThoai.TabIndex = 1;
            this.radTimTheoSoDienThoai.TabStop = true;
            this.radTimTheoSoDienThoai.Text = "Tìm theo số điện thoại";
            this.radTimTheoSoDienThoai.UseVisualStyleBackColor = true;
            this.radTimTheoSoDienThoai.CheckedChanged += new System.EventHandler(this.radTimTheoSoDienThoai_CheckedChanged);
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(92, 18);
            this.radTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(115, 24);
            this.radTimTheoTen.TabIndex = 0;
            this.radTimTheoTen.TabStop = true;
            this.radTimTheoTen.Text = "Tìm theo tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            this.radTimTheoTen.CheckedChanged += new System.EventHandler(this.radTimTheoTen_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(852, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 53);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1091, 567);
            this.Controls.Add(this.grTTKH_ThongTin);
            this.Controls.Add(this.grTTKH_ChucNang);
            this.Controls.Add(this.grTTKH_DanhSach);
            this.Controls.Add(this.grTTKH_TimKiem);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.grTTKH_ThongTin.ResumeLayout(false);
            this.grTTKH_ThongTin.PerformLayout();
            this.grTTKH_ChucNang.ResumeLayout(false);
            this.grTTKH_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTTKH_Show)).EndInit();
            this.grTTKH_TimKiem.ResumeLayout(false);
            this.grTTKH_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTTKH_ThongTin;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grTTKH_ChucNang;
        private System.Windows.Forms.Button btnTTKH_Xoa;
        private System.Windows.Forms.Button btnTTKH_Sua;
        private System.Windows.Forms.Button btnTTKH_Luu;
        private System.Windows.Forms.Button btnTTKH_Them;
        private System.Windows.Forms.GroupBox grTTKH_DanhSach;
        private System.Windows.Forms.DataGridView dtgvTTKH_Show;
        private System.Windows.Forms.GroupBox grTTKH_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton radTimTheoSoDienThoai;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnThoat;
    }
}