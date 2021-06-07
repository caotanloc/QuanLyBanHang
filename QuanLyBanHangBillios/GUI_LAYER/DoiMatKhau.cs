using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_LAYER;
using DTO_LAYER;

namespace GUI_LAYER
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau(string email)
        {
            InitializeComponent();
            txtEmail.Text = DangNhap.email;
            txtEmail.Enabled = false;

        }

        BUS_NHANVIEN busTV = new BUS_NHANVIEN();

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            string MatKhau = busTV.encryption(txtMatkhauCu.Text);
            string mahoaMKM1 = busTV.encryption(txtMatKhauMoi1.Text);
            string mahoaMKM2 = busTV.encryption(txtMatKhauMoi2.Text);
            if (mahoaMKM1 == mahoaMKM2)
            {
                
                if (busTV.DoiMatKhau(txtEmail.Text, MatKhau, mahoaMKM1))
                {
                    MessageBox.Show("Đổi mật khẩu thành công !");
                    Visible = false;
                    ShowInTaskbar = false;
                    DangNhap dn = new DangNhap();
                    dn.Activate();
                    dn.Show();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới nhập sai");

            }

        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            
        }

        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
