using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_KhachHang
    {
        private string _StrMaKH;
        private string _StrTenKH;
        private string _StrSoDienThoai;
        private DateTime _DTNgaySinh;
        private string _StrCMND;
        private string _StrDiaChi;
        public DTO_KhachHang ()
        {

        }
        public string StrMaKH
        {
            get
            {
                return _StrMaKH;
            }

            set
            {
                _StrMaKH = value;
            }
        }

        public string StrTenKH
        {
            get
            {
                return _StrTenKH;
            }

            set
            {
                _StrTenKH = value;
            }
        }

        public string StrSoDienThoai
        {
            get
            {
                return _StrSoDienThoai;
            }

            set
            {
                _StrSoDienThoai = value;
            }
        }

        public DateTime DTNgaySinh
        {
            get
            {
                return _DTNgaySinh;
            }

            set
            {
                _DTNgaySinh = value;
            }
        }

        public string StrCMND
        {
            get
            {
                return _StrCMND;
            }

            set
            {
                _StrCMND = value;
            }
        }

        public string StrDiaChi
        {
            get
            {
                return _StrDiaChi;
            }

            set
            {
                _StrDiaChi = value;
            }
        }
        
        public DTO_KhachHang(string _StrMaKH, string _StrTenKH, string _StrSoDienThoai, DateTime _DTNgaySinh, string _StrCMND, string _StrDiaChi)
        {
            this.StrMaKH = _StrMaKH;
            this.StrTenKH = _StrTenKH;
            this.StrSoDienThoai = _StrSoDienThoai;
            this.DTNgaySinh = _DTNgaySinh;
            this.StrCMND = _StrCMND;
            this.StrDiaChi = _StrDiaChi;
        }



    }
}
