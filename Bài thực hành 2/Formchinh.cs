using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_thực_hành_2._1
{
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new FrmBai2();
            form.ShowDialog();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new FrmBai1();
            form.ShowDialog();
        }

        private void tmsiBai3_Click(object sender, EventArgs e)
        {
            var form = new FrmBai3();
            form.ShowDialog();
        }
    }
}
