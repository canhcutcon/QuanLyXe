using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;

namespace DAO_QuanLyXe
{
    public class DAL_Xe
    {
        QuanLyXeDataContext db;
        public DAL_Xe()
        {
            db = new QuanLyXeDataContext();
        }
        public List<DTO_Xe> layDanhSachXe()
        {
            var dst = db.XEs.Select(p => p).OrderBy(p => p.MAXE);
            List<DTO_Xe> lst = new List<DTO_Xe>();
            foreach (XE item in dst)
            {
                DTO_Xe xe = new DTO_Xe();
                xe.StrMaXe = item.MAXE;
                xe.StrTenXe = item.TENXE;
                xe.IPhanKhoi = item.PHANKHOI.Value;
                xe.ISoLuongTon = item.SOLUONGTON.Value;
                xe.StrMaLoai = item.MALOAIXE;
                xe.DecDonGiaNhap = item.DONGIANHAP.Value;
                xe.DecDonGiaBan = item.DONGIABAN.Value;
                xe.StrGhiChu = item.GHICHU;
                xe.MaNCC = item.MANCC;
                lst.Add(xe);
            }
            return lst;
        }

        public List<object> layChiTietXe()
        {
            var dst = (from xe in db.XEs
                       
                       select new
                       {
                           MaXe = xe.MAXE,
                           TenXe = xe.TENXE,
                           PhanKhoi = xe.PHANKHOI,
                           SoLuongTon = xe.SOLUONGTON,
                           MaLoai = xe.MALOAIXE,
                           DonGiaNhap = xe.DONGIANHAP,
                           DonGiaBan = xe.DONGIABAN,
                           GhiChu = xe.GHICHU,
                           MaNCC = xe.MANCC
                       }).OrderBy(x => x.MaXe);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }

        public DTO_Xe layXeTheoMa(string maxe)
        {
            XE ttemp = db.XEs.Where(x => x.MAXE.Equals(maxe)).FirstOrDefault();

            DTO_Xe xe = new DTO_Xe();
            xe.StrMaXe = ttemp.MAXE;
            xe.StrTenXe = ttemp.TENXE;
            xe.IPhanKhoi = ttemp.PHANKHOI.Value;
            xe.ISoLuongTon = ttemp.SOLUONGTON.Value;
            xe.StrMaLoai = ttemp.MALOAIXE;
            xe.DecDonGiaNhap = ttemp.DONGIANHAP.Value;
            xe.DecDonGiaBan = ttemp.DONGIABAN.Value;
            xe.StrGhiChu = ttemp.GHICHU;
            xe.MaNCC = ttemp.MANCC;


            return xe;
        }
        private bool CheckIfExist(string maxe)
        {
            XE ttemp = db.XEs.Where(x => x.MAXE.Equals(maxe)).FirstOrDefault();
            if (ttemp != null)
            {
                return true;
            }
            return false;
        }
        public bool themXe(DTO_Xe tnew, DTO_NhaCungCap nccnew)
        {
            if (CheckIfExist(tnew.StrMaXe))
            {
                return false;
            }

            XE ttemp = new XE();
            ttemp.MAXE = tnew.StrMaXe;
            ttemp.TENXE = tnew.StrTenXe;
            ttemp.PHANKHOI = tnew.IPhanKhoi;
            ttemp.MALOAIXE = tnew.StrMaLoai;
            ttemp.SOLUONGTON = tnew.ISoLuongTon;
            ttemp.DONGIANHAP = tnew.DecDonGiaNhap;
            ttemp.DONGIABAN = tnew.DecDonGiaBan;
            ttemp.GHICHU = tnew.StrGhiChu;
            ttemp.MANCC = tnew.MaNCC;
            db.XEs.InsertOnSubmit(ttemp);
            db.SubmitChanges();
            return true;
        }

