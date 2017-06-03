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
    public partial class quanlytaikhoan : Form
    {
        public quanlytaikhoan()
        {
            InitializeComponent();
        }
        int dem;
        void hienthidanhsach()
        {
            DangNhapMod dn = new DangNhapMod();
            dgvtaikhoan.DataSource = dn.allds();
        }
        void clear()
        {
            txtid.Text = "";
            txttentaikhoan.Text = "";
            txtmk.Text = "";
            cmbGT.Text = "";
            dtpngaysinh.Text = "";

        }
        void bingding()
        {
            txtid.Text = "" + dgvtaikhoan.CurrentRow.Cells[0].Value;
          
            txttentaikhoan.Text = "" + dgvtaikhoan.CurrentRow.Cells[1].Value;

            cmbGT.Text = "" + dgvtaikhoan.CurrentRow.Cells[4].Value;
         
            dtpngaysinh.Text = "" + dgvtaikhoan.CurrentRow.Cells[3].Value;

            txtmk.Text = "" + dgvtaikhoan.CurrentRow.Cells[2].Value;


        }
        private void quanlytaikhoan_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
            bingding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dem = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtid.Enabled = false;
            txtid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bingding();
            dem = 2;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtid.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ? ", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Librarian dn = new Librarian();
                dn.ID = int.Parse(txtid.Text);
                new DangNhapMod().delete(dn);
                MessageBox.Show("xóa thành Công");
                hienthidanhsach();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (dem == 1)
            {
                if (txttentaikhoan.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tài khoản");
                }
                else if (txtmk.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                }
                else
                {
                    bool check = true;
                    foreach (DataGridViewRow dr in dgvtaikhoan.Rows)
                    {
                        if (txttentaikhoan.Text == dr.Cells[1].Value.ToString())
                        {
                            check = false;
                            MessageBox.Show("Tài khoản này đã tồn tại");
                            break;
                        }
                    }
                    if (check)
                    {
                        try
                        {
                            Librarian l = new Librarian();
                            //l.ID = int.Parse(txtid.Text);
                            l.Name = txttentaikhoan.Text;
                            l.Gender = cmbGT.Text=="Nam"?1:0;
                            l.Birthday = DateTime.Parse(dtpngaysinh.Text);
                            l.mk = txtmk.Text;

                            new DangNhapMod().insert(l);
                            MessageBox.Show("thêm mới thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                       
                    }
                }
               
               
            }
            else
            {
                if (dem == 2)
                {
                    if (txttentaikhoan.Text == "")
                    {
                        MessageBox.Show("Chưa nhập tên tài khoản");
                    }
                    else if (txtmk.Text == "")
                    {
                        MessageBox.Show("Chưa nhập mật khẩu");
                    }
                    else
                    {
                        bool check = true;
                        foreach (DataGridViewRow dr in dgvtaikhoan.Rows)
                        {
                            if (txttentaikhoan.Text == dr.Cells[1].Value.ToString()&&txttentaikhoan.Text!=dgvtaikhoan.CurrentRow.Cells[1].Value.ToString())
                            {
                                check = false;
                                MessageBox.Show("Tài khoản này đã tồn tại");
                                break;
                            }
                        }
                        if (check)
                        {
                            try
                            {
                                Librarian l = new Librarian();
                                l.ID = int.Parse(txtid.Text);
                                l.Name = txttentaikhoan.Text;
                                l.Gender = cmbGT.Text == "Nam" ? 1 : 0;
                                l.Birthday = DateTime.Parse(dtpngaysinh.Text);
                                l.mk = txtmk.Text;

                                new DangNhapMod().update(l);
                                MessageBox.Show("sửa thành công");
                                quanlytaikhoan_Load(sender, e);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
            hienthidanhsach();
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            quanlytaikhoan_Load(sender, e);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bingding();
        }
    }
}
