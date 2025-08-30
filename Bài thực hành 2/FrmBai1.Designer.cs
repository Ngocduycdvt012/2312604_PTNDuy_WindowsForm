namespace Bài_thực_hành_2._1
{
    partial class FrmBai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbMauXe = new System.Windows.Forms.GroupBox();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btTinhTien = new System.Windows.Forms.Button();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbMauXe
            // 
            this.grbMauXe.Controls.Add(this.rbDo);
            this.grbMauXe.Controls.Add(this.rdTrang);
            this.grbMauXe.Controls.Add(this.rdXanh);
            this.grbMauXe.Location = new System.Drawing.Point(393, 23);
            this.grbMauXe.Name = "grbMauXe";
            this.grbMauXe.Size = new System.Drawing.Size(238, 240);
            this.grbMauXe.TabIndex = 1;
            this.grbMauXe.TabStop = false;
            this.grbMauXe.Text = "chọn màu xe";
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(37, 110);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(55, 24);
            this.rbDo.TabIndex = 2;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(37, 151);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(75, 24);
            this.rdTrang.TabIndex = 1;
            this.rdTrang.TabStop = true;
            this.rdTrang.Text = "Trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(37, 68);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(72, 24);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(46, 290);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(64, 20);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá";
            this.lbDonGia.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(120, 290);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(268, 26);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = "20000";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(120, 328);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(159, 26);
            this.txtSoLuong.TabIndex = 5;
            // 
            // btTinhTien
            // 
            this.btTinhTien.Location = new System.Drawing.Point(120, 373);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(144, 33);
            this.btTinhTien.TabIndex = 6;
            this.btTinhTien.Text = "Tính tiền";
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(388, 329);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(335, 25);
            this.lbTongtien.TabIndex = 7;
            this.lbTongtien.Text = "TỔNG TIỀN CẦN THANH TOÁN:";
            this.lbTongtien.Click += new System.EventHandler(this.lbTongtien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(393, 381);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(24, 25);
            this.lbSoTien.TabIndex = 9;
            this.lbSoTien.Text = "0";
            this.lbSoTien.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            // 
            // FrmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.grbMauXe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmBai1";
            this.Text = "FrmBai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbMauXe.ResumeLayout(false);
            this.grbMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbMauXe;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label label4;
    }
}