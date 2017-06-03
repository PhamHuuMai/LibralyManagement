using LibraryManege.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManege
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttendangnhap!=null && txtmatkhau !=null)
            {
              var res = new DangNhapMod().laydulieutaikhoan(txtmatkhau.Text,txttendangnhap.Text);
                if (res == null)
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công");
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    Form1 f = new Form1();
                    f.Show();
                }
                
            }
        }

    }
}
