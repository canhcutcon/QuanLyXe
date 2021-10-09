using DTO_QuanLyXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAL_ChiTietHoaDon : DAL_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAL_ChiTietHoaDon()
        {
            dt = getDataContext();
        }

        public IEnumerable<dynamic> getChiTietHDThuocHD(string StrMaLoai)
        {
            IEnumerable<dynamic> q;
            if (StrMaLoai.Equals(""))
            {
                q = (from hd in dt.HOADONs
                     join n in dt.CHITIETHDs on hd.MAHD equals n.MAHD
                     join kh in dt.KHACHHANGs on hd.MAKH equals kh.MAKH
                     join xe in dt.XEs on n.MAXE equals xe.MAXE
                     join lhd in dt.LOAIHDs on hd.MALOAIHD equals lhd.MALOAIHD
                     join nv in dt.NHANVIENs on hd.MANV equals nv.MANV
                     select new { MaHD = n.MAHD, MaXe = xe.MAXE, TenKH = kh.TENKH, MAKH = kh.MAKH, NgayLap = hd.NGAYLAPHD, LoaiHD = lhd.TENLOAIHD, TenXe = xe.TENXE, PhanKhoi = xe.PHANKHOI, DonGia = xe.DONGIABAN, SoLuong = n.SOLUONG, ThanhTien = (xe.DONGIABAN * n.SOLUONG), NHANVIEN = nv.MANV }).OrderBy(x => x.MaHD);
            }
            else
            {
                q = (from hd in dt.HOADONs
                     join n in dt.CHITIETHDs on hd.MAHD equals n.MAHD
                     join kh in dt.KHACHHANGs on hd.MAKH equals kh.MAKH
                     join xe in dt.XEs on n.MAXE equals xe.MAXE
                     join lhd in dt.LOAIHDs on hd.MALOAIHD equals lhd.MALOAIHD
                     join nv in dt.NHANVIENs on hd.MANV equals nv.MANV
                     where lhd.MALOAIHD.Equals(StrMaLoai)
                     select new { MaHD = n.MAHD, MaXe = xe.MAXE, TenKH = kh.TENKH, MAKH = kh.MAKH, NgayLap = hd.NGAYLAPHD, LoaiHD = lhd.TENLOAIHD, TenXe = xe.TENXE, PhanKhoi = xe.PHANKHOI, DonGia = xe.DONGIABAN, SoLuong = n.SOLUONG, ThanhTien = (xe.DONGIABAN * n.SOLUONG), NHANVIEN = nv.MANV }).OrderBy(x => x.MaHD);
            }
            return q;
        }

        public IEnumerable<CHITIETHD> getsInforCTHD()
        {
            IEnumerable<CHITIETHD> cthd = from n in dt.CHITIETHDs
                                          select n;
            return cthd;
        }

        public List<object> getsInforTimKiem(string strTimkiem)
        {
            if (strTimkiem.Equals("") == false)
            {
                var q = (from hd in dt.HOADONs
                         join n in dt.CHITIETHDs on hd.MAHD equals n.MAHD
                         join kh in dt.KHACHHANGs on hd.MAKH equals kh.MAKH
                         join xe in dt.XEs on n.MAXE equals xe.MAXE
                         join lhd in dt.LOAIHDs on hd.MALOAIHD equals lhd.MALOAIHD
                         join nv in dt.NHANVIENs on hd.MANV equals nv.MANV
                         where n.MAHD.Equals(strTimkiem)
                         select new { MaHD = n.MAHD, MaXe = xe.MAXE, TenKH = kh.TENKH, MAKH = kh.MAKH, NgayLap = hd.NGAYLAPHD, LoaiHD = lhd.TENLOAIHD, TenXe = xe.TENXE, PhanKhoi = xe.PHANKHOI, DonGia = xe.DONGIABAN, SoLuong = n.SOLUONG, ThanhTien = (xe.DONGIABAN * n.SOLUONG), NHANVIEN = nv.MANV }).OrderBy(x => x.MaHD);
                List<object> lst = new List<object>();
                foreach (var item in q)
                {
                    lst.Add(item);
                }
                return lst;
            }
            else
            {
                
                List<object> lst = new List<object>();
                return lst;
            }    
        }

        public bool suaCTHoaDon(DTO_ChiTietHoaDon cthdnew)
        {
            IQueryable<CHITIETHD> cthd = dt.CHITIETHDs.Where(x => x.MAHD == cthdnew.StrMaHD);
            if (cthd.Count() >= 0)
            {
                cthd.First().MAXE = cthdnew.StrMaXe;
                cthd.First().SOLUONG = cthdnew.ISoLuong;
                cthd.First().DONGIA = cthdnew.IDonGia;
                cthd.First().THANHTIEN = cthdnew.IThanhTien;

                dt.SubmitChanges();

                return true;
            }
            return false;
        }
    }
}
