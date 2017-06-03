using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManege.FrameModel
{
    public partial class For1 : Form
    {
        public For1()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void textBoxX1_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("2");
        }
    }
}
