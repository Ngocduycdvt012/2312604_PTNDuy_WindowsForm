using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_thực_hành_3_3
{
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var form = new FrmBai1();
            form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var form = new FrmBai2();
            form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var form = new FrmBai3();
            form.ShowDialog();
        }

        private void Formchinh_Load(object sender, EventArgs e)
        {

        }
    }
}
