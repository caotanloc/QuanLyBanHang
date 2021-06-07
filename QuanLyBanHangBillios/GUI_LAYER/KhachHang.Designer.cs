namespace GUI_LAYER
{
    partial class KhachHang
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.DgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckNam = new System.Windows.Forms.RadioButton();
            this.CheckNu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(417, 78);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(243, 46);
            this.txtDiaChi.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(237, 411);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(208, 23);
            this.txtTimKiem.TabIndex = 61;
            this.txtTimKiem.Text = "Nhập SĐT khách hàng để tìm kiếm";
            // 
            // DgvKhachHang
            // 
            this.DgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.DgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKhachHang.Location = new System.Drawing.Point(50, 160);
            this.DgvKhachHang.Name = "DgvKhachHang";
            this.DgvKhachHang.Size = new System.Drawing.Size(702, 243);
            this.DgvKhachHang.TabIndex = 60;
            this.DgvKhachHang.Click += new System.EventHandler(this.DgvKhachHang_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(166, 104);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(176, 20);
            this.txtHoTen.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Họ tên";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(166, 78);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(176, 20);
            this.txtDienThoai.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 54;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 72;
            this.label5.Text = "Giới tính";
            // 
            // CheckNam
            // 
            this.CheckNam.AutoSize = true;
            this.CheckNam.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNam.Location = new System.Drawing.Point(153, 135);
            this.CheckNam.Name = "CheckNam";
            this.CheckNam.Size = new System.Drawing.Size(51, 19);
            this.CheckNam.TabIndex = 73;
            this.CheckNam.TabStop = true;
            this.CheckNam.Text = "Nam";
            this.CheckNam.UseVisualStyleBackColor = true;
            // 
            // CheckNu
            // 
            this.CheckNu.AutoSize = true;
            this.CheckNu.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNu.Location = new System.Drawing.Point(210, 135);
            this.CheckNu.Name = "CheckNu";
            this.CheckNu.Size = new System.Drawing.Size(40, 19);
            this.CheckNu.TabIndex = 74;
            this.CheckNu.TabStop = true;
            this.CheckNu.Text = "Nữ";
            this.CheckNu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(150, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 27);
            this.panel2.TabIndex = 77;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::GUI_LAYER.Properties.Resources.Close_icon;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(625, 454);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 38);
            this.button8.TabIndex = 69;
            this.button8.Text = "Thoát";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.White;
            this.btnDanhSach.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Image = global::GUI_LAYER.Properties.Resources.Data_List_icon;
            this.btnDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSach.Location = new System.Drawing.Point(508, 454);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(111, 38);
            this.btnDanhSach.TabIndex = 68;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.White;
            this.btnBoQua.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Image = global::GUI_LAYER.Properties.Resources.Cancel;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(417, 454);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(85, 38);
            this.btnBoQua.TabIndex = 67;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.BackColor = System.Drawing.Color.White;
            this.Btn_Luu.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Luu.Image = global::GUI_LAYER.Properties.Resources.Save_icon;
            this.Btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Luu.Location = new System.Drawing.Point(329, 454);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(82, 38);
            this.Btn_Luu.TabIndex = 66;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = false;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI_LAYER.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(237, 454);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 38);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::GUI_LAYER.Properties.Resources.Actions_edit_delete_icon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(150, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 37);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_LAYER.Properties.Resources.add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(65, 454);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 37);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::GUI_LAYER.Properties.Resources.find;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(451, 411);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 62;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckNu);
            this.Controls.Add(this.CheckNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.DgvKhachHang);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KhachHang_FormClosed);
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView DgvKhachHang;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton CheckNam;
        private System.Windows.Forms.RadioButton CheckNu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}