namespace Bài_Thực_Hành_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSaochep.Text = txtTen.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất Vui Được Gặp Bạn");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaochep_Click(object sender, EventArgs e)
        {
            txtSaochep.Text = txtTen.Text;
        }
    }
}
