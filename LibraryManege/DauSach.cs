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
    public partial class DauSac : Form
    {
        public DauSac()
        {
            InitializeComponent();
            cmbNXB.DataSource = new NhaXuatBanMod().getAllds();
            cmbNXB.DisplayMember = "Name";
            cmbNXB.ValueMember = "ID";
          //  bingding();
        }
        int dem;
        void hienthidanhsach()
        {
            dausachMod h = new dausachMod();
            dgvdausach.DataSource = h.load();
           bingding();
        }
        void clear()
        {
            txtid.Text = "";
            cmbNXB.Text = "";
            txtphienban.Text = "";
            txtsotrang.Text = "";
            txttacgia.Text = "";
            txttendausach.Text = "";
            txttheloai.Text = "";
            txttimkemdausach.Text = "";
            dtpngayxuatban.Text = "";

        }
        void bingding()
        {
            txtid.Clear();
            txtid.DataBindings.Clear();
            txtid.DataBindings.Add("text", dgvdausach.DataSource, "ID");
            txttendausach.Clear();
            txttendausach.DataBindings.Clear();
            txttendausach.DataBindings.Add("text", dgvdausach.DataSource, "Name");
            dtpngayxuatban.Text = "";
            dtpngayxuatban.DataBindings.Clear();
            dtpngayxuatban.DataBindings.Add("text", dgvdausach.DataSource, "Date");
            cmbNXB.Text="";
            cmbNXB.DataBindings.Clear();
            cmbNXB.DataBindings.Add("text", dgvdausach.DataSource, "TenNXB");
            txtsotrang.Clear();
            txtsotrang.DataBindings.Clear();
            txtsotrang.DataBindings.Add("text", dgvdausach.DataSource, "PageNumber");
            txttheloai.Clear();
            txttheloai.DataBindings.Clear();
            txttheloai.DataBindings.Add("text", dgvdausach.DataSource, "Type");
            txttacgia.Clear();
            txttacgia.DataBindings.Clear();
            txttacgia.DataBindings.Add("text", dgvdausach.DataSource, "Authors");
            txtphienban.Clear();
            txtphienban.DataBindings.Clear();
            txtphienban.DataBindings.Add("text", dgvdausach.DataSource, "Version");
        
        }
        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }



        private void textBoxX2_Validating(object sender, CancelEventArgs e)
        {
            if (txttendausach.Text.Equals(""))
            {
                MessageBox.Show("ddddd");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dem = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            txtid.Enabled = false;
            txtid.Clear();
        
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bingding();
            dem = 2;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtid.Enabled = false;
            btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Header dn = new Header();
                dn.ID = int.Parse(txtid.Text);
                new dausachMod().delete(dn);
                MessageBox.Show("xóa thành Công");
                hienthidanhsach();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (dem == 1)
            {
                Header l = new Header();
                //   l.ID = int.Parse(txtid.Text);
                if (txttendausach.Text == "")
                {
                    MessageBox.Show("Chưa nhập Tên đầu sách");
                }
                else if (dtpngayxuatban.Text == "")
                {
                    MessageBox.Show("Chưa nhập ngày xuất bản");
                }
                else if (txtphienban.Text == "")
                {
                    l.Version = 1;
                }
                else if (cmbNXB.Text == "")
                {
                    MessageBox.Show("Chưa chọn Nhà xuất bản");
                }
                else if (txtsotrang.Text == "")
                {

                    MessageBox.Show("Chưa nhập số trang");
                }
                else
                {
                    try
                    {
                        l.Name = txttendausach.Text;
                        l.Date = DateTime.Parse(dtpngayxuatban.Text);
                        l.Version = int.Parse(txtphienban.Text);
                        l.IDNXB = int.Parse(cmbNXB.SelectedValue.ToString());
                        l.Authors = txttacgia.Text;
                        l.Type = txttheloai.Text;
                        l.PageNumber = int.Parse(txtsotrang.Text);

                        new dausachMod().insert(l);
                        MessageBox.Show("thêm mới thành công");
                        hienthidanhsach();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
               
                
            }
            else
            {
                if (dem == 2)
                {

                    Header l = new Header();
                    //   l.ID = int.Parse(txtid.Text);
                    if (txttendausach.Text == "")
                    {
                        MessageBox.Show("Chưa nhập Tên đầu sách");
                    }
                    else if (dtpngayxuatban.Text == "")
                    {
                        MessageBox.Show("Chưa nhập ngày xuất bản");
                    }
                    else if (txtphienban.Text == "")
                    {
                        l.Version = 1;
                    }
                    else if (cmbNXB.Text == "")
                    {
                        MessageBox.Show("Chưa chọn Nhà xuất bản");
                    }
                    else if (txtsotrang.Text == "")
                    {

                        MessageBox.Show("Chưa nhập số trang");
                    }
                    else
                    {
                        try
                        {
                           
                            l.ID = int.Parse(txtid.Text);
                            l.Name = txttendausach.Text;
                            l.Date = DateTime.Parse(dtpngayxuatban.Text);
                            l.Version = int.Parse(txtphienban.Text);
                            l.IDNXB = int.Parse(cmbNXB.SelectedValue.ToString());
                            l.Authors = txttacgia.Text;
                            l.Type = txttheloai.Text;
                            l.PageNumber = int.Parse(txtsotrang.Text);
                            new dausachMod().update(l);
                            MessageBox.Show("sửa thành công");
                            DauSach_Load(sender, e);
                            hienthidanhsach();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                   
                }
            }
           
        }

        private void DauSach_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
            //bingding();
        }

        private void txttimkemdausach_TextChanged(object sender, EventArgs e)
        {
            dausachMod ds = new dausachMod();
            dgvdausach.DataSource = ds.laydulieutheokeyword(txttimkemdausach.Text);
            bingding();
        }

        private void dgvdausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bingding();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
        }
    }
}
