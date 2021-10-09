using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon cthd;
        public BUS_ChiTietHoaDon()
        {
            cthd = new DAL_ChiTietHoaDon();
        }

        public IEnumerable<dynamic> getAllChiTietHD(String StrMaHD)
        {
            return cthd.getChiTietHDThuocHD(StrMaHD);
        }

        public bool editChiTietHoaDon(DTO_ChiTietHoaDon cthdnew)
        {
            return cthd.suaCTHoaDon(cthdnew);
        }

        public List<object> getInforTimKiem(string StrTimkiem)
        {
            return cthd.getsInforTimKiem(StrTimkiem);
        }

        public IEnumerable<CHITIETHD> getInforCTHD()
        {
            return cthd.getsInforCTHD();
        }
    }
}
