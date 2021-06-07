namespace GUI_LAYER
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeiTem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xinChao1 = new System.Windows.Forms.Label();
            this.xinChao2 = new System.Windows.Forms.Label();
            this.xinChao = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.MenuDanhMuc,
            this.MenuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangNhap,
            this.mnDangXuat,
            this.mnDoiMatKhau,
            this.Exit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnDangNhap
            // 
            this.mnDangNhap.Name = "mnDangNhap";
            this.mnDangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnDangNhap.Size = new System.Drawing.Size(219, 22);
            this.mnDangNhap.Text = "Đăng nhập";
            this.mnDangNhap.Click += new System.EventHandler(this.mnDangNhap_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnDangXuat.Size = new System.Drawing.Size(219, 22);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnDoiMatKhau.Size = new System.Drawing.Size(219, 22);
            this.mnDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnDoiMatKhau.Click += new System.EventHandler(this.mnDoiMatKhau_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit.Size = new System.Drawing.Size(219, 22);
            this.Exit.Text = "Thoát";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuDanhMuc
            // 
            this.MenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNhanVien,
            this.KhachHangItem,
            this.MenuHangHoa});
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.MenuDanhMuc.Text = "Danh mục";
            // 
            // quanLyNhanVien
            // 
            this.quanLyNhanVien.Name = "quanLyNhanVien";
            this.quanLyNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.quanLyNhanVien.Size = new System.Drawing.Size(210, 22);
            this.quanLyNhanVien.Text = "Nhân viên";
            this.quanLyNhanVien.Click += new System.EventHandler(this.quanLyNhanVien_Click);
            // 
            // KhachHangItem
            // 
            this.KhachHangItem.Name = "KhachHangItem";
            this.KhachHangItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.KhachHangItem.Size = new System.Drawing.Size(210, 22);
            this.KhachHangItem.Text = "Khách hàng";
            this.KhachHangItem.Click += new System.EventHandler(this.KhachHangItem_Click);
            // 
            // MenuHangHoa
            // 
            this.MenuHangHoa.Name = "MenuHangHoa";
            this.MenuHangHoa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.MenuHangHoa.Size = new System.Drawing.Size(210, 22);
            this.MenuHangHoa.Text = "Hàng hóa";
            this.MenuHangHoa.Click += new System.EventHandler(this.MenuHangHoa_Click);
            // 
            // MenuThongKe
            // 
            this.MenuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongKeiTem});
            this.MenuThongKe.Name = "MenuThongKe";
            this.MenuThongKe.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.MenuThongKe.Size = new System.Drawing.Size(68, 20);
            this.MenuThongKe.Text = "Thống kê";
            // 
            // ThongKeiTem
            // 
            this.ThongKeiTem.Name = "ThongKeiTem";
            this.ThongKeiTem.Size = new System.Drawing.Size(180, 22);
            this.ThongKeiTem.Text = "Báo cáo thống kê";
            this.ThongKeiTem.Click += new System.EventHandler(this.ThongKeiTem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_LAYER.Properties.Resources.Untitled_design_34;
            this.pictureBox2.Location = new System.Drawing.Point(231, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(639, 381);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_LAYER.Properties.Resources.LogoF1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // xinChao1
            // 
            this.xinChao1.AutoSize = true;
            this.xinChao1.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xinChao1.Location = new System.Drawing.Point(434, 57);
            this.xinChao1.Name = "xinChao1";
            this.xinChao1.Size = new System.Drawing.Size(0, 22);
            this.xinChao1.TabIndex = 4;
            // 
            // xinChao2
            // 
            this.xinChao2.AutoSize = true;
            this.xinChao2.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xinChao2.Location = new System.Drawing.Point(530, 57);
            this.xinChao2.Name = "xinChao2";
            this.xinChao2.Size = new System.Drawing.Size(0, 22);
            this.xinChao2.TabIndex = 5;
            // 
            // xinChao
            // 
            this.xinChao.AutoSize = true;
            this.xinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xinChao.Location = new System.Drawing.Point(293, 33);
            this.xinChao.Name = "xinChao";
            this.xinChao.Size = new System.Drawing.Size(88, 21);
            this.xinChao.TabIndex = 6;
            this.xinChao.Text = "Xin chào:  ";
            this.xinChao.Click += new System.EventHandler(this.xinChao_Click);
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(370, 33);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(88, 21);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "Xin chào:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.xinChao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xinChao2);
            this.Controls.Add(this.xinChao1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý bán hàng | Billios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem KhachHangItem;
        private System.Windows.Forms.ToolStripMenuItem MenuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem MenuThongKe;
        private System.Windows.Forms.ToolStripMenuItem ThongKeiTem;
        private System.Windows.Forms.Label xinChao1;
        private System.Windows.Forms.Label xinChao2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Label xinChao;
        private System.Windows.Forms.Label txtUser;
    }
}

