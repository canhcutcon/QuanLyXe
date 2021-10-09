namespace QuanLyXe
{
    partial class frmXe
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
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimTenXe = new System.Windows.Forms.TextBox();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGiaXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPhanKhoi = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTat = new System.Windows.Forms.Button();
            this.grTimKiem.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.grThongTin.SuspendLayout();
            this.grChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grTimKiem
            // 
            this.grTimKiem.BackColor = System.Drawing.Color.Silver;
            this.grTimKiem.Controls.Add(this.btnReset);
            this.grTimKiem.Controls.Add(this.btnTimKiem);
            this.grTimKiem.Controls.Add(this.label1);
            this.grTimKiem.Controls.Add(this.txtTimTenXe);
            this.grTimKiem.Location = new System.Drawing.Point(2, 14);
            this.grTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grTimKiem.Size = new System.Drawing.Size(1220, 107);
            this.grTimKiem.TabIndex = 8;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(701, 17);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(188, 62);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(447, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(188, 62);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Xe:";
            // 
            // txtTimTenXe
            // 
            this.txtTimTenXe.Location = new System.Drawing.Point(147, 34);
            this.txtTimTenXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimTenXe.Name = "txtTimTenXe";
            this.txtTimTenXe.Size = new System.Drawing.Size(289, 26);
            this.txtTimTenXe.TabIndex = 0;
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dtgvShow);
            this.grDanhSach.Location = new System.Drawing.Point(12, 129);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(688, 406);
            this.grDanhSach.TabIndex = 9;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dtgvShow
            // 
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenNhaCungCap,
            this.TenThuoc,
            this.CongDung,
            this.DonGia,
            this.NgaySX,
            this.HanSD,
            this.SoLuong,
            this.LoaiThuoc});
            this.dtgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShow.Location = new System.Drawing.Point(3, 22);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShow.Size = new System.Drawing.Size(682, 381);
            this.dtgvShow.TabIndex = 0;
            this.dtgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellClick);
            this.dtgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellContentClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaXe";
            this.MaThuoc.HeaderText = "Mã Xe";
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenXe";
            this.TenNhaCungCap.HeaderText = "Tên Xe";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "PhanKhoi";
            this.TenThuoc.HeaderText = "Phân Khối";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // CongDung
            // 
            this.CongDung.DataPropertyName = "SoLuongTon";
            this.CongDung.HeaderText = "Số Lượng Tồn";
            this.CongDung.Name = "CongDung";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "MaLoai";
            this.DonGia.HeaderText = "Mã Loại";
            this.DonGia.Name = "DonGia";
            // 
            // NgaySX
            // 
            this.NgaySX.DataPropertyName = "DonGiaNhap";
            this.NgaySX.HeaderText = "Đơn Giá Nhập";
            this.NgaySX.Name = "NgaySX";
            // 
            // HanSD
            // 
            this.HanSD.DataPropertyName = "DonGiaBan";
            this.HanSD.HeaderText = "Đơn Giá Bán";
            this.HanSD.Name = "HanSD";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "GhiChu";
            this.SoLuong.HeaderText = "Ghi Chú";
            this.SoLuong.Name = "SoLuong";
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.DataPropertyName = "MaNCC";
            this.LoaiThuoc.HeaderText = "Mã Nhà Cung Cấp";
            this.LoaiThuoc.Name = "LoaiThuoc";
            // 
            // grThongTin
            // 
            this.grThongTin.BackColor = System.Drawing.Color.Silver;
            this.grThongTin.Controls.Add(this.txtMaNCC);
            this.grThongTin.Controls.Add(this.txtGhiChu);
            this.grThongTin.Controls.Add(this.label5);
            this.grThongTin.Controls.Add(this.txtMaLoaiXe);
            this.grThongTin.Controls.Add(this.label7);
            this.grThongTin.Controls.Add(this.txtSoLuongTon);
            this.grThongTin.Controls.Add(this.label3);
            this.grThongTin.Controls.Add(this.txtDonGiaNhap);
            this.grThongTin.Controls.Add(this.label6);
            this.grThongTin.Controls.Add(this.txtDonGiaXuat);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label19);
            this.grThongTin.Controls.Add(this.txtPhanKhoi);
            this.grThongTin.Controls.Add(this.txtTenXe);
            this.grThongTin.Controls.Add(this.txtMaXe);
            this.grThongTin.Controls.Add(this.label14);
            this.grThongTin.Controls.Add(this.label13);
            this.grThongTin.Controls.Add(this.label12);
            this.grThongTin.Location = new System.Drawing.Point(703, 139);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(519, 396);
            this.grThongTin.TabIndex = 10;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(127, 323);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(221, 26);
            this.txtMaNCC.TabIndex = 8;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            this.txtMaNCC.Leave += new System.EventHandler(this.txtMaNCC_Leave);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(127, 280);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(221, 26);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.Leave += new System.EventHandler(this.txtTenXe_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ghi Chú";
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Location = new System.Drawing.Point(127, 166);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(221, 26);
            this.txtMaLoaiXe.TabIndex = 6;
            this.txtMaLoaiXe.TextChanged += new System.EventHandler(this.txtMaXe_TextChanged);
            this.txtMaLoaiXe.Leave += new System.EventHandler(this.txtMaXe_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mã Loại Xe:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(127, 134);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(221, 26);
            this.txtSoLuongTon.TabIndex = 6;
            this.txtSoLuongTon.TextChanged += new System.EventHandler(this.txtSoLuongTon_TextChanged);
            this.txtSoLuongTon.Leave += new System.EventHandler(this.txtSoLuongTon_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số lượng tồn:";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(127, 203);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(221, 26);
            this.txtDonGiaNhap.TabIndex = 6;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            this.txtDonGiaNhap.Leave += new System.EventHandler(this.txtDonGiaNhap_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đơn giá nhập:";
            // 
            // txtDonGiaXuat
            // 
            this.txtDonGiaXuat.Location = new System.Drawing.Point(127, 240);
            this.txtDonGiaXuat.Name = "txtDonGiaXuat";
            this.txtDonGiaXuat.Size = new System.Drawing.Size(221, 26);
            this.txtDonGiaXuat.TabIndex = 6;
            this.txtDonGiaXuat.TextChanged += new System.EventHandler(this.txtDonGiaXuat_TextChanged);
            this.txtDonGiaXuat.Leave += new System.EventHandler(this.txtDonGiaXuat_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đơn giá bán:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 329);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "MaNCC";
            // 
            // txtPhanKhoi
            // 
            this.txtPhanKhoi.Location = new System.Drawing.Point(127, 93);
            this.txtPhanKhoi.Name = "txtPhanKhoi";
            this.txtPhanKhoi.Size = new System.Drawing.Size(221, 26);
            this.txtPhanKhoi.TabIndex = 2;
            this.txtPhanKhoi.TextChanged += new System.EventHandler(this.txtPhanKhoi_Leave);
            this.txtPhanKhoi.Leave += new System.EventHandler(this.txtPhanKhoi_Leave);
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(127, 56);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(221, 26);
            this.txtTenXe.TabIndex = 1;
            this.txtTenXe.TextChanged += new System.EventHandler(this.txtTenXe_TextChanged);
            this.txtTenXe.Leave += new System.EventHandler(this.txtTenXe_Leave);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(127, 19);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(221, 26);
            this.txtMaXe.TabIndex = 0;
            this.txtMaXe.TextChanged += new System.EventHandler(this.txtMaXe_TextChanged);
            this.txtMaXe.Leave += new System.EventHandler(this.txtMaXe_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Phân Khối:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tên Xe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã Xe:";
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.Silver;
            this.grChucNang.Controls.Add(this.btnTat);
            this.grChucNang.Controls.Add(this.btnXoa);
            this.grChucNang.Controls.Add(this.btnSua);
            this.grChucNang.Controls.Add(this.btnLuu);
            this.grChucNang.Controls.Add(this.btnThem);
            this.grChucNang.Location = new System.Drawing.Point(15, 556);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(1207, 93);
            this.grChucNang.TabIndex = 11;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(735, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 62);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(499, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 62);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Lưu Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(267, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 62);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(65, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 62);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTat
            // 
            this.btnTat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTat.Location = new System.Drawing.Point(966, 25);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(156, 62);
            this.btnTat.TabIndex = 3;
            this.btnTat.Text = "Thoát";
            this.btnTat.UseVisualStyleBackColor = true;
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1296, 661);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmXe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimTenXe;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGiaXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPhanKhoi;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThuoc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTat;
    }
}