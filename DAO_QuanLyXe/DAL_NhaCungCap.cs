using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;
namespace DAO_QuanLyXe
{
    public class DAL_NhaCungCap
    {
        QuanLyXeDataContext db;
        public DAL_NhaCungCap()
        {
            db = new QuanLyXeDataContext();
        }
        public List<DTO_NhaCungCap> layDanhSachNhaCungCap()
        {
            var dsncc = db.NCCs.Select(p => p).OrderBy(p => p.MANCC);

            List<DTO_NhaCungCap> lsncc = new List<DTO_NhaCungCap>();

            foreach (NCC item in dsncc)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                ncc.StrMaNCC = item.MANCC;
                ncc.StrTenNCC = item.TENNCC;
                lsncc.Add(ncc);
            }
            return lsncc;
        }
        public DTO_NhaCungCap layNhaCungCapTheoTen(string tenkhach)
        {
            NCC ncctemp = db.NCCs.Where(p => p.TENNCC.Equals(tenkhach)).FirstOrDefault();

            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            ncc.StrMaNCC = ncctemp.MANCC;
            ncc.StrTenNCC = ncctemp.TENNCC;
          

            return ncc;
        }
        public List<object> layChiTietNCC()
        {
            var dst = (from ncc in db.NCCs
                       select new
                       {
                           MaNCC = ncc.MANCC,
                           TenNCC = ncc.TENNCC

                       }).OrderBy(x => x.MaNCC);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        private bool CheckIfExist(string maNhaCC)
        {
            NCC ttemp = db.NCCs.Where(x => x.MANCC.Equals(maNhaCC)).FirstOrDefault();
            if (ttemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themNhaCC(DTO_NhaCungCap nccnew)
        {
            if (CheckIfExist(nccnew.StrMaNCC))
            {
                return false;
            }

            NCC ncc = new NCC();
            ncc.MANCC = nccnew.StrMaNCC;
            ncc.TENNCC = nccnew.StrTenNCC;
           
            db.NCCs.InsertOnSubmit(ncc);
            db.SubmitChanges();
            return true;
        }
        public bool xoaNhaCC(string maNhaCC)
        {
            NCC ttemp = db.NCCs.Where(x => x.MANCC.Equals(maNhaCC)).FirstOrDefault();
            if (ttemp != null)
            {
                db.NCCs.DeleteOnSubmit(ttemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaNhaCC(DTO_NhaCungCap tnew)
        {
            IQueryable<NCC> t = db.NCCs.Where(x => x.MANCC.Equals(tnew.StrMaNCC));
            if (t.Count() >= 0)
            {
                t.First().MANCC = tnew.StrMaNCC;
                t.First().TENNCC = tnew.StrTenNCC;
                

                db.SubmitChanges();

                return true;
            }
            return false;
        }
    }
}
