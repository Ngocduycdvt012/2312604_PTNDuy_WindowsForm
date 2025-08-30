using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_thực_hành_3_1
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHH = "HH01";
            hh.TenHH = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 5;
            hh.DonGia = 250000;
            lblThongBao.Text = hh.HienThi();
        }
    }
}
