namespace Bài_thực_hành_2._1
{
    partial class FrmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBHHChon = new System.Windows.Forms.ListBox();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.listBHHBo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBHHChon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBHHChon
            // 
            this.listBHHChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBHHChon.FormattingEnabled = true;
            this.listBHHChon.ItemHeight = 20;
            this.listBHHChon.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím",
            "USB Kingmax"});
            this.listBHHChon.Location = new System.Drawing.Point(48, 72);
            this.listBHHChon.Name = "listBHHChon";
            this.listBHHChon.Size = new System.Drawing.Size(195, 242);
            this.listBHHChon.TabIndex = 1;
            this.listBHHChon.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(258, 161);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(125, 53);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.listBHHBo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(399, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 426);
            this.panel2.TabIndex = 1;
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(16, 161);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(125, 53);
            this.btnBoHang.TabIndex = 2;
            this.btnBoHang.Text = "< Trả hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // listBHHBo
            // 
            this.listBHHBo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBHHBo.FormattingEnabled = true;
            this.listBHHBo.ItemHeight = 20;
            this.listBHHBo.Location = new System.Drawing.Point(147, 72);
            this.listBHHBo.Name = "listBHHBo";
            this.listBHHBo.Size = new System.Drawing.Size(195, 242);
            this.listBHHBo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(143, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách hàng hóa đã mua";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tính tiền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền:";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTien.Location = new System.Drawing.Point(173, 388);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(24, 25);
            this.lbTien.TabIndex = 5;
            this.lbTien.Text = "0";
            // 
            // FrmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBHHChon;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox listBHHBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTien;
    }
}