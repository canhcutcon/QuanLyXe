using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;

namespace DAO_QuanLyXe
{
    public class DAL_KhachHang
    {
        QuanLyXeDataContext dt;
        public DAL_KhachHang()
        {
            dt = new QuanLyXeDataContext();
        }
        
        public List<DTO_KhachHang> layDSKhachHang()
        {
            var dskh = dt.KHACHHANGs.Select(p => p).OrderBy(p => p.MAKH);

            List<DTO_KhachHang> list_KH = new List<DTO_KhachHang>();

            foreach(KHACHHANG item in dskh)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.StrMaKH = item.MAKH;
                kh.StrTenKH = item.TENKH;
                kh.StrSoDienThoai = item.SDT;
                kh.StrDiaChi = item.DIACHI;
                kh.StrCMND = item.CMND;
                list_KH.Add(kh);
            }
            return list_KH;
        }

        private bool ChechFrmExist(string maKH) // tim mã khách hàng
        {
            KHACHHANG khtemp = dt.KHACHHANGs.Where(x => x.MAKH.Equals(maKH)).FirstOrDefault();
            if(khtemp != null)
            {
                return true;
            }
            return false;
        }

        public bool themKH(DTO_KhachHang khnew)
        {
            if(ChechFrmExist(khnew.StrMaKH))
            {
                return false; // trùng mã thì không thêm
            }

            KHACHHANG khtemp = new KHACHHANG();
            khtemp.MAKH = khnew.StrMaKH;
            khtemp.TENKH = khnew.StrTenKH;
            khtemp.DIACHI = khnew.StrDiaChi;
            khtemp.SDT = khnew.StrSoDienThoai;        
            khtemp.CMND = khnew.StrCMND;
            dt.KHACHHANGs.InsertOnSubmit(khtemp);
            dt.SubmitChanges();
            return true;
        }

        public bool xoaKhachHang(string maKhachHang)
        {
            KHACHHANG temp = dt.KHACHHANGs.Where(x => x.MAKH.Equals(maKhachHang)).FirstOrDefault();
            if(temp != null)
            {
                dt.KHACHHANGs.DeleteOnSubmit(temp);
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaKhachHang(DTO_KhachHang khnew)
        {
            //IQueryable<KHACHHANG> kh = dt.KHACHHANGs.Where(x => x.MAKH.Equals(khnew.StrMaKH));
            IQueryable<KHACHHANG> kh = (from n in dt.KHACHHANGs
                                         where n.MAKH == khnew.StrMaKH
                                          select n);
            if (kh.Count() >= 0)
            {
                kh.First().TENKH = khnew.StrTenKH;
                kh.First().SDT = khnew.StrSoDienThoai;
                kh.First().DIACHI = khnew.StrDiaChi;
                kh.First().CMND = khnew.StrCMND;
                dt.SubmitChanges();
                return true;
            }
            return false;
        }


        public DTO_KhachHang layKhachHangTheoTen(string tenkh)
        {
            KHACHHANG khtemp = dt.KHACHHANGs.Where(p => p.TENKH.Equals(tenkh)).FirstOrDefault();

            DTO_KhachHang kh = new DTO_KhachHang();
            kh.StrMaKH = khtemp.MAKH;
            kh.StrTenKH = khtemp.TENKH;
            kh.StrDiaChi = khtemp.DIACHI;
            kh.StrSoDienThoai = khtemp.SDT;
            kh.StrCMND = khtemp.CMND;
            return kh;
        }

        public List<DTO_KhachHang> layKhachHangTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            if (theoTen)
            {
                var dskh = from kh in dt.KHACHHANGs
                           where kh.TENKH.StartsWith(giaTriTim)
                           orderby kh.MAKH
                           select kh;
                List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

                foreach (KHACHHANG item in dskh)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.StrMaKH = item.MAKH;
                    kh.StrTenKH = item.TENKH;
                    kh.DTNgaySinh = (DateTime)item.NGAYSINH;
                    kh.StrDiaChi = item.DIACHI;
                    kh.StrSoDienThoai = item.SDT;
                    kh.StrCMND = item.CMND;

                    lskh.Add(kh);
                }
                return lskh;
            }
            else
            {
                var dskh = from kh in dt.KHACHHANGs
                           where kh.SDT.Equals(giaTriTim)
                           orderby kh.MAKH
                           select kh;
                List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

                foreach (KHACHHANG item in dskh)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.StrMaKH = item.MAKH;
                    kh.StrTenKH = item.TENKH;
                    kh.StrDiaChi = item.DIACHI;
                    kh.StrSoDienThoai = item.SDT;
                    kh.StrCMND = item.CMND;

                    lskh.Add(kh);
                }
                return lskh;
            }
            return null;
        }
        public List<DTO_KhachHang> layDanhSachKhachHang()
        {
            var dskh = dt.KHACHHANGs.Select(p => p).OrderBy(p => p.MAKH);

            List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

            foreach (KHACHHANG item in dskh)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.StrMaKH = item.MAKH;
                kh.StrTenKH = item.TENKH;
                kh.StrSoDienThoai = item.SDT;
                kh.StrDiaChi = item.DIACHI;
                kh.StrCMND = item.CMND;

                lskh.Add(kh);
            }
            return lskh;
        }

        public IEnumerable<KHACHHANG> getsTenXeTheoMaKH(string KH)
        {
            IEnumerable<KHACHHANG> kh = from n in dt.KHACHHANGs
                                        where n.MAKH == KH
                                        select n;
            return kh;
        }
    }
}

