using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using BUS_LAYER;
using DTO_LAYER;

namespace GUI_LAYER
{
    public partial class DangNhap : Form
    {
        BUS_NHANVIEN busNV = new BUS_NHANVIEN();
        public static int Login=0;
        public static string email = "";
        public static string vaitro { get; set; }
        public string matKhau { get; set; }
        public DangNhap()
        {
            InitializeComponent();
        }

        BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        private void SUBMIT_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.NV_Email = txtEmail.Text;
            nv.NV_MatKhau = busNhanVien.encryption(txtMatKhau.Text);
            try
            {
                if (busNhanVien.NhanVienDangNhap(nv))
                {
                    MessageBox.Show("Successfully");

                    Visible = false;
                    ShowInTaskbar = false;
                    email = txtEmail.Text;

                    DataTable dt = busNhanVien.LayVaiTro(txtEmail.Text);
                    vaitro = dt.Rows[0][0].ToString();
                 
                    Login = 1;

                    Form1 frm1 = new Form1(Login);
                    frm1.Activate();
                    frm1.Show();

                }
                else
                {
                    MessageBox.Show("Check your email or password");
                    txtEmail.Text = null;
                    txtMatKhau.Text = null;
                    txtEmail.Focus();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form1 frm1 = new Form1(DangNhap.Login);
            frm1.Activate();
            frm1.Show();

        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        

        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            
            if(txtEmail.Text != "")
            {
                if (busNV.QuenMatKhau(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(busNV.RandomString(4, true));
                    builder.Append(busNV.RanDomNumber(1000, 9999));
                    builder.Append(busNV.RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    //string matKhauMoi = busNV.encryption(builder.ToString());

                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.NV_Email = txtEmail.Text;
                    nv.NV_MatKhau = busNV.encryption(builder.ToString());

                    if (busNhanVien.TaoMatKhauMoi(nv))
                    {
                        MessageBox.Show("Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }

                    busNV.SendMail(txtEmail.Text, builder.ToString());

                    MessageBox.Show("Flease check your mail and got new password");

                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email");

                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin phục hồi mật khẩu");
                txtEmail.Focus();
            }

            
        }
    }
}
