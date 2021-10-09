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
using System.Text.RegularExpressions;

namespace QuanLyXe
{
    public partial class frmXe : Form
    {
        BUS_Xe tBUS = new BUS_Xe();
        CheckFrmXe checkXe = new CheckFrmXe();




        public frmXe()
        {
            InitializeComponent();
        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            LoadData_T();
            txtMaXe.ReadOnly = true;

            txtTimTenXe.Focus();
            //formatDTGV();

        }
        private void dtgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                txtMaXe.ReadOnly = true;
            }
            else
            {
                txtMaXe.ReadOnly = false;
            }
        }


        private void LoadData_T()
        {
            dtgvShow.DataSource = null;
            dtgvShow.DataSource = tBUS.getXe();

            btnLuu.Enabled = false;
            khoaThongTinT();
            dtgvShow.ClearSelection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            restTxtT();
            btnThem.Text = "Thêm";

        }
        private void dtgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtgvShow.Rows[e.RowIndex];
                DTO_Xe t = new DTO_Xe();
                t = tBUS.getXeTheoMa(row.Cells[0].Value.ToString().Trim());

                txtMaXe.Text = row.Cells[0].Value.ToString().Trim();

                txtTenXe.Text = row.Cells[1].Value.ToString().Trim();
                txtPhanKhoi.Text = row.Cells[2].Value.ToString().Trim();
                txtSoLuongTon.Text = row.Cells[3].Value.ToString().Trim();

                if (row.Cells[4].Value == null)
                    txtMaLoaiXe.Text = "XE1";
                else
                    txtMaLoaiXe.Text = row.Cells[4].Value.ToString().Trim();
                txtDonGiaXuat.Text = row.Cells[5].Value.ToString().Trim();
                txtDonGiaNhap.Text = row.Cells[6].Value.ToString().Trim();
                //txtGhiChu.Text = row.Cells[8].Value.ToString();
                txtMaNCC.Text = row.Cells[8].Value.ToString().Trim();





            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            hienThongTinT();
        }






        #region Format
        private void formatDTGV()
        {
            try
            {
                dtgvShow.Columns[0].HeaderText = "Mã Xe";
                dtgvShow.Columns[2].HeaderText = "Tên Xe";
                dtgvShow.Columns[3].HeaderText = "Phân Khối";
                dtgvShow.Columns[4].HeaderText = "Số lượng tồn";
                dtgvShow.Columns[7].HeaderText = "Mã Loại xe";
                dtgvShow.Columns[5].HeaderText = "Đơn giá nhập";
                dtgvShow.Columns[6].HeaderText = "Đơn Giá Bán";
                dtgvShow.Columns[8].HeaderText = "Ghi chú";
                dtgvShow.Columns[9].HeaderText = "Mã NCC";
            }
            catch (Exception)
            {


            }
        }
        private void khoaThongTinT()
        {
            grThongTin.Enabled = false;
        }
        private void hienThongTinT()
        {
            grThongTin.Enabled = true;

        }
        private void restTxtT()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            txtGhiChu.Clear();
            txtPhanKhoi.Clear();
            txtSoLuongTon.Clear();
            txtMaLoaiXe.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaXuat.Clear();
            txtGhiChu.Focus();
        }
        #endregion
        #region Event
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy Thêm";
                btnLuu.Enabled = true;
                hienThongTinT();
            }
            else if (btnThem.Text == "Hủy Thêm")
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                grThongTin.Enabled = false; // chỗ này k hoạt động
                restTxtT();
                errorProvider1.Clear();
                txtTimTenXe.Focus();
                khoaThongTinT();
            }
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            restTxtT();
            dtgvShow.ClearSelection();
            txtMaXe.ReadOnly = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {

                    bool t = tBUS.deleteXe(txtMaXe.Text);
                    if (t == true)
                    {
                        h = MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_T();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                txtTimTenXe.Focus();
            }
            restTxtT(); //note nè
            grThongTin.Enabled = false; //note


            txtTimTenXe.ResetText();//note
            LoadData_T();//note
            errorProvider1.Clear();//note
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text == " " || txtMaXe.Text == "" || txtTenXe.Text == " " || txtTenXe.Text == "" ||
               txtPhanKhoi.Text == " " || txtPhanKhoi.Text == "" || txtMaNCC.Text == ""
                || txtDonGiaNhap.Text == " " || txtDonGiaNhap.Text == "" || txtSoLuongTon.Text == " " ||
                txtSoLuongTon.Text == "" || txtDonGiaXuat.Text == " " || txtDonGiaXuat.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkXe.checkMaXe(txtMaXe.Text) == false || checkXe.checkTenXe(txtTenXe.Text) == false ||
                checkXe.checkNhaCC(txtMaNCC.Text) == false || checkXe.checkDonGiaNhap(txtDonGiaNhap.Text) == false ||
                checkXe.checkDonGiaBan(txtDonGiaXuat.Text) == false || checkXe.checkPhanKhoi(txtPhanKhoi.Text) == false
                || checkXe.checkSoLuongTon(txtSoLuongTon.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {
                DTO_Xe xe = new DTO_Xe();
                xe.StrMaXe = txtMaXe.Text;
                xe.StrTenXe = txtTenXe.Text;
                xe.StrMaLoai = txtMaLoaiXe.Text;
                xe.IPhanKhoi = Convert.ToInt32(txtPhanKhoi.Text);
                xe.ISoLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
                xe.DecDonGiaBan = Convert.ToDecimal(txtDonGiaXuat.Text);
                xe.DecDonGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text);
                xe.MaNCC = txtMaNCC.Text;
                xe.StrGhiChu = txtGhiChu.Text;
                if (tBUS.editXe(xe))
                {
                    MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    restTxtT(); //note


                    txtTimTenXe.ResetText();//note
                    LoadData_T();//note
                    errorProvider1.Clear();//note

                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại! Không được đổi khoá", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text.Trim() == "" || txtMaXe.Text.Trim() == "" || txtTenXe.Text.Trim() == " " || txtTenXe.Text.Trim() == "" ||
               txtPhanKhoi.Text.Trim() == "" || txtPhanKhoi.Text.Trim() == "" || txtMaNCC.Text.Trim() == ""
                || txtDonGiaNhap.Text.Trim() == "" || txtDonGiaNhap.Text.Trim() == "" || txtSoLuongTon.Text.Trim() == "" ||
                txtSoLuongTon.Text.Trim() == "" || txtDonGiaXuat.Text.Trim() == "" || txtDonGiaXuat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkXe.checkMaXe(txtMaXe.Text) == false || checkXe.checkTenXe(txtTenXe.Text) == false ||
                checkXe.checkNhaCC(txtMaNCC.Text) == false || checkXe.checkDonGiaNhap(txtDonGiaNhap.Text) == false ||
                checkXe.checkDonGiaBan(txtDonGiaXuat.Text) == false || checkXe.checkPhanKhoi(txtPhanKhoi.Text) == false
                || checkXe.checkSoLuongTon(txtSoLuongTon.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {
                DTO_Xe xe = new DTO_Xe();
                xe.StrMaXe = txtMaXe.Text;
                xe.StrTenXe = txtTenXe.Text;
                xe.StrMaLoai = txtMaLoaiXe.Text;
                xe.IPhanKhoi = Convert.ToInt32(txtPhanKhoi.Text);
                xe.ISoLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
                xe.DecDonGiaBan = Convert.ToDecimal(txtDonGiaXuat.Text);
                xe.DecDonGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text);
                xe.MaNCC = txtMaNCC.Text;
                xe.StrGhiChu = txtGhiChu.Text;


                if (tBUS.addXe(xe))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_T();
                    restTxtT(); //note

                    txtTimTenXe.ResetText();//note
                    LoadData_T();//note
                    errorProvider1.Clear();//note
                }
                else
                {
                    MessageBox.Show("Bị trùng mã", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimTenXe.Text.Trim() != "")
            {
                dtgvShow.DataSource = tBUS.getDieuKien(txtTimTenXe.Text);
                formatDTGV(); // note
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu!", "Thông báo");
            }
        }
        #endregion
        #region Check
        private void KiemTraTrong()
        {
            if (txtTenXe.Text == "")
            {
                errorProvider1.SetError(txtTenXe, "Không được bỏ trống");
                txtTenXe.Focus();
            }
            if (txtMaXe.Text == "")
            {
                errorProvider1.SetError(txtMaXe, "Không được bỏ trống");
                txtMaXe.Focus();
            }
            if (txtPhanKhoi.Text == "")
            {
                errorProvider1.SetError(txtPhanKhoi, "Không được bỏ trống");
                txtPhanKhoi.Focus();
            }
            if (txtSoLuongTon.Text == "")
            {
                errorProvider1.SetError(txtSoLuongTon, "Không được bỏ trống");
                txtSoLuongTon.Focus();
            }
            if (txtDonGiaNhap.Text == "")
            {
                errorProvider1.SetError(txtDonGiaNhap, "Không được bỏ trống");
                txtDonGiaNhap.Focus();
            }
            if (txtDonGiaXuat.Text == "")
            {
                errorProvider1.SetError(txtDonGiaXuat, "Không được bỏ trống");
                txtDonGiaXuat.Focus();
            }
        }
        private void KiemTraCheck()
        {
            if (checkXe.checkMaXe(txtMaXe.Text) == false)
            {
                txtMaXe.Focus();
                errorProvider1.SetError(txtMaXe, "Chỉ được nhập kí tự hoa");//
            }
            if (checkXe.checkTenXe(txtTenXe.Text) == false)
            {
                errorProvider1.SetError(txtTenXe, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
                txtTenXe.Focus();
            }
            if (checkXe.checkPhanKhoi(txtPhanKhoi.Text) == false)
            {
                errorProvider1.SetError(txtPhanKhoi, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa các kí tự đặc biệt");
                txtPhanKhoi.Focus();
            }
            if (checkXe.checkNhaCC(txtMaNCC.Text) == false)
            {
                errorProvider1.SetError(txtMaNCC, "Chỉ được nhập kí tự hoa");//
                txtMaNCC.Focus();
            }
            if (checkXe.checkSoLuongTon(txtSoLuongTon.Text) == false)
            {
                errorProvider1.SetError(txtSoLuongTon, "Chỉ được nhập số");
                txtSoLuongTon.Focus();
            }
            if (checkXe.checkDonGiaNhap(txtDonGiaNhap.Text) == false)
            {
                errorProvider1.SetError(txtDonGiaNhap, "Chỉ được nhập số");//
                txtDonGiaNhap.Focus();
            }
            if (checkXe.checkDonGiaBan(txtDonGiaXuat.Text) == false)
            {
                errorProvider1.SetError(txtDonGiaXuat, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa các kí tự đặc biệt");//
                txtDonGiaXuat.Focus();
            }
        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {
            if (txtMaXe.Text != "")
            {
                if (checkXe.checkTenXe(txtMaXe.Text) == false)
                {
                    txtMaXe.Focus();
                    errorProvider1.SetError(txtMaXe, "Chỉ được nhập kí tự hoa");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtMaXe_Leave(object sender, EventArgs e)
        {
            if (txtMaXe.Text == "")
            {
                errorProvider1.SetError(txtMaXe, "Không được bỏ trống");
            }
        }
        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {
            if (txtTenXe.Text != "")
            {
                if (checkXe.checkTenXe(txtTenXe.Text) == false)
                {
                    errorProvider1.SetError(txtTenXe, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
                    txtTenXe.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtTenXe_Leave(object sender, EventArgs e)
        {
            if (txtTenXe.Text == "")
            {
                errorProvider1.SetError(txtTenXe, "Không được bỏ trống");
            }
        }
        private void txtPhanKhoi_Leave(object sender, EventArgs e)
        {
            if (txtPhanKhoi.Text == "")
            {
                errorProvider1.SetError(txtPhanKhoi, "Không được bỏ trống");
            }
        }
        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongTon.Text != "")
            {
                if (checkXe.checkSoLuongTon(txtSoLuongTon.Text) == false)
                {
                    errorProvider1.SetError(txtSoLuongTon, "Chỉ được nhập số");
                    txtSoLuongTon.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtSoLuongTon_Leave(object sender, EventArgs e)
        {
            if (txtSoLuongTon.Text == "")
            {
                errorProvider1.SetError(txtSoLuongTon, "Không được bỏ trống");
            }
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaNhap.Text != "")
            {
                if (checkXe.checkDonGiaNhap(txtDonGiaNhap.Text) == false)
                {
                    errorProvider1.SetError(txtDonGiaNhap, "Chỉ được nhập số");
                    txtDonGiaNhap.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDonGiaNhap_Leave(object sender, EventArgs e)
        {
            if (txtDonGiaNhap.Text == "")
            {
                errorProvider1.SetError(txtDonGiaNhap, "Không được bỏ trống");
            }
        }
        private void txtDonGiaXuat_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaXuat.Text != "")
            {
                if (checkXe.checkDonGiaNhap(txtDonGiaXuat.Text) == false)
                {
                    errorProvider1.SetError(txtDonGiaXuat, "Chỉ được nhập số");
                    txtDonGiaXuat.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDonGiaXuat_Leave(object sender, EventArgs e)
        {
            if (txtDonGiaXuat.Text == "")
            {
                errorProvider1.SetError(txtDonGiaXuat, "Không được bỏ trống");
            }
        }
        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "")
            {
                if (checkXe.checkNhaCC(txtMaNCC.Text) == false)
                {
                    errorProvider1.SetError(txtMaNCC, "Chỉ được nhập số");
                    txtMaNCC.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtMaNCC_Leave(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaNCC, "Không được bỏ trống");
            }
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData_T();
            txtMaXe.ReadOnly = true;

            txtTimTenXe.Focus();
        }

        public void btnTat_Click(object sender, EventArgs e)
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
