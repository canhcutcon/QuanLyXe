using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;
using DAO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_Xe
    {
        DAL_Xe tDAO;
        public BUS_Xe()
        {
            tDAO = new DAL_Xe();
        }
        public List<DTO_Xe> getAllThuoc()
        {
            return tDAO.layDanhSachXe();
        }
        public List<object> getXe()
        {
            return tDAO.layChiTietXe();
        }
        public DTO_Xe getXeTheoMa(string maxe)
        {
            return tDAO.layXeTheoMa(maxe);
        }
        public bool addXe(DTO_Xe tnew, DTO_NhaCungCap nccnew)
        {
            return tDAO.themXe(tnew, nccnew);
        }
        public bool deleteXe(string maxe)
        {
            return tDAO.xoaXe(maxe);
        }
        public bool editXe(DTO_Xe tnew)
        {
            return tDAO.suaXe(tnew);
        }
        public List<object> getXeTheoLoai(string loaiXe)
        {
            return tDAO.layXeTheoLoai(loaiXe);
        }
        public List<object> getDieuKien(string ten)
        {
            return tDAO.TimMoiDieuKien(ten);
        }

        public bool addXe(DTO_Xe tnew)
        {
            return tDAO.themXe(tnew);
        }

        public List<DTO_Xe> getsDanhSachXe()
        {
            return tDAO.LayDanhSachXe();
        }

        public IEnumerable<XE> getTenXeTheoMaXe(string Xe)
        {
            return tDAO.getsTenXeTheoMaXe(Xe);
        }
    }
}
