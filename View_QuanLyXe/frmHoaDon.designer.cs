namespace QuanLyXe
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.grHD_ChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHD_Xoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHD_Luu = new System.Windows.Forms.Button();
            this.btnHD_ThemHD = new System.Windows.Forms.Button();
            this.grHD_ThongTin = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboTenXe = new System.Windows.Forms.ComboBox();
            this.cboMaXe = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.txtHD_SoLuong = new System.Windows.Forms.TextBox();
            this.txtHD_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtHD_ThanhTien = new System.Windows.Forms.TextBox();
            this.txtHD_DonGia = new System.Windows.Forms.TextBox();
            this.dtpkHD_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.txtHD_PhanKhoi = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grHD_HoaDonInfo = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.grHD_LoaiHoaDon = new System.Windows.Forms.GroupBox();
            this.treHD_LoaiHD = new System.Windows.Forms.TreeView();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grHD_ChucNang.SuspendLayout();
            this.grHD_ThongTin.SuspendLayout();
            this.grHD_HoaDonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.grHD_LoaiHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grHD_ChucNang
            // 
            this.grHD_ChucNang.Controls.Add(this.btnThoat);
            this.grHD_ChucNang.Controls.Add(this.btnHD_Xoa);
            this.grHD_ChucNang.Controls.Add(this.btnSua);
            this.grHD_ChucNang.Controls.Add(this.btnHD_Luu);
            this.grHD_ChucNang.Controls.Add(this.btnHD_ThemHD);
            this.grHD_ChucNang.Location = new System.Drawing.Point(364, 622);
            this.grHD_ChucNang.Name = "grHD_ChucNang";
            this.grHD_ChucNang.Size = new System.Drawing.Size(1213, 82);
            this.grHD_ChucNang.TabIndex = 8;
            this.grHD_ChucNang.TabStop = false;
            this.grHD_ChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyXe.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(909, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 47);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHD_Xoa
            // 
            this.btnHD_Xoa.Image = global::QuanLyXe.Properties.Resources.delete;
            this.btnHD_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_Xoa.Location = new System.Drawing.Point(707, 25);
            this.btnHD_Xoa.Name = "btnHD_Xoa";
            this.btnHD_Xoa.Size = new System.Drawing.Size(144, 47);
            this.btnHD_Xoa.TabIndex = 20;
            this.btnHD_Xoa.Text = "Xóa";
            this.btnHD_Xoa.UseVisualStyleBackColor = true;
            this.btnHD_Xoa.Click += new System.EventHandler(this.btnHD_Xoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyXe.Properties.Resources.settings;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(516, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 47);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = " Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHD_Luu
            // 
            this.btnHD_Luu.Image = global::QuanLyXe.Properties.Resources.save2;
            this.btnHD_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_Luu.Location = new System.Drawing.Point(333, 23);
            this.btnHD_Luu.Name = "btnHD_Luu";
            this.btnHD_Luu.Size = new System.Drawing.Size(144, 47);
            this.btnHD_Luu.TabIndex = 19;
            this.btnHD_Luu.Text = "Thanh Toán";
            this.btnHD_Luu.UseVisualStyleBackColor = true;
            this.btnHD_Luu.Click += new System.EventHandler(this.btnHD_ThanhToan_Click);
            // 
            // btnHD_ThemHD
            // 
            this.btnHD_ThemHD.Image = global::QuanLyXe.Properties.Resources.add_stock;
            this.btnHD_ThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD_ThemHD.Location = new System.Drawing.Point(133, 25);
            this.btnHD_ThemHD.Name = "btnHD_ThemHD";
            this.btnHD_ThemHD.Size = new System.Drawing.Size(144, 47);
            this.btnHD_ThemHD.TabIndex = 16;
            this.btnHD_ThemHD.Text = "Thêm";
            this.btnHD_ThemHD.UseVisualStyleBackColor = true;
            this.btnHD_ThemHD.Click += new System.EventHandler(this.btnHD_ThemHD_Click);
            // 
            // grHD_ThongTin
            // 
            this.grHD_ThongTin.BackColor = System.Drawing.Color.Silver;
            this.grHD_ThongTin.Controls.Add(this.cboMaNV);
            this.grHD_ThongTin.Controls.Add(this.cboTenXe);
            this.grHD_ThongTin.Controls.Add(this.cboMaXe);
            this.grHD_ThongTin.Controls.Add(this.cboMaKH);
            this.grHD_ThongTin.Controls.Add(this.cboTenKH);
            this.grHD_ThongTin.Controls.Add(this.cboLoaiHD);
            this.grHD_ThongTin.Controls.Add(this.txtHD_SoLuong);
            this.grHD_ThongTin.Controls.Add(this.txtHD_MaHoaDon);
            this.grHD_ThongTin.Controls.Add(this.label27);
            this.grHD_ThongTin.Controls.Add(this.label25);
            this.grHD_ThongTin.Controls.Add(this.txtHD_ThanhTien);
            this.grHD_ThongTin.Controls.Add(this.txtHD_DonGia);
            this.grHD_ThongTin.Controls.Add(this.dtpkHD_NgayLapHD);
            this.grHD_ThongTin.Controls.Add(this.txtHD_PhanKhoi);
            this.grHD_ThongTin.Controls.Add(this.label24);
            this.grHD_ThongTin.Controls.Add(this.label1);
            this.grHD_ThongTin.Controls.Add(this.lblMaKH);
            this.grHD_ThongTin.Controls.Add(this.label17);
            this.grHD_ThongTin.Controls.Add(this.label23);
            this.grHD_ThongTin.Controls.Add(this.label19);
            this.grHD_ThongTin.Controls.Add(this.label18);
            this.grHD_ThongTin.Controls.Add(this.label20);
            this.grHD_ThongTin.Controls.Add(this.label21);
            this.grHD_ThongTin.Controls.Add(this.label22);
            this.grHD_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHD_ThongTin.Location = new System.Drawing.Point(243, 271);
            this.grHD_ThongTin.Name = "grHD_ThongTin";
            this.grHD_ThongTin.Size = new System.Drawing.Size(1334, 330);
            this.grHD_ThongTin.TabIndex = 7;
            this.grHD_ThongTin.TabStop = false;
            this.grHD_ThongTin.Text = "THÔNG TIN";
            this.grHD_ThongTin.Enter += new System.EventHandler(this.grHD_ThongTin_Enter);
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(828, 271);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(386, 28);
            this.cboMaNV.TabIndex = 28;
            // 
            // cboTenXe
            // 
            this.cboTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenXe.FormattingEnabled = true;
            this.cboTenXe.Location = new System.Drawing.Point(828, 84);
            this.cboTenXe.Name = "cboTenXe";
            this.cboTenXe.Size = new System.Drawing.Size(386, 28);
            this.cboTenXe.TabIndex = 28;
            // 
            // cboMaXe
            // 
            this.cboMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaXe.FormattingEnabled = true;
            this.cboMaXe.Location = new System.Drawing.Point(828, 36);
            this.cboMaXe.Name = "cboMaXe";
            this.cboMaXe.Size = new System.Drawing.Size(386, 28);
            this.cboMaXe.TabIndex = 28;
            this.cboMaXe.SelectedIndexChanged += new System.EventHandler(this.cboMaXe_SelectedIndexChanged);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(210, 127);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(386, 28);
            this.cboMaKH.TabIndex = 28;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // cboTenKH
            // 
            this.cboTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(210, 174);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(386, 28);
            this.cboTenKH.TabIndex = 28;
            // 
            // cboLoaiHD
            // 
            this.cboLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHD.FormattingEnabled = true;
            this.cboLoaiHD.Location = new System.Drawing.Point(212, 269);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.Size = new System.Drawing.Size(386, 28);
            this.cboLoaiHD.TabIndex = 28;
            // 
            // txtHD_SoLuong
            // 
            this.txtHD_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD_SoLuong.Location = new System.Drawing.Point(826, 227);
            this.txtHD_SoLuong.Name = "txtHD_SoLuong";
            this.txtHD_SoLuong.Size = new System.Drawing.Size(388, 26);
            this.txtHD_SoLuong.TabIndex = 23;
            this.txtHD_SoLuong.Leave += new System.EventHandler(this.txtHD_SoLuong_Leave);
            // 
            // txtHD_MaHoaDon
            // 
            this.txtHD_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD_MaHoaDon.Location = new System.Drawing.Point(210, 36);
            this.txtHD_MaHoaDon.Name = "txtHD_MaHoaDon";
            this.txtHD_MaHoaDon.Size = new System.Drawing.Size(386, 26);
            this.txtHD_MaHoaDon.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(91, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 20);
            this.label27.TabIndex = 20;
            this.label27.Text = "Mã hóa đơn:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(748, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 20);
            this.label25.TabIndex = 18;
            this.label25.Text = "Mã Xe:";
            // 
            // txtHD_ThanhTien
            // 
            this.txtHD_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD_ThanhTien.ForeColor = System.Drawing.Color.DarkGray;
            this.txtHD_ThanhTien.Location = new System.Drawing.Point(210, 224);
            this.txtHD_ThanhTien.Name = "txtHD_ThanhTien";
            this.txtHD_ThanhTien.Size = new System.Drawing.Size(386, 26);
            this.txtHD_ThanhTien.TabIndex = 12;
            // 
            // txtHD_DonGia
            // 
            this.txtHD_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD_DonGia.Location = new System.Drawing.Point(826, 179);
            this.txtHD_DonGia.Name = "txtHD_DonGia";
            this.txtHD_DonGia.Size = new System.Drawing.Size(388, 26);
            this.txtHD_DonGia.TabIndex = 11;
            // 
            // dtpkHD_NgayLapHD
            // 
            this.dtpkHD_NgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkHD_NgayLapHD.Location = new System.Drawing.Point(210, 81);
            this.dtpkHD_NgayLapHD.Name = "dtpkHD_NgayLapHD";
            this.dtpkHD_NgayLapHD.Size = new System.Drawing.Size(386, 26);
            this.dtpkHD_NgayLapHD.TabIndex = 15;
            // 
            // txtHD_PhanKhoi
            // 
            this.txtHD_PhanKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD_PhanKhoi.Location = new System.Drawing.Point(826, 127);
            this.txtHD_PhanKhoi.Name = "txtHD_PhanKhoi";
            this.txtHD_PhanKhoi.Size = new System.Drawing.Size(388, 26);
            this.txtHD_PhanKhoi.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(83, 269);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Loại hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã NV:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(117, 130);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(61, 20);
            this.lblMaKH.TabIndex = 8;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(100, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "Thành tiền:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(52, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Ngày lập hóa đơn:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(731, 233);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Số lượng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(61, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Tên khách hàng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(722, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Phân Khối:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(739, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Đơn giá:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(743, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Tên Xe:";
            // 
            // grHD_HoaDonInfo
            // 
            this.grHD_HoaDonInfo.BackColor = System.Drawing.Color.Silver;
            this.grHD_HoaDonInfo.Controls.Add(this.dgvChiTietHD);
            this.grHD_HoaDonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHD_HoaDonInfo.Location = new System.Drawing.Point(243, 0);
            this.grHD_HoaDonInfo.Name = "grHD_HoaDonInfo";
            this.grHD_HoaDonInfo.Size = new System.Drawing.Size(1334, 265);
            this.grHD_HoaDonInfo.TabIndex = 6;
            this.grHD_HoaDonInfo.TabStop = false;
            this.grHD_HoaDonInfo.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(17, 26);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.Size = new System.Drawing.Size(1255, 221);
            this.dgvChiTietHD.TabIndex = 0;
            this.dgvChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHD_CellClick);
            // 
            // grHD_LoaiHoaDon
            // 
            this.grHD_LoaiHoaDon.BackColor = System.Drawing.Color.Silver;
            this.grHD_LoaiHoaDon.Controls.Add(this.treHD_LoaiHD);
            this.grHD_LoaiHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHD_LoaiHoaDon.Location = new System.Drawing.Point(1, 0);
            this.grHD_LoaiHoaDon.Name = "grHD_LoaiHoaDon";
            this.grHD_LoaiHoaDon.Size = new System.Drawing.Size(236, 601);
            this.grHD_LoaiHoaDon.TabIndex = 5;
            this.grHD_LoaiHoaDon.TabStop = false;
            this.grHD_LoaiHoaDon.Text = "LOẠI HÓA ĐƠN";
            // 
            // treHD_LoaiHD
            // 
            this.treHD_LoaiHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treHD_LoaiHD.Location = new System.Drawing.Point(3, 22);
            this.treHD_LoaiHD.Name = "treHD_LoaiHD";
            this.treHD_LoaiHD.Size = new System.Drawing.Size(230, 576);
            this.treHD_LoaiHD.TabIndex = 0;
            this.treHD_LoaiHD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treHD_LoaiHD_AfterSelect);
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "bill.png");
            this.imgTree.Images.SetKeyName(1, "bil.png");
            this.imgTree.Images.SetKeyName(2, "receipt.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(12, 633);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(59, 18);
            this.lblTimKiem.TabIndex = 8;
            this.lblTimKiem.Text = "Mã HD:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(108, 633);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(208, 26);
            this.txtTimKiem.TabIndex = 21;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLyXe.Properties.Resources.search_invoice;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(108, 669);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(188, 38);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.grHD_ChucNang);
            this.Controls.Add(this.grHD_ThongTin);
            this.Controls.Add(this.grHD_HoaDonInfo);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grHD_LoaiHoaDon);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoa Don";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grHD_ChucNang.ResumeLayout(false);
            this.grHD_ThongTin.ResumeLayout(false);
            this.grHD_ThongTin.PerformLayout();
            this.grHD_HoaDonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.grHD_LoaiHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grHD_ChucNang;
        private System.Windows.Forms.Button btnHD_Xoa;
        private System.Windows.Forms.Button btnHD_Luu;
        private System.Windows.Forms.Button btnHD_ThemHD;
        private System.Windows.Forms.GroupBox grHD_ThongTin;
        private System.Windows.Forms.TextBox txtHD_MaHoaDon;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtHD_ThanhTien;
        private System.Windows.Forms.TextBox txtHD_DonGia;
        private System.Windows.Forms.TextBox txtHD_PhanKhoi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grHD_HoaDonInfo;
        private System.Windows.Forms.GroupBox grHD_LoaiHoaDon;
        private System.Windows.Forms.TreeView treHD_LoaiHD;
        private System.Windows.Forms.ImageList imgTree;
        public System.Windows.Forms.DateTimePicker dtpkHD_NgayLapHD;
        private System.Windows.Forms.TextBox txtHD_SoLuong;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.ComboBox cboLoaiHD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboMaXe;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.ComboBox cboTenXe;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}