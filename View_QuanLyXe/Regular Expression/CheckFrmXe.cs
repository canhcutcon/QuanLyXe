using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyXe
{
    public class CheckFrmXe
    {
        public bool checkMaXe(string maXe)
        {
            return Regex.Match(maXe, @"^[A-Z0-9]+$").Success;
        }
        public bool checkTenXe(string tenXe)
        {
            return Regex.Match(tenXe, @"^[A-Z][^.?!@#$`~%^&*+=_()/\,<>]*$").Success;
        }
        public bool checkPhanKhoi(string phanKhoi)
        {
            return Regex.Match(phanKhoi, @"^[0-9]+$").Success;
        }
        public bool checkSoLuongTon(string soLuongTon)
        {
            return Regex.Match(soLuongTon, @"^[0-9]+$").Success;
        }
        public bool checkMaLoai(string maLoai)
        {
            return Regex.Match(maLoai, @"^[A-Z][^.?!@#$`~%^&*+=_/\<>]*$").Success;

        }
        public bool checkDonGiaNhap(string donGia)
        {
            return Regex.Match(donGia, @"^[0-9.]+$").Success;
        }
        public bool checkDonGiaBan(string donGia)
        {
            return Regex.Match(donGia, @"^[0-9.]+$").Success;
        }
        public bool checkGhiChu(string ghiChu)
        {
            return Regex.Match(ghiChu, @"^[A-Z][^.?!@#$`~%^&*+=_()/\,<>]*$").Success;
        }
        public bool checkNhaCC(string NCC)
        {
            return Regex.Match(NCC, @"^[A-Z0-9]+$").Success;
        }
    }
}
