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
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("2312604", "Phạm Thái Ngọc Duy", "13/10/2004", 12, 2.7);
            double kq = 0;

            lblThongBao.Text = nv.HienThi();
            kq = nv.TinhLuong();
            lblLuong.Text = kq.ToString();
        }
    }
}
