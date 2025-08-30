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
    public partial class FrmBai3 : Form
    {
        List <string> list = new List <string> ();
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tu = tbAnh.Text;
            listBoxTuMoi.Items.Add(tbAnh.Text);
            list.Add(tu);
        }

        private void tbNghia_TextChanged(object sender, EventArgs e)
        {
            var stt = listBoxTuMoi.SelectedIndex;
            tbNghia.Text = list[stt];
        }
    }
}
