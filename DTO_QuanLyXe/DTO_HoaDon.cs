using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_HoaDon
    {
        private string _StrMaHD;
        private DateTime _DTNgayLapHD;
        private string _StrMaNV;
        private string _StrMaKH;
        private int _ITongTien;
        private string _StrLoaiHD;
        public DTO_HoaDon() { }
        public string StrMaHD
        {
            get
            {
                return _StrMaHD;
            }

            set
            {
                _StrMaHD = value;
            }
        }

        public DateTime DTNgayLapHD
        {
            get
            {
                return _DTNgayLapHD;
            }

            set
            {
                _DTNgayLapHD = value;
            }
        }

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

        public int ITongTien
        {
            get
            {
                return _ITongTien;
            }

            set
            {
                _ITongTien = value;
            }
        }

        public string StrLoaiHD
        {
            get
            {
                return _StrLoaiHD;
            }

            set
            {
                _StrLoaiHD = value;
            }
        }

        public DTO_HoaDon(string _StrMaHD, DateTime _DTNgayLapHD, string _StrMaNV, string _StrMaKH, int _ITongTien, string _StrLoaiHD)
        {
            this.StrMaHD = _StrMaHD;
            this.DTNgayLapHD = _DTNgayLapHD;
            this.StrMaNV = _StrMaNV;
            this.StrMaKH = _StrMaKH;
            this.ITongTien = _ITongTien;
            this.StrLoaiHD = _StrLoaiHD;
        }
    }
}
