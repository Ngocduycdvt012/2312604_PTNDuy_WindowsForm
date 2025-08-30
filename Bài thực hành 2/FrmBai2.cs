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
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBHHChon.SelectedItem;
            listBHHBo.Items.Add(item);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            foreach (string hang in listBHHBo.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        tongtien += 100000;
                        break;
                    case "Máy in":
                        tongtien += 2000000000;
                            break;
                    case "Bàn phím":
                        tongtien += 150000;
                        break;
                    case "USB Kingmax":
                        tongtien += 200000;
                        break;
                }
                lbTien.Text = tongtien + " đồng";
            }
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBHHBo.Items.Remove(listBHHBo.SelectedItem);
        }
    }
}
