namespace Bài_Thực_Hành_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            txtTen = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtSaochep = new TextBox();
            btnSaoChep = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 119);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(289, 119);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(270, 31);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(289, 173);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Xử Lý";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 244);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // txtSaochep
            // 
            txtSaochep.Location = new Point(289, 241);
            txtSaochep.Name = "txtSaochep";
            txtSaochep.ReadOnly = true;
            txtSaochep.Size = new Size(270, 31);
            txtSaochep.TabIndex = 4;
            // 
            // btnSaoChep
            // 
            btnSaoChep.Location = new Point(432, 173);
            btnSaoChep.Name = "btnSaoChep";
            btnSaoChep.Size = new Size(112, 34);
            btnSaoChep.TabIndex = 5;
            btnSaoChep.Text = "Sao chép";
            btnSaoChep.UseVisualStyleBackColor = true;
            btnSaoChep.Click += btnSaochep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaoChep);
            Controls.Add(txtSaochep);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Name = "Form1";
            Text = "Chương Trình Đầu Tiên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox txtTen;
        private Label label1;
        private Button button1;
        private TextBox txtSaochep;
        private Label label2;
        private Button btnSaoChep;
    }
}
