using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_Xe
    {
        string _StrMaXe;
        string _StrTenXe;
        int _IPhanKhoi;
        int _ISoLuongTon;
        string _StrMaLoai;
        decimal _DecDonGiaNhap;
        decimal _DecDonGiaBan;
        string _StrGhiChu;
        string _MaNCC;

        public string StrMaXe
        {
            get
            {
                return _StrMaXe;
            }

            set
            {
                _StrMaXe = value;
            }
        }

        public string StrTenXe
        {
            get
            {
                return _StrTenXe;
            }

            set
            {
                _StrTenXe = value;
            }
        }

        public int IPhanKhoi
        {
            get
            {
                return _IPhanKhoi;
            }

            set
            {
                _IPhanKhoi = value;
            }
        }

        public int ISoLuongTon
        {
            get
            {
                return _ISoLuongTon;
            }

            set
            {
                _ISoLuongTon = value;
            }
        }

        public string StrMaLoai
        {
            get
            {
                return _StrMaLoai;
            }

            set
            {
                _StrMaLoai = value;
            }
        }

        public decimal DecDonGiaNhap
        {
            get
            {
                return _DecDonGiaNhap;
            }

            set
            {
                _DecDonGiaNhap = value;
            }
        }

        public decimal DecDonGiaBan
        {
            get
            {
                return _DecDonGiaBan;
            }

            set
            {
                _DecDonGiaBan = value;
            }
        }

        public string StrGhiChu
        {
            get
            {
                return _StrGhiChu;
            }

            set
            {
                _StrGhiChu = value;
            }
        }

        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }

            set
            {
                _MaNCC = value;
            }
        }

        public DTO_Xe()
        {

        }

        public DTO_Xe(string StrMaXe, string StrTenXe, int IPhanKhoi, int ISoLuongTon, string StrMaLoai, decimal DecDonGiaNhap, decimal DecDonGiaBan, string StrGhiChu, string MaNCC)
        {
            this.StrMaXe = StrMaXe;
            this.StrTenXe = StrTenXe;
            this.IPhanKhoi = IPhanKhoi;
            this.ISoLuongTon = ISoLuongTon;
            this.StrMaLoai = StrMaLoai;
            this.DecDonGiaNhap = DecDonGiaNhap;
            this.DecDonGiaBan = DecDonGiaBan;
            this.StrGhiChu = StrGhiChu;
            this.MaNCC = MaNCC;
        }

    }
}
