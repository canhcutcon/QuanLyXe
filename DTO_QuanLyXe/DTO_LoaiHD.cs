using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_LoaiHD
    {
        private string _StrMaLoai;
        private string _StrTenLoai;


        public DTO_LoaiHD () { }
        public string StrMaLoai
        {
            get
            {
                return _StrMaLoai;
            }

            set
            {
                _StrMaLoai = value;
            }
        }

        public string StrTenLoai
        {
            get
            {
                return _StrTenLoai;
            }

            set
            {
                _StrTenLoai = value;
            }
        }
    }
}
