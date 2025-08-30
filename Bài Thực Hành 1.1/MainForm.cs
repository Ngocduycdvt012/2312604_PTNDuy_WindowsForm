using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Thục_Hành_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            MessageBox.Show("Bạn đã chọn giới tính Nam.", "Thông báo");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            MessageBox.Show("Bạn đã chọn giới tính Nữ", "Thông báo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdXanh.Checked)
                txtHopmau.BackColor = Color.Green;
            else
                txtHopmau.BackColor = Color.Red;
        }
    }
} 