using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManege.Model;
using System.IO;

namespace LibraryManege
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX4_Validating(object sender, CancelEventArgs e)
        {
            if ("".Contains(textBoxX4.Text))
                label1.Text = "* Bạn chưa nhập tên";
            else
            {
                // MessageBox.Show("sss"); 
                label1.Text = "";
            }
        }

        private void textBoxX3_Validating(object sender, CancelEventArgs e)
        {
            if ("".Contains(textBoxX3.Text))
                label5.Text = "* Bạn chưa nhập đơn vị";
            else
                label5.Text = "";
        }

        private void dateTimeInput3_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeInput3.Text.Equals(""))
            {
                label3.Text = "* Bạn chưa nhập ngày sinh";
            }
            else
            {
                label3.Text = "";
            }
        }

        private void dateTimeInput1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeInput1.Text.Equals(""))
            {
                label6.Text = "* Bạn chưa nhập ngày làm thẻ";
            }
            else
            {
                label6.Text = "";
            }
        }

        private void dateTimeInput2_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeInput2.Text.Equals(""))
            {
                label7.Text = "* Bạn chưa nhập ngày hết hạn";
            }
            else
            {
                label7.Text = "";
            }
        }

        private void Refresh()
        {
            labelX3.Text = "_ _";
            textBoxX4.Text = "";
            dateTimeInput1.Text = "";
            dateTimeInput2.Text = "";
            dateTimeInput3.Text = "";
            textBoxX3.Text = "";
            richTextBox1.Text = "";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            // dateTimeInput1.Value
            Refresh();
            Enable(true);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (labelX3.Text.Equals("_ _"))
            {
                MessageBox.Show("Bạn chưa chọn độc giả");
                buttonX4.Enabled = false;
                Enable(false);
            }
            else
            {
                Enable(true);
                buttonX4.Enabled = true;
            }
        }

        private void textBoxX9_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new ReaderModel()).SeachReader(textBoxX9.Text);
        }

        private void Enable(bool ch)
        {
            //labelX3.Enabled = ch;
            textBoxX4.Enabled = ch;
            dateTimeInput1.Enabled = ch;
            dateTimeInput2.Enabled = ch;
            dateTimeInput3.Enabled = ch;
            radioButton1.Enabled = ch;
            radioButton2.Enabled = ch;
            buttonX5.Enabled = ch;
            textBoxX3.Enabled = ch;
            richTextBox1.Enabled = ch;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Reader reader = (new ReaderModel()).GetReaderById((int)dataGridView1.CurrentRow.Cells[0].Value);
            labelX3.Text = "" + reader.ID;
            textBoxX4.Text = reader.FullName;
            dateTimeInput1.Value = reader.InitDate;
            dateTimeInput2.Value = reader.ExpDate;
            dateTimeInput3.Value = reader.Birthday;
            textBoxX3.Text = reader.Class;
            if (reader.Gender == 1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            if (reader.Images!=null) {
                MemoryStream ms = new MemoryStream(reader.Images);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Close();
            }
            richTextBox1.Text = reader.Note;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (labelX3.Text.Equals("_ _"))
            {
                //them
                if ("".Equals(label1.Text + label3.Text + label5.Text + label6.Text + label7.Text))
                {
                    Reader re = new Reader();
                    re.FullName = textBoxX4.Text;
                    re.Birthday = dateTimeInput3.Value;
                    re.ExpDate = dateTimeInput2.Value;
                    re.InitDate = dateTimeInput1.Value;
                    re.Gender = radioButton1.Checked ? 1 : 0;
                    re.Images = null;
                    if (!textBox1.Text.Equals(""))
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        re.Images = ms.ToArray();
                    }
                    re.Note = "".Contains(richTextBox1.Text) ? "NaN" : richTextBox1.Text;
                    re.Class = textBoxX3.Text;
                    (new ReaderModel()).AddReader(re);
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("Có gì đó sai sai");
                }
            }
            else
            {
                //sua
                if ("".Equals(label1.Text + label3.Text + label5.Text + label6.Text + label7.Text))
                {
                    Reader re = new Reader();
                    re.ID =Convert.ToInt32(labelX3.Text);
                    re.FullName = textBoxX4.Text;
                    re.Birthday = dateTimeInput3.Value;
                    re.ExpDate = dateTimeInput2.Value;
                    re.InitDate = dateTimeInput1.Value;
                    re.Gender = radioButton1.Checked ? 1 : 0;
                    re.Images = null;
                    if (!textBox1.Text.Equals(""))
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        re.Images = ms.ToArray();
                    }
                    re.Note = "".Contains(richTextBox1.Text) ? "NaN" : richTextBox1.Text;
                    re.Class = textBoxX3.Text;
                    (new ReaderModel()).UpdateReader(re);
                    MessageBox.Show("Thanh cong");
                }
                else
                {
                    MessageBox.Show("Có gì đó sai sai");
                }
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image file|*.jpg";
                openFileDialog1.ShowDialog();
                textBox1.Text = openFileDialog1.FileName;
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
            }
            catch
            {

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (labelX3.Text.Equals("_ _"))
            {
                MessageBox.Show("Bạn chưa chọn độc giả");
                buttonX4.Enabled = false;
                Enable(false);
            }
            else
            {
                Dialog dia = new Dialog();
                dia.ShowDialog();
                if (dia.I == 1)
                {
                    try
                    {
                        (new ReaderModel()).DeleteReader(Convert.ToInt32(labelX3.Text));
                        Refresh();
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
        }

       
    }
}
