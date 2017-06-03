using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManege.FrameModel;
using LibraryManege.Model;
using System.IO;

namespace LibraryManege
{
    public partial class Form1 : Form
    {
        private int f = 1;
        public Form1()
        {
            InitializeComponent();
            f = 1;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            f = 1;
            textBoxX2.Text = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            textBoxX4.Enabled = false;
            f = 0;
            textBoxX2.Text = "";
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DauSac ds = new DauSac();
            ds.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.ShowDialog();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            RefreshScreen();
            if (f == 1)
            {
                try
                {
                    int id = Convert.ToInt32(textBoxX2.Text);
                    BorrowInfor bi = new BorrowInfor(id);
                    dataGridView1.DataSource = bi.ListBook;
                    labelX22.Text = "" + bi.Reader.ID;
                    labelX7.Text = bi.Reader.FullName;
                    labelX8.Text = bi.Reader.Class;
                    labelX3.Text = bi.Reader.Birthday.Day + "/" + bi.Reader.Birthday.Month + "/" + bi.Reader.Birthday.Year;
                    MemoryStream ms = new MemoryStream(bi.Reader.Images);
                    reflectionImage1.Image = Image.FromStream(ms);
                    labelX4.Text = bi.Reader.Gender == 1 ? "Nam" : "Nữ";
                    richTextBox1.Text = bi.Reader.Note;
                    labelX10.Text = bi.Reader.InitDate.Day + "/" + bi.Reader.InitDate.Month + "/" + bi.Reader.InitDate.Year;
                    labelX12.Text = bi.Reader.ExpDate.Day + "/" + bi.Reader.ExpDate.Month + "/" + bi.Reader.ExpDate.Year;
                    textBoxX4.Enabled = true;
                   // MessageBox.Show("Đã mượn cuốn sách có id=" + id + "của người có ID=" + bi.Reader.ID);
                }
                catch (Exception ee)
                {
                    textBoxX4.Enabled = false;
                }
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBoxX2.Text);
                    PayInfor pi = (new BookModel()).PayBook(id);
                    dataGridView1.DataSource = pi.LisBook;
                    labelX22.Text = "" + pi.Reader.ID;
                    labelX7.Text = pi.Reader.FullName;
                    labelX8.Text = pi.Reader.Class;
                    labelX3.Text = pi.Reader.Birthday.Day + "/" + pi.Reader.Birthday.Month + "/" + pi.Reader.Birthday.Year;
                    labelX4.Text = pi.Reader.Gender == 1 ? "Nam" : "Nữ";
                    richTextBox1.Text = pi.Reader.Note;
                    labelX10.Text = pi.Reader.InitDate.Day + "/" + pi.Reader.InitDate.Month + "/" + pi.Reader.InitDate.Year;
                    labelX12.Text = pi.Reader.ExpDate.Day + "/" + pi.Reader.ExpDate.Month + "/" + pi.Reader.ExpDate.Year;
                    textBoxX4.Enabled = true;
                    MessageBox.Show("Đã trả cuốn sách có id=" + id + "của người có ID=" + pi.Reader.ID);
                }
                catch (Exception ee)
                {
                    //  MessageBox.Show(ee.Message);
                }
            }
        }

        private void RefreshScreen()
        {
            dataGridView1.DataSource = null;
            labelX22.Text = "..";
            labelX7.Text = "..";
            labelX8.Text = "..";
            labelX3.Text = "dd/mm/yyyy";
            labelX4.Text = "Nam/Nữ";
            richTextBox1.Text = "NaN";
            labelX10.Text = "dd/mm/yyyy";
            labelX12.Text = "dd/mm/yyyy";
        }

        private void textBoxX4_TextChan(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(labelX22.Text);
                int i = (new BookModel()).BorrowBook(Convert.ToInt32(labelX22.Text), Convert.ToInt32(textBoxX4.Text), 2);
                textBoxX2_TextChanged(sender, e);
                if (i == 1)
                {
                    MessageBox.Show("Đã trả cuốn sách có id=" + textBoxX4.Text + "của người có ID=" + labelX22.Text);
                }
                if (i == 0)
                {
                    MessageBox.Show("Đã mượn cuốn sách có id=" + textBoxX4.Text + "của người có ID=" + labelX22.Text);
                }
            }
            catch (Exception ee)
            {
                textBoxX2_TextChanged(sender, e);
                //    MessageBox.Show(ee.Message);
            }
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = (new BookModel()).SeachHeaderBook(textBoxX3.Text);

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookInfor bi = new BookInfor((int)(dataGridViewX1.CurrentRow.Cells[0].Value));
            labelX24.Text = bi.Header.Name;
            labelX25.Text = bi.Header.Authors;
            labelX28.Text = "" + bi.CountAll;
            labelX27.Text = "" + bi.CountRemaining;
        }

        private void buttonX2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                MessageBox.Show("sssssssssssssss");
                textBoxX4_TextChan(sender, e);
            }
        }


        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                textBoxX2_TextChanged(sender, e);
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            quanlytaikhoan dn = new quanlytaikhoan();
            dn.ShowDialog();
        }
    }
}
