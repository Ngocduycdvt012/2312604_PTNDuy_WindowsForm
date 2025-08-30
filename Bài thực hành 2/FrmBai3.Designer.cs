namespace Bài_thực_hành_2._1
{
    partial class FrmBai3
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
            this.lbTumoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnh = new System.Windows.Forms.TextBox();
            this.tbViet = new System.Windows.Forms.TextBox();
            this.listBoxTuMoi = new System.Windows.Forms.ListBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.tbNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTumoi
            // 
            this.lbTumoi.AutoSize = true;
            this.lbTumoi.Location = new System.Drawing.Point(52, 43);
            this.lbTumoi.Name = "lbTumoi";
            this.lbTumoi.Size = new System.Drawing.Size(60, 20);
            this.lbTumoi.TabIndex = 0;
            this.lbTumoi.Text = "Từ mới:";
            this.lbTumoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghĩa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // tbAnh
            // 
            this.tbAnh.Location = new System.Drawing.Point(147, 37);
            this.tbAnh.Name = "tbAnh";
            this.tbAnh.Size = new System.Drawing.Size(256, 26);
            this.tbAnh.TabIndex = 4;
            this.tbAnh.TextChanged += new System.EventHandler(this.tbAnh_TextChanged);
            // 
            // tbViet
            // 
            this.tbViet.Location = new System.Drawing.Point(147, 101);
            this.tbViet.Name = "tbViet";
            this.tbViet.Size = new System.Drawing.Size(256, 26);
            this.tbViet.TabIndex = 5;
            // 
            // listBoxTuMoi
            // 
            this.listBoxTuMoi.FormattingEnabled = true;
            this.listBoxTuMoi.ItemHeight = 20;
            this.listBoxTuMoi.Location = new System.Drawing.Point(103, 243);
            this.listBoxTuMoi.Name = "listBoxTuMoi";
            this.listBoxTuMoi.Size = new System.Drawing.Size(279, 164);
            this.listBoxTuMoi.TabIndex = 6;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(189, 145);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(116, 32);
            this.btnThemTu.TabIndex = 7;
            this.btnThemTu.Text = "Thêm từ mới";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // tbNghia
            // 
            this.tbNghia.Location = new System.Drawing.Point(476, 243);
            this.tbNghia.Multiline = true;
            this.tbNghia.Name = "tbNghia";
            this.tbNghia.ReadOnly = true;
            this.tbNghia.Size = new System.Drawing.Size(258, 164);
            this.tbNghia.TabIndex = 8;
            this.tbNghia.TextChanged += new System.EventHandler(this.tbNghia_TextChanged);
            // 
            // FrmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNghia);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.listBoxTuMoi);
            this.Controls.Add(this.tbViet);
            this.Controls.Add(this.tbAnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTumoi);
            this.Name = "FrmBai3";
            this.Text = "Từ điển Anh Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnh;
        private System.Windows.Forms.TextBox tbViet;
        private System.Windows.Forms.ListBox listBoxTuMoi;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.TextBox tbNghia;
    }
}