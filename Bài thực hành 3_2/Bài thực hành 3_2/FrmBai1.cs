using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_thực_hành_3_2
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB01", "Chuột", "Việt Nam", 400000, 2);
            int donGia = tb.DonGia;
            int sl = tb.SoLuong;
            int kq = 0;
            kq=tb.ThanhTien(donGia, sl);
            lblThongBao.Text = tb.HienThi();
            lblKQThanhTien.Text = kq.ToString();
        }
    }
}
