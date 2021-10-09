using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public DTO_QuanLyXe.Login objDangNhap;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //thoa man ??
            int dem = 0;
            if (txtUsername.Text.Trim().Length == 0 || txtPasswd.Text.Length == 0)
            {
                dem++;
                MessageBox.Show("???");
            }
            else if (txtUsername.Text.Equals("user") && txtPasswd.Text.Trim().Equals("user"))

            {
                objDangNhap = new DTO_QuanLyXe.Login(txtUsername.Text.Trim(), txtPasswd.Text.Trim());
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                dem++;
                MessageBox.Show("???");
            }
            if (dem == 3)
            {
                MessageBox.Show("over lần???");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
