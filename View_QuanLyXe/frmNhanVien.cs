using System;
using QuanLyXe;
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



namespace QuanLyXe

{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien nvBus = new BUS_NhanVien();
        private void NhânVien_Load(object sender, EventArgs e)
        {
            
            LoadData_TTNV();
            btnThem.Enabled = true;
        }
        #region Loaddata
        private void LoadData_TTNV()
        {
            dtgvTTNV_Show.Rows.Clear();
            List<DTO_NhanVien> lstnv = nvBus.getAllNhanVien();
            foreach (var item in lstnv)
            {
                string sex = item.StrGioiTinh == true.ToString() ? "Nam" : "Nu";
                dtgvTTNV_Show.Rows.Add(item.StrMaNV, item.StrTenNV, item.DTNgaySinh, item.StrCMND, item.StrSDT, item.StrDiaChi, sex);
                dtgvTTNV_Show.Rows[dtgvTTNV_Show.RowCount - 1].Tag = item;
            }
            txtTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSex.Enabled = false;
            txtTimKiem.Focus();
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            restTTNV();

        }


        private void dtgvTTNV_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTTNV_Show.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtNgaySinh.Text = row.Cells[2].Value.ToString();
                txtCMND.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString().Trim();
                txtSex.Text = row.Cells[6].Value.ToString();
            }
            hienTxt();
            btnLuuSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNV.Enabled = false;
        }
        private void LoadDataTTNV(List<DTO_NhanVien> lstnv)
        {
            dtgvTTNV_Show.Rows.Clear();
            foreach (var item in lstnv)
            {
                string sex = item.StrGioiTinh == true.ToString() ? "Nam" : "Nu";
                dtgvTTNV_Show.Rows.Add(item.StrMaNV, item.StrTenNV, item.DTNgaySinh, item.StrCMND, item.StrSDT, item.StrDiaChi, sex);
                dtgvTTNV_Show.Rows[dtgvTTNV_Show.RowCount - 1].Tag = item;
            }

            dtgvTTNV_Show.ClearSelection();
            AnTxt();
            restTTNV();
        }
        private void restTTNV()
        {
            dtgvTTNV_Show.ClearSelection();
            restTxtTTNV();
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnLuuSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }
        private void AnTxt()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            txtSex.Enabled = false;
            txtNgaySinh.Enabled = false;
        }
        private void hienTxt()
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtSex.Enabled = true;
            txtNgaySinh.Enabled = true;
        }
        private void restTxtTTNV()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
            txtSex.Clear();
            txtNgaySinh.Clear();
        }
        #endregion


        #region Events
        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSex.Text == "" || txtNgaySinh.Text == "" ||
                txtSDT.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.StrMaNV = txtMaNV.Text;
                nv.StrTenNV = txtTenNV.Text;
                nv.StrDiaChi = txtDiaChi.Text;
                nv.DTNgaySinh = Convert.ToDateTime(txtNgaySinh.Text);
                nv.StrSDT = txtSDT.Text;
                nv.StrCMND = txtCMND.Text;
                nv.StrGioiTinh = txtSex.Text;
                nvBus.editNhanVien(nv);
                if (nvBus.editNhanVien(nv))
                {
                    MessageBox.Show("Sua thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTNV();
                    restTxtTTNV(); //note
                    LoadData_TTNV();//note
                    errorProvider1.Clear();//note
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData_TTNV();
            btnThem.Enabled = true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                var lstnv = nvBus.getAllNhanVien();
                if (!string.IsNullOrEmpty(txtTimKiem.Text) && radTimTheoTen.Checked == true)
                {
                    var tenNV = txtTimKiem.Text.ToUpper();
                    lstnv = lstnv.Where(t => t.StrTenNV.ToUpper().Contains(tenNV)).ToList();
                }
                else
                {
                    var maNV = txtTimKiem.Text.ToUpper();
                    lstnv = lstnv.Where(t => t.StrMaNV.ToUpper().Contains(maNV)).ToList();

                }
                LoadDataTTNV(lstnv);
                txtTimKiem.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng dữ liệu vào", "Thông báo");
            }
            AnTxt();
            btnThem.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Hủy Thêm";
                btnLuu.Enabled = true;
                txtTenNV.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                txtCMND.Enabled = true;
                txtSex.Enabled = true;
                txtMaNV.Enabled = true;
                txtNgaySinh.Enabled = true;
            }
            else if (btnThem.Text == "Hủy Thêm")
            {
                //errorProvider1.Clear();
                AnTxt();
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                txtTimKiem.Focus();
            }
            //errorProvider1.Clear();
            btnXoa.Enabled = false;
            btnLuuSua.Enabled = false;
            restTxtTTNV();
            txtMaNV.Focus();
            dtgvTTNV_Show.ClearSelection();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSex.Text == "" || txtNgaySinh.Text == "" ||
                txtSDT.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();
            }
            else if (checkAnHienTextBoxTTNV() && checkEmpty() && checkRegexTTNV())
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.StrMaNV = txtMaNV.Text;
                nv.StrTenNV = txtTenNV.Text;
                nv.StrDiaChi = txtDiaChi.Text;
                nv.DTNgaySinh = Convert.ToDateTime(txtNgaySinh.Text);
                nv.StrSDT = txtSDT.Text;
                nv.StrCMND = txtCMND.Text;
                nv.StrGioiTinh = txtSex.Text;
                if (nvBus.addNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTNV();
                    restTxtTTNV(); //note
                    LoadData_TTNV();//note
                    errorProvider1.Clear();//note
                }
            }


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //----------------
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    bool kq = nvBus.deleteNhanVien(txtMaNV.Text);
                    if (kq == true)
                    {
                        h = MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_TTNV();
                        AnTxt();

                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            restTxtTTNV();
            txtTimKiem.Focus();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnLuuSua.Enabled = false;
        }
        #endregion
        #region Check
        private bool checkAnHienTextBoxTTNV()
        {
            if (txtTenNV.Enabled &&
            txtDiaChi.Enabled &&
            txtSDT.Enabled &&
            txtCMND.Enabled)
                return true;
            else
                return false;
        }
        private void KiemTraTrong()
        {
            if (txtMaNV.Text == "")
            {
                errorProvider1.SetError(txtMaNV, "Không được bỏ trống");
                txtMaNV.Focus();
            }
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Không được bỏ trống");
                txtTenNV.Focus();
            }
            if (txtNgaySinh.Text == "")
            {
                errorProvider1.SetError(txtNgaySinh, "Không được bỏ trống");
                txtNgaySinh.Focus();
            }
            if (txtCMND.Text == "")
            {
                errorProvider1.SetError(txtCMND, "Không được bỏ trống");
                txtCMND.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống");
                txtDiaChi.Focus();
            }
            if (txtSex.Text == "")
            {
                errorProvider1.SetError(txtSex, "Không được bỏ trống");
                txtSex.Focus();
            }
            if (txtSex.Text == "")
            {
                errorProvider1.SetError(txtSDT, "Không được bỏ trống");
                txtSDT.Focus();
            }
        }
        public bool GioiTinhCheck(string s)
        {
            if (s.Contains("nam") || s.Contains("nu"))
                return true;
            else
                return false;
        }
        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {
            //if (checkAnHienTextBoxTTNV())
            //{
            //    string s = txtSex.Text.Trim();
            //    if (!GioiTinhCheck(s))
            //    {
            //        errorProvider1.SetError(txtSex, "Giới tính nhập nam hoặc nữ ");
            //        txtSex.Focus();
            //    }
            //    else
            //        errorProvider1.Clear();
            //}
        }
        public bool PhoneCheck(String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[0-9]{7})$").Success;
        }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTNV())
            {
                string s = txtSDT.Text.Trim();
                if (!PhoneCheck(s))
                {
                    errorProvider1.SetError(txtSDT, "Bạn phải nhập số điện thoại đúng định dạng ");
                    txtSDT.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        public bool CMNDCheck(String s)
        {
            return Regex.Match(s, @"^([0-9]{9})$").Success;
        }
        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTNV())
            {
                string s = txtCMND.Text.Trim();
                if (!CMNDCheck(s))
                {
                    errorProvider1.SetError(txtCMND, "Bạn phải nhập số CMND đúng định dạng ");
                    txtCMND.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }

        public bool AddrressCheck(String s)
        {
            return Regex.Match(s, @"^[^{}+=?!@#$%`~^&\*()]+$").Success;
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTNV())
            {
                string s = txtDiaChi.Text.Trim();
                if (!AddrressCheck(s))
                {
                    errorProvider1.SetError(txtDiaChi, "Bạn phải nhập số địa chỉ đúng định dạng ");
                    txtDiaChi.Focus();
                }
                else
                    errorProvider1.Clear();
            }

        }
        public bool TenCheck(String s)
        {
            return Regex.Match(s, @"^[^.?!@#$`~%^&*+=_()1234567890/\,<>]+$").Success;
        }
        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTNV())
            {
                string s = txtTenNV.Text.Trim();
                if (!TenCheck(s))
                {
                    errorProvider1.SetError(txtTenNV, "Bạn phải nhập tên đúng định dạng ");
                    txtTenNV.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        private bool checkRegexTTNV()
        {
            string s1 = txtTenNV.Text.Trim();
            string s2 = txtDiaChi.Text.Trim();
            string s3 = txtSDT.Text.Trim();
            string s4 = txtCMND.Text.Trim();
            if (!TenCheck(s1) && !PhoneCheck(s3) && !AddrressCheck(s2))
            {
                return false;
            }
            else
                return true;
        }
        public bool checkEmpty()
        {
            if (txtTenNV.Text.Equals(""))
            {
                errorProvider1.SetError(txtTenNV, "Bạn phải nhập tên khách hàng!");
                txtTenNV.Focus();
                return false;

            }
            else
            {
                errorProvider1.Clear();
                if (txtDiaChi.Text.Equals(""))
                {
                    errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ!");
                    txtDiaChi.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.Clear();
                    if (txtSDT.Text.Equals(""))
                    {
                        errorProvider1.SetError(txtSDT, "Bạn phải nhập số điện thoại!");
                        txtSDT.Focus();
                        return false;

                    }
                    else
                    {
                        errorProvider1.Clear();
                        return true;
                        

                    }
                }
            }
        }
        public bool checkMaNV(string maNV)
        {
            return Regex.Match(maNV, @"^[A-Z0-9]+$").Success;
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTNV())
            {
                string s = txtMaNV.Text.Trim();
                if (!checkMaNV(s))
                {
                    errorProvider1.SetError(txtMaNV, "Bạn phải nhập mã đúng định dạng ");
                    txtMaNV.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        #endregion

        private void btnTat_Click(object sender, EventArgs e)
        {
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}




        