using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312606_BTWindowsForm_BT4
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "M001";
            sp.LoaiSanPham = "Bánh";
            sp.TenSanPham = "Bánh Que Pocky";
            sp.NgaySanXuat = DateTime.Parse("7/20/2025");
            lblThongBao.Text = sp.HienThi();
        }
    }
}
