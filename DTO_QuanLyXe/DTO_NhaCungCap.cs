using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_NhaCungCap
    {
        string _StrMaNCC;
        string _StrTenNCC;
       

   
        public DTO_NhaCungCap()
        {

        }

        public DTO_NhaCungCap(string StrMaNCC, string StrTenNCC)
        {
            this.StrMaNCC = StrMaNCC;
            this.StrTenNCC = StrTenNCC;
        }

        public string StrMaNCC
        {
            get
            {
                return _StrMaNCC;
            }

            set
            {
                _StrMaNCC = value;
            }
        }

        public string StrTenNCC
        {
            get
            {
                return _StrTenNCC;
            }

            set
            {
                _StrTenNCC = value;
            }
        }
    }
}
