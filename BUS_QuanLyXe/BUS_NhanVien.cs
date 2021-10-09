using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_NhanVien
    {
        //DAO_NhanVien DAOnv;
        //public BUS_NhanVien()
        //{
        //    DAOnv = new DAO_NhanVien();
        //}

        //public IEnumerable<NHANVIEN> getAllNhanVien()
        //{
        //    return DAOnv.getAllNhanVien();
        //}
        DAO_QuanLyXe.DAL_NhanVien nvDAO;

        public BUS_NhanVien()
        {
            nvDAO = new DAO_QuanLyXe.DAL_NhanVien();
        }

        public List<DTO_QuanLyXe.DTO_NhanVien> getAllNhanVien()
        {
            return nvDAO.layDSNhanVien();
        }
        public bool addNhanVien(DTO_QuanLyXe.DTO_NhanVien nvnew)
        {
            return nvDAO.themNV(nvnew);
        }
        public bool deleteNhanVien(string maNhanVien)
        {
            return nvDAO.xoaNV(maNhanVien);
        }
        public bool editNhanVien(DTO_QuanLyXe.DTO_NhanVien nvnew)
        {
            return nvDAO.suaNV(nvnew);
        }
        public DTO_QuanLyXe.DTO_NhanVien getKhachHangTheoTen(string tennv)
        {
            return nvDAO.layNhanVienTheoTen(tennv);
        }
        public List<DTO_QuanLyXe.DTO_NhanVien> getNhanVienTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            return nvDAO.layNhanVienTheoAutocompalet(giaTriTim, theoTen);
        }
        public List<DTO_NhanVien> getDanhSachNhanVien()
        {
            return nvDAO.layDanhSachNV();
        }
    }
}