        public bool xoaXe(string maxe)
        {
            XE ttemp = db.XEs.Where(x => x.MAXE.Equals(maxe)).FirstOrDefault();
            if (ttemp != null)
            {
                db.XEs.DeleteOnSubmit(ttemp);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaXe(DTO_Xe tnew)
        {
            IQueryable<XE> t = db.XEs.Where(x => x.MAXE.Equals(tnew.StrMaXe));
            if (t.Count() >= 0)
            {
                try {
                    t.First().TENXE = tnew.StrTenXe;
                    t.First().PHANKHOI = tnew.IPhanKhoi;
                    t.First().MALOAIXE = tnew.StrMaLoai;
                    t.First().SOLUONGTON = tnew.ISoLuongTon;
                    t.First().DONGIANHAP = tnew.DecDonGiaNhap;
                    t.First().DONGIABAN = tnew.DecDonGiaBan;
                    t.First().GHICHU = tnew.StrGhiChu;
                    t.First().MANCC = tnew.MaNCC;
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public List<object> layXeTheoLoai(string loaiXe)
        {
            var dst = (from xe in db.XEs
                       join lx in db.LOAIXEs on xe.MALOAIXE equals lx.MALOAIXE
                       where lx.TENLOAI.Equals(loaiXe)
                       select new {
                           MaXe = xe.MAXE,
                           TenXe = xe.TENXE,
                           PhanKhoi = xe.PHANKHOI,
                           SoLuongTon = xe.SOLUONGTON,
                           MaLoai = xe.MALOAIXE,
                           DonGiaNhap = xe.DONGIANHAP,
                           DonGiaBan = xe.DONGIABAN,
                           GhiChu = xe.GHICHU,
                           MaNCC = xe.MANCC
                       }).OrderBy(x => x.MaXe);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }

        public DTO_Xe timTheoMa(string ma) // chỉ lấy một cột trong database
        {
            XE dst = db.XEs.Where(x => x.MAXE.Equals(ma)).FirstOrDefault();
            DTO_Xe xe = new DTO_Xe();
            xe.StrMaXe = dst.MAXE;
            return xe;
        }
        public bool themXe(DTO_Xe tnew)
        {
            if (CheckIfExist(tnew.StrMaXe))
            {
                return false;
            }

            XE ttemp = new XE();
            ttemp.MAXE = tnew.StrMaXe;
            ttemp.TENXE = tnew.StrTenXe;
            ttemp.PHANKHOI = tnew.IPhanKhoi;
            ttemp.MALOAIXE = tnew.StrMaLoai;
            ttemp.SOLUONGTON = tnew.ISoLuongTon;
            ttemp.DONGIANHAP = tnew.DecDonGiaNhap;
            ttemp.DONGIABAN = tnew.DecDonGiaBan;
            ttemp.GHICHU = tnew.StrGhiChu;
            ttemp.MANCC = tnew.MaNCC;
            db.XEs.InsertOnSubmit(ttemp);
            db.SubmitChanges();
            return true;
        }
        public List<object> TimMoiDieuKien(string ten)
        {

            var dst = (from xe in db.XEs.Where(x => x.TENXE.Contains(ten))

                       select new
                       {
                           MaXe = xe.MAXE,
                           TenXe = xe.TENXE,
                           PhanKhoi = xe.PHANKHOI,
                           SoLuongTon = xe.SOLUONGTON,
                           MaLoai = xe.MALOAIXE,
                           DonGiaNhap = xe.DONGIANHAP,
                           DonGiaBan = xe.DONGIABAN,
                           GhiChu = xe.GHICHU,
                           MaNCC = xe.MANCC
                       }).OrderBy(x => x.MaXe);
            List<object> lst = new List<object>();
            foreach (var item in dst)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<DTO_Xe> LayDanhSachXe()
        {
            var dsxe = db.XEs.Select(p => p).OrderBy(p => p.MAXE);

            List<DTO_Xe> lskh = new List<DTO_Xe>();

            foreach (XE item in dsxe)
            {
                DTO_Xe xe = new DTO_Xe();
                xe.StrMaXe = item.MAXE;
                xe.StrTenXe = item.TENXE;
                xe.StrMaLoai = item.MALOAIXE;
                xe.MaNCC = item.MANCC;
                xe.StrGhiChu = item.GHICHU;
                xe.DecDonGiaBan = (decimal)item.DONGIABAN;
                xe.DecDonGiaNhap = (decimal)item.DONGIANHAP;
                xe.IPhanKhoi = (int)item.PHANKHOI;
                xe.ISoLuongTon = (int)item.SOLUONGTON;

                lskh.Add(xe);
            }
            return lskh;
        }

        public IEnumerable<XE> getsTenXeTheoMaXe(string Xe)
        {
            IEnumerable<XE> xe = from n in db.XEs
                                 where n.MAXE == Xe
                                 select n;
            return xe;
        }
    }
}
