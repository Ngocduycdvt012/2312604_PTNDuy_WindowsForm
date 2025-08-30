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
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSo.Text);
            int tinhTong = 0;
            int giaiThua = 1;
            if (rdTinhTong.Checked)
            {
                for (int i = n; i >= 1; i--)
                {
                    tinhTong += i;
                }
                lblGiaiThua.Text = tinhTong.ToString();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }
                lblGiaiThua.Text = giaiThua.ToString();
            }
        }

    }
}
