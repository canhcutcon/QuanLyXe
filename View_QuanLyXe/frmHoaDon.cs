using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyXe;
using DTO_QuanLyXe;
using DAO_QuanLyXe;
using System.Text.RegularExpressions;
using QuanLyXe.Regular_Expression;

namespace QuanLyXe
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        BUS_ChiTietHoaDon BusChitietHD;
        TreeNode nGoc;
        BUS_LoaiHD Buslhd;
        BUS_HoaDon BusHd = new BUS_HoaDon();
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_Xe busxe = new BUS_Xe();
        BUS_NhanVien busnv = new BUS_NhanVien();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnHD_Luu.Enabled = false;
            btnHD_Xoa.Enabled = false;
            btnHD_ThemHD.Enabled = true;
            btnSua.Enabled = true;
            nGoc = new TreeNode("LOẠI HÓA ĐƠN");
            TreeNode root = new TreeNode();
            root.Text = "HÓA ĐƠN";
            BusChitietHD = new BUS_ChiTietHoaDon();
            Buslhd = new BUS_LoaiHD();
            treHD_LoaiHD.ImageList = imgTree;
            IEnumerable<LOAIHD> dslhd = Buslhd.getInforLoaiHD();
            loadLoaiHoaDonToTree(treHD_LoaiHD, dslhd);
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void loadLoaiHoaDonToTree(TreeView tre, IEnumerable<LOAIHD> dslhd)
        {
            tre.Nodes.Clear();
            nGoc.Nodes.Clear();//xoa cac con
            TreeNode nCon;
            TreeNode root = new TreeNode();
            root.Text = "HÓA ĐƠN";
            tre.Nodes.Add(root);
            foreach (LOAIHD p in dslhd)
            {
                nCon = new TreeNode();
                nCon.ImageIndex = 1;
                nCon.Text = p.TENLOAIHD;
                nCon.Tag = p.MALOAIHD;
                nGoc.Nodes.Add(nCon);
            }
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();
        }

        private void treHD_LoaiHD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            BUS_ChiTietHoaDon cthd = new BUS_ChiTietHoaDon();
            string StrMaLoai = "";
            treHD_LoaiHD.ImageIndex = 2;
            if (treHD_LoaiHD.SelectedNode.Text.Equals("HÓA ĐƠN"))
            {
                dgvChiTietHD.DataSource = BusHd.getAllHoadon();
            }
            else if (treHD_LoaiHD.SelectedNode != null)
            {
                if (treHD_LoaiHD.SelectedNode.Level == 0)
                {
                    StrMaLoai = "";
                }
                else
                {
                    StrMaLoai = treHD_LoaiHD.SelectedNode.Tag.ToString();
                }
                dgvChiTietHD.DataSource = cthd.getAllChiTietHD(StrMaLoai);
            }
            loadCbo();
        }

        public void loadCbo()
        {
            IEnumerable<LOAIHD> lstLHD = Buslhd.getInforLoaiHD();
            List<string> lstTenLoai = new List<string>();
            foreach (LOAIHD item in lstLHD)
            {
                lstTenLoai.Add(item.MALOAIHD);
            }
            // lstLHD.ToList();
            //// string StrTemp1 = "", StrTemp2 = "";
            // foreach(var q in lstLHD)
            // {

            // }    
            cboLoaiHD.DisplayMember = "MALOAIHD";
            cboLoaiHD.ValueMember = "TENLOAIHD";
            cboLoaiHD.DataSource = lstLHD.ToList();

            List<DTO_KhachHang> lstKh = buskh.getDanhSachKhachHang();
            List<string> lsttenkh = new List<string>() { " " };
            List<string> lstmakh = new List<string>() { " " };
            foreach (DTO_KhachHang item in lstKh)
            {
                lsttenkh.Add(item.StrTenKH);
                lstmakh.Add(item.StrMaKH);
            }
            cboTenKH.DataSource = lsttenkh;
            cboMaKH.DataSource = lstmakh;


            List<DTO_Xe> lstxe = busxe.getsDanhSachXe();
            List<string> lstmaxe = new List<string>() { " " };
            List<string> lssttenxe = new List<string>() { " " };
            foreach (DTO_Xe item in lstxe)
            {
                lstmaxe.Add(item.StrMaXe);
                lssttenxe.Add(item.StrTenXe);
            }
            cboMaXe.DataSource = lstmaxe;
            cboTenXe.DataSource = lssttenxe;

            List<DTO_NhanVien> lstnv = busnv.getDanhSachNhanVien();
            List<string> lstNV = new List<string>() { " " };
            foreach (DTO_NhanVien item in lstnv)
            {
                lstNV.Add(item.StrMaNV);
            }
            cboMaNV.DataSource = lstNV;
        }

        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((treHD_LoaiHD.SelectedNode.Text.Equals("HÓA ĐƠN NHẬP")) || (treHD_LoaiHD.SelectedNode.Text.Equals("HÓA ĐƠN XUẤT")))
                {
                    if (e.RowIndex >= 0)
                    {
                        btnSua.Enabled = true;
                        hienThongTinHD();
                        txtHD_MaHoaDon.Enabled = false;
                        txtHD_ThanhTien.Enabled = false;
                        cboTenXe.Enabled = false;
                        txtHD_PhanKhoi.Enabled = false;
                        cboMaNV.Enabled = false;
                        cboMaKH.Enabled = false;
                        cboTenKH.Enabled = false;
                        cboLoaiHD.Enabled = false;
                        dtpkHD_NgayLapHD.Enabled = false;
                        btnHD_Xoa.Enabled = true;
                        btnHD_ThemHD.Enabled = true;
                        DataGridViewRow row = this.dgvChiTietHD.Rows[e.RowIndex];
                        txtHD_MaHoaDon.Text = row.Cells[0].Value.ToString();
                        cboMaXe.Text = row.Cells[1].Value.ToString();
                        cboTenKH.Text = row.Cells[2].Value.ToString();
                        cboMaKH.Text = row.Cells[3].Value.ToString();
                        dtpkHD_NgayLapHD.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                        cboLoaiHD.Text = row.Cells[5].Value.ToString();
                        cboTenXe.Text = row.Cells[6].Value.ToString();
                        txtHD_PhanKhoi.Text = row.Cells[7].Value.ToString();
                        txtHD_DonGia.Text = row.Cells[8].Value.ToString();
                        txtHD_SoLuong.Text = row.Cells[9].Value.ToString();
                        txtHD_ThanhTien.Text = row.Cells[10].Value.ToString();
                        cboMaNV.Text = row.Cells[11].Value.ToString();
                    }
                }
                else if (treHD_LoaiHD.SelectedNode.Text.Equals("LOẠI HÓA ĐƠN"))
                {
                    khoaThongTinHD();
                    btnHD_Xoa.Enabled = true;
                    btnHD_ThemHD.Enabled = true;
                    DataGridViewRow row = this.dgvChiTietHD.Rows[e.RowIndex];
                    txtHD_MaHoaDon.Text = row.Cells[0].Value.ToString();
                    cboMaXe.Text = row.Cells[1].Value.ToString();
                    cboTenKH.Text = row.Cells[2].Value.ToString();
                    cboMaKH.Text = row.Cells[3].Value.ToString();
                    dtpkHD_NgayLapHD.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                    cboLoaiHD.Text = row.Cells[5].Value.ToString();
                    cboTenXe.Text = row.Cells[6].Value.ToString();
                    txtHD_PhanKhoi.Text = row.Cells[7].Value.ToString();
                    txtHD_DonGia.Text = row.Cells[8].Value.ToString();
                    txtHD_SoLuong.Text = row.Cells[9].Value.ToString();
                    txtHD_ThanhTien.Text = row.Cells[10].Value.ToString();
                    cboMaNV.Text = row.Cells[11].Value.ToString();
                }
                else if (treHD_LoaiHD.SelectedNode.Text.Equals("HÓA ĐƠN"))
                {
                    txtHD_ThanhTien.Enabled = false;
                    txtHD_MaHoaDon.Enabled = false;
                    cboLoaiHD.Enabled = false;
                    cboTenKH.Enabled = false;
                    cboMaKH.Enabled = false;
                    cboMaXe.Enabled = false;
                    cboTenXe.Enabled = false;
                    txtHD_PhanKhoi.Enabled = false;
                    txtHD_SoLuong.Enabled = false;
                    txtHD_DonGia.Enabled = false;
                    btnHD_Xoa.Enabled = true;
                    btnHD_ThemHD.Enabled = true;
                    DataGridViewRow row = this.dgvChiTietHD.Rows[e.RowIndex];
                    txtHD_MaHoaDon.Text = row.Cells[0].Value.ToString();
                    dtpkHD_NgayLapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                    cboMaNV.Text = row.Cells[2].Value.ToString();
                    cboMaKH.Text = row.Cells[3].Value.ToString();
                    txtHD_ThanhTien.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception )
            {

            }
        }

        private void restTxtHD()
        {
            txtHD_MaHoaDon.Clear();
            cboMaXe.Text = "";
            txtHD_DonGia.Clear();
            txtHD_PhanKhoi.Clear();
            txtHD_SoLuong.Clear();
            cboTenKH.Text = "";
            cboTenXe.Text = "";
            txtHD_ThanhTien.Text = "Đơn giá * Số lượng";
            cboMaKH.Text = "";
            cboMaNV.Text = "";
            dtpkHD_NgayLapHD.Value = DateTime.Now;
            cboLoaiHD.Text = "";
        }

        private void khoaThongTinHD()
        {
            txtHD_MaHoaDon.Enabled = false;
            cboMaXe.Enabled = false;
            txtHD_DonGia.Enabled = false;
            txtHD_PhanKhoi.Enabled = false;
            txtHD_SoLuong.Enabled = false;
            cboTenKH.Enabled = false;
            cboTenXe.Enabled = false;
            txtHD_ThanhTien.Enabled = false;
            cboMaKH.Enabled = false;
            dtpkHD_NgayLapHD.Enabled = false;
            cboLoaiHD.Enabled = false;
            cboMaNV.Enabled = false;
        }

        private void hienThongTinHD()
        {
            cboMaXe.Enabled = true;
            txtHD_SoLuong.Enabled = true;
            txtHD_MaHoaDon.Enabled = true;
            dtpkHD_NgayLapHD.Enabled = true;
            txtHD_DonGia.Enabled = true;
            cboTenXe.Enabled = true;
            txtHD_PhanKhoi.Enabled = true;
            cboLoaiHD.Enabled = true;
            cboTenKH.Enabled = true;
            cboMaKH.Enabled = true;
            cboMaNV.Enabled = true;
            txtHD_ThanhTien.Enabled = false;
        }

        CheckHD checkHD = new CheckHD();
        BUS_HoaDon Bhd = new BUS_HoaDon();
        BUS_Xe Bxe = new BUS_Xe();
        private void btnHD_ThemHD_Click(object sender, EventArgs e)
        {
            if (!btnHD_ThemHD.Text.Equals("Hủy Thêm"))
            {
                btnHD_Luu.Enabled = true;
                btnSua.Enabled = false;
                btnHD_Xoa.Enabled = false;
                btnHD_ThemHD.Text = "Hủy Thêm";
                restTxtHD();
                hienThongTinHD();
            }
            else
            {
                btnHD_Luu.Enabled = false;
                btnHD_ThemHD.Text = "Thêm";
                btnSua.Enabled = true;
            }
        }

        private bool CheckEmpty_HD()
        {
            if (txtHD_MaHoaDon.Text.Equals(""))
            {
                errorProvider1.SetError(txtHD_MaHoaDon, "Bạn phải nhập mã hóa đơn");
                txtHD_MaHoaDon.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (cboLoaiHD.Text.Equals(""))
                {
                    errorProvider1.SetError(cboLoaiHD, "Bạn phải chọn loại hóa đơn");
                    cboTenKH.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                    if (cboTenKH.Text.Equals(""))
                    {
                        errorProvider1.SetError(cboTenKH, "Bạn phải chọn họ tên KH");
                        cboTenKH.Focus();
                        return false;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        if (cboMaKH.Text.Equals(""))
                        {
                            errorProvider1.SetError(cboMaKH, "Bạn phải chọn họ tên KH");
                            cboTenKH.Focus();
                            return false;
                        }
                        else
                        {
                            errorProvider1.Clear();
                            if (txtHD_SoLuong.Text.Equals(""))
                            {
                                errorProvider1.SetError(txtHD_SoLuong, "Bạn phải nhập số lượng");
                                txtHD_SoLuong.Focus();
                                return false;
                            }
                            else
                            {
                                errorProvider1.Clear();
                                if (txtHD_DonGia.Text.Equals(""))
                                {
                                    errorProvider1.SetError(txtHD_DonGia, "Bạn phải nhập đơn giá");
                                    cboTenKH.Focus();
                                    return false;
                                }
                                else
                                {
                                    errorProvider1.Clear();
                                    if (cboMaNV.Text.Equals(""))
                                    {
                                        errorProvider1.SetError(cboMaNV, "Bạn phải chọn mã nhân viên");
                                        cboMaNV.Focus();
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
                return true;
            }

        }

        private void btnHD_ThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckEmpty_HD())
            {
                errorProvider1.Clear();
                if (checkHD.checkRegex(txtHD_SoLuong.Text))
                {
                    DTO_HoaDon hd = new DTO_HoaDon();
                    DTO_ChiTietHoaDon cthd = new DTO_ChiTietHoaDon();

                    errorProvider1.Clear();
                    hd.StrMaHD = txtHD_MaHoaDon.Text;
                    hd.StrMaKH = cboMaKH.Text;
                    hd.StrMaNV = cboMaNV.Text;
                    hd.StrLoaiHD = cboLoaiHD.Text;
                    hd.DTNgayLapHD = dtpkHD_NgayLapHD.Value;
                    hd.ITongTien = Convert.ToInt32(txtHD_ThanhTien.Text);

                    cthd.StrMaHD = txtHD_MaHoaDon.Text;
                    cthd.StrMaXe = cboMaXe.Text;
                    cthd.ISoLuong = Convert.ToInt32(txtHD_SoLuong.Text);
                    cthd.IDonGia = Convert.ToInt32(txtHD_DonGia.Text);
                    cthd.IThanhTien = Convert.ToInt32(txtHD_ThanhTien.Text);

                    if (BusHd.addHoaDon(hd, cthd))
                    {
                        MessageBox.Show("Thanh toán thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán Thất bại!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    errorProvider1.SetError(txtHD_SoLuong, "Chỉ được nhập số.");
                    txtHD_SoLuong.Focus();
                }
            }
        }

        private void loadData_HoaDon()
        {
            dgvChiTietHD.DataSource = null;
            dgvChiTietHD.DataSource = BusChitietHD.getAllChiTietHD("");
            loadTree();
            loadCbo();
            restTxtHD();
            khoaThongTinHD();
            btnHD_Luu.Enabled = false;
            btnHD_Xoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void loadTree()
        {
            btnHD_Luu.Enabled = false;
            btnHD_Xoa.Enabled = false;
            btnHD_ThemHD.Enabled = true;
            khoaThongTinHD();
            nGoc = new TreeNode("LOẠI HÓA ĐƠN");
            BusChitietHD = new BUS_ChiTietHoaDon();
            Buslhd = new BUS_LoaiHD();
            treHD_LoaiHD.ImageList = imgTree;
            IEnumerable<LOAIHD> dslhd = Buslhd.getInforLoaiHD();
            loadLoaiHoaDonToTree(treHD_LoaiHD, dslhd);
        }
        public void loadFormHoaDon()
        {
            dgvChiTietHD.DataSource = null;



        }

        private void btnHD_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgHoiXoa;
                if (dgvChiTietHD.SelectedCells.Count > 0)
                {
                    dlgHoiXoa = MessageBox.Show("Bạn chắc xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dlgHoiXoa == DialogResult.Yes)
                    {
                        errorProvider1.Clear();
                        bool hd = BusHd.deleteHoaDon(txtHD_MaHoaDon.Text);
                        if (hd == true)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData_HoaDon();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Không Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (treHD_LoaiHD.SelectedNode.Text.Equals("HÓA ĐƠN"))
                {
                    restTxtHD();
                    btnHD_ThemHD.Enabled = false;
                    btnSua.Enabled = true;
                    DTO_HoaDon hd = TaoHD();
                    errorProvider1.Clear();
                    if (BusHd.editHoaDon(hd))
                    {
                        MessageBox.Show("Sửa Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    btnHD_ThemHD.Enabled = false;
                    DTO_ChiTietHoaDon cthd = TaoChiTietHD();
                    errorProvider1.Clear();
                    if (BusChitietHD.editChiTietHoaDon(cthd))
                    {
                        MessageBox.Show("Sửa Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin thay đổi chưa đúng!");
            }
        }

        private DTO_HoaDon TaoHD()
        {
            DTO_HoaDon hd = new DTO_HoaDon();
            hd.StrMaHD = txtHD_MaHoaDon.Text;
            hd.DTNgayLapHD = dtpkHD_NgayLapHD.Value;
            hd.StrMaNV = cboMaNV.Text;
            return hd;
        }

        DTO_ChiTietHoaDon TaoChiTietHD()
        {
            DTO_ChiTietHoaDon ct = new DTO_ChiTietHoaDon();
            ct.StrMaHD = txtHD_MaHoaDon.Text;
            ct.StrMaXe = cboMaXe.Text;
            ct.ISoLuong = int.Parse(txtHD_SoLuong.Text);
            ct.IDonGia = int.Parse(txtHD_DonGia.Text);
            ct.IThanhTien = int.Parse(txtHD_ThanhTien.Text);
            //ct.MAHD = treHD_LoaiHD.SelectedNode.Tag.ToString();
            return ct;
        }

        private void txtHD_SoLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtHD_SoLuong.Text);
                int b = Convert.ToInt32(txtHD_DonGia.Text);
                int c = a * b;
                txtHD_ThanhTien.Text = Convert.ToString(c);
            }
            catch (Exception)
            {

            }
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKH.Text != "")
            {
                string makh = cboMaKH.Text;
                IEnumerable<KHACHHANG> kh = buskh.getTenXeTheoMaKH(makh);
                //List<string> lstxe = new List<string> { " " };
                foreach (KHACHHANG item in kh)
                {
                    if (item.MAKH == makh)
                    {
                        cboTenKH.Text = item.TENKH;
                    }
                }
            }
        }

        private void cboMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaXe.Text != "")
            {
                string maxe = cboMaXe.Text;
                IEnumerable<XE> xe = busxe.getTenXeTheoMaXe(maxe);
                //List<string> lstxe = new List<string> { " " };
                foreach (XE item in xe)
                {
                    if (item.MAXE == maxe)
                    {
                        cboTenXe.Text = item.TENXE;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                AppliedFilter();
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu!", "Thông báo");
            }
        }

        BUS_ChiTietHoaDon BusCTHD = new BUS_ChiTietHoaDon();
        private void AppliedFilter()
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dgvChiTietHD.DataSource = null;
                dgvChiTietHD.DataSource = BusChitietHD.getInforTimKiem(txtTimKiem.Text);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadFormHoaDon();
                IEnumerable<CHITIETHD> lsthd = BusChitietHD.getInforCTHD();
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (CHITIETHD ct in lsthd)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(ct.MAHD.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            if (dgvChiTietHD.SelectedCells.Count > 0)
            {
                dlgHoiXoa = MessageBox.Show("Bạn cos muốn thoát?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void grHD_ThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
