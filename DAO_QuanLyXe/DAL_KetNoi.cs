using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAL_KetNoi
    {
        QuanLyXeDataContext dt;
        public QuanLyXeDataContext getDataContext()
        {
            string Str = @"Data Source=DESKTOP-S7SHOJ8\tomoe;Initial Catalog=QLXE;Integrated Security=True";
            dt = new QuanLyXeDataContext(Str);
            dt.Connection.Open();
            return dt;
        }
    }
}
