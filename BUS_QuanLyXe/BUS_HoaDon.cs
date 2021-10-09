using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_HoaDon
    {
        DAL_HoaDon DAOhd;
        public BUS_HoaDon()
        {
            DAOhd = new DAL_HoaDon();
        }

        public List<object> getAllHoadon()
        {
            return DAOhd.getAllHoaDon();
        }

        public bool addHoaDon(DTO_HoaDon hd,DTO_ChiTietHoaDon cthd)
        {
            return DAOhd.themHoaDon(hd,cthd);
        }

        public bool editHoaDon(DTO_HoaDon cthdnew)
        {
            return DAOhd.suaHoaDon(cthdnew);
        }

        public bool deleteHoaDon(string mahd)
        {
            return DAOhd.xoaHoaDon(mahd);
        }
    }
}
