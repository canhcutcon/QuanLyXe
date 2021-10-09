using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;
namespace BUS_QuanLyXe
{
     public class BUS_KhachHang
    {
        DAL_KhachHang khDAO;

        public BUS_KhachHang()
        {
            khDAO = new DAL_KhachHang();
        }

        public List<DTO_KhachHang> getAllKhachHang()
        {
            return khDAO.layDSKhachHang();
        }
        public bool addKhachHang(DTO_KhachHang khnew)
        {
            return khDAO.themKH(khnew);
        }
        public bool deleteKhachHang(string maKhachHang)
        {
            return khDAO.xoaKhachHang(maKhachHang);
        }
        public bool editKhachHang(DTO_KhachHang khnew)
        {
            return khDAO.suaKhachHang(khnew);
        }
        public DTO_KhachHang getKhachHangTheoTen(string tenkh)
        {
            return khDAO.layKhachHangTheoTen(tenkh);
        }
        public List<DTO_KhachHang> getKhachHangTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            return khDAO.layKhachHangTheoAutocompalet(giaTriTim, theoTen);
        }
        public List<DTO_KhachHang> getDanhSachKhachHang()
        {
            return khDAO.layDanhSachKhachHang();
        }
        public IEnumerable<KHACHHANG> getTenXeTheoMaKH(string KH)
        {
            return khDAO.getsTenXeTheoMaKH(KH);
        }
    }
}
