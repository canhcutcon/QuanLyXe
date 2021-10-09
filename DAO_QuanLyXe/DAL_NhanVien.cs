using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;

namespace DAO_QuanLyXe
{
    public class DAL_NhanVien: DAL_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAL_NhanVien()
        {
            dt = new QuanLyXeDataContext();
        }

        public List<DTO_QuanLyXe.DTO_NhanVien> layDSNhanVien()
        {
            var dsnv = dt.NHANVIENs.Select(p => p).OrderBy(p => p.MANV);

            List<DTO_QuanLyXe.DTO_NhanVien> list_NV = new List<DTO_QuanLyXe.DTO_NhanVien>();

            foreach (NHANVIEN item in dsnv)
            {
                DTO_QuanLyXe.DTO_NhanVien nv = new DTO_QuanLyXe.DTO_NhanVien();
                nv.StrMaNV = item.MANV;
                nv.StrTenNV = item.TENNV;
                nv.DTNgaySinh = item.NGAYSINH.Value;
                nv.StrCMND = item.CMND;
                nv.StrSDT = item.SDT;
                nv.StrDiaChi = item.DIACHI;
                nv.StrGioiTinh = item.GIOITINH.ToString();
                list_NV.Add(nv);
            }
            return list_NV;
        }

        private bool ChechFrmExist(string maNV)
        {
            NHANVIEN nvtemp = dt.NHANVIENs.Where(x => x.MANV.Equals(maNV)).FirstOrDefault();
            if (nvtemp != null)
            {
                return true;
            }
            return false;
        }

        public bool themNV(DTO_QuanLyXe.DTO_NhanVien nvnew)
        {
            if (ChechFrmExist(nvnew.StrMaNV))
            {
                return false;
            }

            NHANVIEN nvtemp = new NHANVIEN();
            nvtemp.MANV = nvnew.StrMaNV;
            nvtemp.TENNV = nvnew.StrTenNV;
            nvtemp.NGAYSINH = nvnew.DTNgaySinh;
            nvtemp.CMND = nvnew.StrCMND;
            nvtemp.SDT = nvnew.StrSDT;
            nvtemp.DIACHI = nvnew.StrDiaChi;
            if(nvnew.StrGioiTinh.ToString().Contains("Nam"))
                nvtemp.GIOITINH = true; 
            else
                nvtemp.GIOITINH = false;
            dt.NHANVIENs.InsertOnSubmit(nvtemp);
            dt.SubmitChanges();
            return true;
        }

        public bool xoaNV(string maNhanVien)
        {
            NHANVIEN temp = dt.NHANVIENs.Where(x => x.MANV.Equals(maNhanVien)).FirstOrDefault();
            if (temp != null)
            {
                dt.NHANVIENs.DeleteOnSubmit(temp);
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaNV(DTO_QuanLyXe.DTO_NhanVien nvnew)
        {
            IQueryable<NHANVIEN> nv = dt.NHANVIENs.Where(x => x.MANV.Equals(nvnew.StrMaNV));
            if (nv.Count() >= 0)
            {
                nv.First().TENNV = nvnew.StrTenNV;
                nv.First().NGAYSINH = nvnew.DTNgaySinh;
                nv.First().CMND = nvnew.StrCMND;
                nv.First().SDT = nvnew.StrSDT;
                nv.First().DIACHI = nvnew.StrDiaChi;
                if (nvnew.StrGioiTinh.Equals("Nam")|| nvnew.StrGioiTinh.Equals("nam"))
                    nv.First().GIOITINH = true;
                else
                    nv.First().GIOITINH = false;
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        public DTO_QuanLyXe.DTO_NhanVien layNhanVienTheoTen(string tennv)
        {
            NHANVIEN nvtemp = dt.NHANVIENs.Where(p => p.TENNV.Equals(tennv)).FirstOrDefault();

            DTO_QuanLyXe.DTO_NhanVien nv = new DTO_QuanLyXe.DTO_NhanVien();
            nv.StrMaNV = nvtemp.MANV;
            nv.StrTenNV = nvtemp.TENNV;
            nv.DTNgaySinh = nvtemp.NGAYSINH.Value;
            nv.StrSDT = nvtemp.SDT;
            nv.StrCMND = nvtemp.CMND;
            nv.StrDiaChi = nvtemp.DIACHI;
            //nv.StrGioiTinh = nvtemp.GIOITINH;
            return nv;
        }

        public List<DTO_QuanLyXe.DTO_NhanVien> layNhanVienTheoAutocompalet(string giaTriTim, bool theoTen)
        {
            if (theoTen)
            {
                var dsnv = from nv in dt.NHANVIENs
                           where nv.TENNV.StartsWith(giaTriTim)
                           orderby nv.MANV
                           select nv;
                List<DTO_QuanLyXe.DTO_NhanVien> lsnv = new List<DTO_QuanLyXe.DTO_NhanVien>();

                foreach (NHANVIEN item in dsnv)
                {
                    DTO_QuanLyXe.DTO_NhanVien nv = new DTO_QuanLyXe.DTO_NhanVien();
                    nv.StrMaNV = item.MANV;
                    nv.StrTenNV = item.TENNV;
                    nv.DTNgaySinh = item.NGAYSINH.Value;
                    nv.StrCMND = item.CMND;
                    nv.StrSDT = item.SDT;
                    nv.StrDiaChi = item.DIACHI;
                    nv.StrGioiTinh = item.GIOITINH.ToString();

                    lsnv.Add(nv);
                }
                return lsnv;
            }
            else
            {
                var dsnv = from nv in dt.NHANVIENs
                           where nv.MANV.Equals(giaTriTim)
                           orderby nv.MANV
                           select nv;
                List<DTO_QuanLyXe.DTO_NhanVien> lsnv = new List<DTO_QuanLyXe.DTO_NhanVien>();

                foreach (NHANVIEN item in dsnv)
                {
                    DTO_QuanLyXe.DTO_NhanVien nv = new DTO_QuanLyXe.DTO_NhanVien();
                    nv.StrMaNV = item.MANV;
                    nv.StrTenNV = item.TENNV;
                    nv.DTNgaySinh = item.NGAYSINH.Value;
                    nv.StrCMND = item.CMND;
                    nv.StrSDT = item.SDT;
                    nv.StrDiaChi = item.DIACHI;
                    nv.StrGioiTinh = item.GIOITINH.ToString();

                    lsnv.Add(nv);
                }
                return lsnv;
            }
            return null;
        }
        public List<DTO_NhanVien> layDanhSachNV()
        {
            var dsNV = dt.NHANVIENs.Select(p => p).OrderBy(p => p.MANV);

            List<DTO_NhanVien> lsnv = new List<DTO_NhanVien>();

            foreach (NHANVIEN item in dsNV)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.StrMaNV = item.MANV;
                nv.StrTenNV = item.TENNV;
                nv.DTNgaySinh = (DateTime)item.NGAYSINH;
                nv.StrSDT = item.SDT;
                nv.StrDiaChi = item.DIACHI;
                nv.StrCMND = item.CMND;
                nv.StrGioiTinh = item.GIOITINH == true ? "Nam" : "Nu";
                lsnv.Add(nv);
            }
            return lsnv;
        }
    }
}
