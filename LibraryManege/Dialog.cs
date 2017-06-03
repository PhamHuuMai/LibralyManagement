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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }
        private int i = -1;

        public int I
        {
            get
            {
                return i;
            }
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            i = 1;
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            i = 0;
            this.Close();
        }
    }
}
