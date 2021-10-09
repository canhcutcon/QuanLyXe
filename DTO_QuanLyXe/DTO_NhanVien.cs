using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_NhanVien
    {
        string _StrMaNV;
        string _StrTenNV;
        DateTime _DTNgaySinh;
        string _StrCMND;
        string _StrSDT;
        string _StrDiaChi;
        string _StrGioiTinh;

        public DTO_NhanVien() { }

        public string StrMaNV
        {
            get
            {
                return _StrMaNV;
            }

            set
            {
                _StrMaNV = value;
            }
        }

        public string StrTenNV
        {
            get
            {
                return _StrTenNV;
            }

            set
            {
                _StrTenNV = value;
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

        public string StrSDT
        {
            get
            {
                return _StrSDT;
            }

            set
            {
                _StrSDT = value;
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

        public string StrGioiTinh
        {
            get
            {
                return _StrGioiTinh;
            }

            set
            {
                _StrGioiTinh = value;
            }
        }

        public DTO_NhanVien(string _StrMaNV, string _StrTenNV, DateTime _DTNgaySinh, string _StrCMND, string _StrSDT, string _StrDiaChi, string _StrGioiTinh)
        {
            this.StrMaNV = _StrMaNV;
            this.StrTenNV = _StrTenNV;
            this.DTNgaySinh = _DTNgaySinh;
            this.StrCMND = _StrCMND;
            this.StrSDT = _StrSDT;
            this.StrDiaChi = _StrDiaChi;
            this.StrGioiTinh = _StrGioiTinh;
        }
    }
}
