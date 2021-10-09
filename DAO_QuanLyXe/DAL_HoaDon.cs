using DTO_QuanLyXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAL_HoaDon : DAL_KetNoi
    {
        QuanLyXeDataContext dt;

        public DAL_HoaDon()
        {
            dt = getDataContext();
        } 

        //Lay nguyen bang Hoa Don
        public List<object> getAllHoaDon()
        {
            var dshd = (from hd in dt.HOADONs
                        select new
                        {
                            MAHD = hd.MAHD,
                            NGAYLAPHD = hd.NGAYLAPHD,
                            MANV = hd.MANV,
                            MAKH = hd.MAKH,
                            TONGTIEN = hd.TONGTIEN,
                            MALOAI = hd.MALOAIHD
                        }).OrderBy(X => X.MAHD);

            List<Object> lshd = new List<object>();
            foreach(var item in dshd)
            {
                lshd.Add(item);
            }
            return lshd;
        }

        public bool suaHoaDon(DTO_HoaDon hdnew)
        {
            IQueryable<HOADON> hd = dt.HOADONs.Where(x => x.MAHD == hdnew.StrMaHD);
            if (hd.Count() >= 0)
            {
                hd.First().NGAYLAPHD = hdnew.DTNgayLapHD;
                hd.First().MANV = hdnew.StrMaNV;

                dt.SubmitChanges();

                return true;
            }
            return false;
        }

        public bool themHoaDon(DTO_HoaDon hd,DTO_ChiTietHoaDon cthd)
        {
                if (checkExist(hd.StrMaHD))
                    return false;

              HOADON hdtemp = new HOADON();
            CHITIETHD cthdtemp = new CHITIETHD();
             hdtemp.MAHD = hd.StrMaHD;
             hdtemp.MAKH = hd.StrMaKH;
             hdtemp.MANV = hd.StrMaNV;
             hdtemp.MALOAIHD = hd.StrLoaiHD;
             DateTime date = Convert.ToDateTime(hd.DTNgayLapHD);
             hdtemp.NGAYLAPHD = date;
             decimal Dec = Convert.ToDecimal(hd.ITongTien);
             hdtemp.TONGTIEN = Dec;

            cthdtemp.MAHD = cthd.StrMaHD;
            cthdtemp.MAXE = cthd.StrMaXe;
            cthdtemp.SOLUONG = cthd.ISoLuong;
            cthdtemp.DONGIA = cthd.IDonGia;
            cthdtemp.THANHTIEN = cthd.IThanhTien;

            dt.HOADONs.InsertOnSubmit(hdtemp);
            dt.CHITIETHDs.InsertOnSubmit(cthdtemp);
            dt.SubmitChanges();
                return true;
        }

        public bool xoaHoaDon(string mahd)
        {
            HOADON hdtemp = dt.HOADONs.Where(x => x.MAHD == mahd).FirstOrDefault();
            if(hdtemp != null)
            {
                dt.HOADONs.DeleteOnSubmit(hdtemp);
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        private bool checkExist(string strMaHD)
        {
            HOADON hdtemp = dt.HOADONs.Where(x => x.MAHD == strMaHD).FirstOrDefault();
            if(hdtemp != null)
            {
                return true;
            }
            return false;
        }
    }
}
