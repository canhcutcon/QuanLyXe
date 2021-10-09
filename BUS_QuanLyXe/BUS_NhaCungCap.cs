using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;
using DAO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap nccDAO;
        public BUS_NhaCungCap()
        {
            nccDAO = new DAL_NhaCungCap();
        }
        public List<DTO_NhaCungCap> getAllNhaCungCap()
        {
            return nccDAO.layDanhSachNhaCungCap();
        }
        public DTO_NhaCungCap getNhaCungCapTheoTen(string tenkhach)
        {
            return nccDAO.layNhaCungCapTheoTen(tenkhach);
        }
        public List<object> getNCCInfo()
        {
            return nccDAO.layChiTietNCC();
        }
        public bool addNhaCC(DTO_NhaCungCap nccnew)
        {
            return nccDAO.themNhaCC(nccnew);
        }
        public bool deleteNhaCC(string maNhaCC)
        {
            return nccDAO.xoaNhaCC(maNhaCC);
        }
        public bool editNhaCC(DTO_NhaCungCap tnew)
        {
            return nccDAO.suaNhaCC(tnew);
        }
    }
}
