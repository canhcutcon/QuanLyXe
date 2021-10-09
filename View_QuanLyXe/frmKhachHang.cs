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
using DAO_QuanLyXe;
using DTO_QuanLyXe;
using System.Text.RegularExpressions;

namespace QuanLyXe
{
    public partial class frmKhachHang : Form
    {
        BUS_QuanLyXe.BUS_KhachHang khBUS = new BUS_QuanLyXe.BUS_KhachHang();
        
        public frmKhachHang()
        {
            InitializeComponent();
        }
        
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData_TTKH();
        }

        #region ThongTinKhachHang
        #region LoadData
        private void LoadData_TTKH()
        {
            dtgvTTKH_Show.Rows.Clear();
            List<DTO_KhachHang> lstkh = khBUS.getAllKhachHang();
            foreach (var item in lstkh)
            {
                dtgvTTKH_Show.Rows.Add(item.StrMaKH, item.StrTenKH, item.StrDiaChi, item.StrSoDienThoai, item.StrCMND);
                dtgvTTKH_Show.Rows[dtgvTTKH_Show.RowCount - 1].Tag = item;
            }
            txtTenKhachHang.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            txtTimKiem.Focus();
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            restTTKH();
        }
        private void dtgvTTKH_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTTKH_Show.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtCMND.Text = row.Cells[4].Value.ToString();
            }
            hienTextBoxTTKH();
            btnTTKH_Sua.Enabled = true;
            btnTTKH_Xoa.Enabled = true;
        }
       
        private void LoadDataTTKH(List<DTO_KhachHang> lstkh)
        {
            dtgvTTKH_Show.Rows.Clear();
            foreach (var item in lstkh)
            {
                dtgvTTKH_Show.Rows.Add(item.StrMaKH, item.StrTenKH, item.StrDiaChi, item.StrSoDienThoai, item.StrCMND);
                dtgvTTKH_Show.Rows[dtgvTTKH_Show.RowCount - 1].Tag = item;
            }

            dtgvTTKH_Show.ClearSelection();
            AnTxt();
            restTTKH();
        }
        #endregion
        #region Format
        private void restTTKH()
        {
            dtgvTTKH_Show.ClearSelection();
            restTxtTTKH();
            txtMaKhachHang.Enabled = false;
            btnTTKH_Luu.Enabled = false;
            btnTTKH_Xoa.Enabled = false;
            btnTTKH_Sua.Enabled = false;
            btnTTKH_Them.Text = "Thêm";
        }
        private void AnTxt()
        {
            txtMaKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtCMND.Enabled = false;
        }
        private void restTxtTTKH()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtCMND.Clear();
            //txtTimKiem.Focus();
        }
        private void anTextBoxTTKH()
        {
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtCMND.Enabled = false;
            errorProvider1.Clear();
        }
        private void hienTextBoxTTKH()
        {
            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtCMND.Enabled = true;
            //txtTimKiem.Focus();
        }
        private bool checkAnHienTextBoxTTKH()
        {
            if (txtTenKhachHang.Enabled &&
            txtDiaChi.Enabled &&
            txtSoDienThoai.Enabled &&
            txtCMND.Enabled)
                return true;
            else
                return false;
        }
        #endregion

        #region Event
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                var lstKH = khBUS.getAllKhachHang();
                if (!string.IsNullOrEmpty(txtTimKiem.Text) && radTimTheoTen.Checked == true)
                {
                    var tenKH = txtTimKiem.Text.ToUpper();
                    lstKH = lstKH.Where(t => t.StrTenKH.ToUpper().Contains(tenKH)).ToList();
                }
                else
                {
                    var sdt = txtTimKiem.Text.ToUpper();
                    lstKH = lstKH.Where(t => t.StrSoDienThoai.ToUpper().Contains(sdt)).ToList();

                }
                LoadDataTTKH(lstKH);
                txtTimKiem.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng dữ liệu vào", "Thông báo");
            }
        }
        private void btnTTKH_Xoa_Click(object sender, EventArgs e)
        {

            //----------------
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    bool kq = khBUS.deleteKhachHang(txtMaKhachHang.Text);
                    if (kq == true)
                    {
                        h = MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_TTKH();
                        anTextBoxTTKH();

                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            txtTimKiem.Focus();
        }
        private void btnTTKH_Sua_Click(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH() && checkEmpty() && checkRegexTTKH() == false)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.StrMaKH = txtMaKhachHang.Text;
                kh.StrTenKH = txtTenKhachHang.Text;
                kh.StrDiaChi = txtDiaChi.Text;
                kh.StrSoDienThoai = txtSoDienThoai.Text;
                kh.StrCMND = txtCMND.Text;
                
                DialogResult h;
                if (khBUS.editKhachHang(kh))
                {
                    h = MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTKH();
                    errorProvider1.Clear();
                    anTextBoxTTKH();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (!TenCheck(txtTenKhachHang.Text.Trim()))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                {
                    if (!AddrressCheck(txtDiaChi.Text.Trim()))
                    {
                        errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ đúng định dạng ");
                        txtDiaChi.Focus();
                    }
                    else
                    {
                        if (!PhoneCheck(txtSoDienThoai.Text.Trim()))
                        {
                            errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            if (!CMNDCheck(txtCMND.Text.Trim()))
                            {
                                errorProvider1.SetError(txtCMND, "Bạn phải nhập bệnh án đúng định dạng ");
                                txtCMND.Focus();
                            }
                            else
                            {
                            
                                DTO_KhachHang kh = new DTO_KhachHang();
                                kh.StrMaKH = txtMaKhachHang.Text;
                                kh.StrMaKH = txtTenKhachHang.Text;
                                kh.StrDiaChi = txtDiaChi.Text;
                                kh.StrSoDienThoai = txtSoDienThoai.Text;
                                kh.StrCMND = txtCMND.Text;
                                DialogResult h;
                                if (khBUS.editKhachHang(kh))
                                {
                                    h = MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    LoadData_TTKH();
                                    errorProvider1.Clear();
                                    anTextBoxTTKH();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                }
                            }
                        }
                    }
                }
            }

        }
        private void btnTTKH_Luu_Click(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH() && checkEmpty() && checkRegexTTKH() == false)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.StrMaKH = txtMaKhachHang.Text;
                kh.StrTenKH = txtTenKhachHang.Text;
                kh.StrDiaChi = txtDiaChi.Text;
                kh.StrSoDienThoai = txtSoDienThoai.Text;
                kh.StrCMND = txtCMND.Text;
                DialogResult h;
                if (khBUS.addKhachHang(kh))
                {
                    h = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTKH();
                    errorProvider1.Clear();
                    anTextBoxTTKH();
                }
                else
                {
                    h = MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (!TenCheck(txtTenKhachHang.Text.Trim()))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                {
                    if (!AddrressCheck(txtDiaChi.Text.Trim()))
                    {
                        errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ đúng định dạng ");
                        txtDiaChi.Focus();
                    }
                    else
                    {
                        if (!PhoneCheck(txtSoDienThoai.Text.Trim()))
                        {
                            errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            if (!CMNDCheck(txtCMND.Text.Trim()))
                            {
                                errorProvider1.SetError(txtCMND, "Bạn phải nhập bệnh án đúng định dạng ");
                                txtCMND.Focus();
                            }
                            else
                            {
                                DTO_KhachHang kh = new DTO_KhachHang();
                                kh.StrMaKH = txtMaKhachHang.Text;
                                kh.StrTenKH = txtTenKhachHang.Text;
                                kh.StrDiaChi = txtDiaChi.Text;
                                kh.StrSoDienThoai = txtSoDienThoai.Text;
                                kh.StrCMND = txtCMND.Text;
                                DialogResult h;
                                if (khBUS.addKhachHang(kh))
                                {
                                    h = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    LoadData_TTKH();
                                    errorProvider1.Clear();
                                    anTextBoxTTKH();
                                }
                                else
                                {
                                    h = MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnTTKH_Them_Click(object sender, EventArgs e)
        {

            if (btnTTKH_Them.Text == "Thêm")
            {

                btnTTKH_Them.Text = "Hủy Thêm";
                txtMaKhachHang.Enabled = true;
                btnTTKH_Luu.Enabled = true;
                txtTenKhachHang.Enabled = true;
                txtSoDienThoai.Enabled = true;
                txtDiaChi.Enabled = true;
                txtCMND.Enabled = true;
            }
            else if (btnTTKH_Them.Text == "Hủy Thêm")
            {
                
                anTextBoxTTKH();
                btnTTKH_Them.Text = "Thêm";
                btnTTKH_Luu.Enabled = false;
                txtTimKiem.Focus();
            }
           
            btnTTKH_Xoa.Enabled = false;
            btnTTKH_Sua.Enabled = false;
            restTxtTTKH();
            txtTenKhachHang.Focus();
            dtgvTTKH_Show.ClearSelection();
        }
        #endregion

        #region Check
        public bool PhoneCheck(String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[0-9]{7})$").Success;
        }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtSoDienThoai.Text.Trim();
                if (!PhoneCheck(s))
                {
                    errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                    txtSoDienThoai.Focus();
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
            if (checkAnHienTextBoxTTKH())
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
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtTenKhachHang.Text.Trim();
                if (!TenCheck(s))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        public bool CMNDCheck(String s)
        {
            return Regex.Match(s, @"^[0-9]{9}$").Success;
        }
        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtCMND.Text.Trim();
                if (!CMNDCheck(s))
                {
                    errorProvider1.SetError(txtCMND, "Bạn phải nhập CMND đúng định dạng ");
                    txtCMND.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        private bool checkRegexTTKH()
        {
            string s1 = txtTenKhachHang.Text.Trim();
            string s2 = txtDiaChi.Text.Trim();
            string s3 = txtSoDienThoai.Text.Trim();
            string s4 = txtCMND.Text.Trim();
            if (!TenCheck(s1) && !PhoneCheck(s3) && !AddrressCheck(s2) && !CMNDCheck(s4))
            {
                return false;
            }
            else
                return true;
        }
        public bool checkEmpty()
        {
            if (txtTenKhachHang.Text.Equals(""))
            {
                errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên khách hàng!");
                txtTenKhachHang.Focus();
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
                    if (txtSoDienThoai.Text.Equals(""))
                    {
                        errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại!");
                        txtSoDienThoai.Focus();
                        return false;

                    }
                    else
                    {

                        errorProvider1.Clear();
                        if (txtCMND.Text.Equals(""))
                        {
                            errorProvider1.SetError(txtCMND, "Bạn phải nhập bênh án!");
                            txtCMND.Focus();
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
        }
        #endregion

        #region Du

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            var lstkh = khBUS.getAllKhachHang();
            if (radTimTheoTen.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (var mt in lstkh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mt.StrTenKH);
                }
            }
        }

        private void radTimTheoSoDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            var lstkh = khBUS.getAllKhachHang();
            if (radTimTheoSoDienThoai.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (var mt in lstkh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mt.StrSoDienThoai.ToString());
                }
            }
        }


        #endregion

        #endregion

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void grTTKH_ChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
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

