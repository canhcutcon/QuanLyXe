using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_ChiTietHoaDon
    {
        private string _StrMaHD;
        private string _StrMaXe;
        private int _ISoLuong;
        private int _IDonGia;
        private int _IThanhTien;
        public DTO_ChiTietHoaDon () { }
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

        public int ISoLuong
        {
            get
            {
                return _ISoLuong;
            }

            set
            {
                _ISoLuong = value;
            }
        }

        public int IDonGia
        {
            get
            {
                return _IDonGia;
            }

            set
            {
                _IDonGia = value;
            }
        }

        public int IThanhTien
        {
            get
            {
                return _IThanhTien;
            }

            set
            {
                _IThanhTien = value;
            }
        }

        public DTO_ChiTietHoaDon(string _StrMaHD, string _StrMaXe, int _ISoLuong, int _IDonGia, int _IThanhTien)
        {
            this.StrMaHD = _StrMaHD;
            this.StrMaXe = _StrMaXe;
            this.ISoLuong = _ISoLuong;
            this.IDonGia = _IDonGia;
            this.IThanhTien = _IThanhTien;
        }
    }
}
