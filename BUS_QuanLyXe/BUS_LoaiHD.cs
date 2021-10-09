using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_LoaiHD
    {
        DAL_LoaiHD lhd;
        public BUS_LoaiHD()
        {
            lhd = new DAL_LoaiHD();
        }
        public IEnumerable<LOAIHD> getInforLoaiHD()
        {
            return lhd.getInForLoaiHoaDon();
        }

    }
}
