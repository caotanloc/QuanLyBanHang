namespace GUI_LAYER
{
    partial class DoiMatKhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatkhauCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_LAYER.Properties.Resources.LogoF1;
            this.pictureBox1.Location = new System.Drawing.Point(130, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email nhân viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMatkhauCu
            // 
            this.txtMatkhauCu.Location = new System.Drawing.Point(104, 266);
            this.txtMatkhauCu.Name = "txtMatkhauCu";
            this.txtMatkhauCu.Size = new System.Drawing.Size(212, 20);
            this.txtMatkhauCu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtMatKhauMoi1
            // 
            this.txtMatKhauMoi1.Location = new System.Drawing.Point(104, 309);
            this.txtMatKhauMoi1.Name = "txtMatKhauMoi1";
            this.txtMatKhauMoi1.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhauMoi1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu mới: ";
            // 
            // txtMatKhauMoi2
            // 
            this.txtMatKhauMoi2.Location = new System.Drawing.Point(104, 353);
            this.txtMatKhauMoi2.Name = "txtMatKhauMoi2";
            this.txtMatKhauMoi2.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhauMoi2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(145, 380);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(116, 31);
            this.btnDoiMatKhau.TabIndex = 10;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhauMoi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatkhauCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoiMatKhau_FormClosed);
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatkhauCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauMoi1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button button2;
    }
}