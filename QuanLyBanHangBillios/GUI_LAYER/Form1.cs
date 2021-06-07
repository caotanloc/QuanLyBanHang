using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_LAYER
{
    public partial class Form1 : Form
    {
        public static string email, matkhau;
        public static int session = 0;
        public static int profile = 0;
        public static string mail;

        public Form1(int login)
        {
            InitializeComponent();
            if (login == 1)
            {
                mnDangNhap.Enabled = false;
                mnDangXuat.Enabled = true;
                mnDoiMatKhau.Enabled = true;

                if(int.Parse(DangNhap.vaitro) == 0)
                {
                    VaiTroNV();
                }
                else
                {
                    quanLyNhanVien.Visible = true;
                    MenuThongKe.Visible = true;
                }

                
                
            }
            else
            {
                mnDangXuat.Enabled = false;
                mnDoiMatKhau.Enabled = false;
            }
            
        }
        


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void mnDangNhap_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            DangNhap frmDN = new DangNhap();
            frmDN.Activate();
            frmDN.Show();

        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            DangNhap.Login = 0;
            Form1 frm1 = new Form1(0);
            
            frm1.Activate();
            frm1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void VaiTroNV()
        {
            quanLyNhanVien.Visible = false;
            MenuThongKe.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (DangNhap.Login == 0)
            {
                xinChao.Visible = false;
                txtUser.Visible = false;
                MenuDanhMuc.Visible = false;
                MenuThongKe.Visible = false;
            }
            else
            {
                xinChao.Visible = true;
                txtUser.Text = DangNhap.email;
            }

            

            
        }

        private void xinChao_Click(object sender, EventArgs e)
        {

        }

        private void quanLyNhanVien_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            NhanVien nv = new NhanVien();
            nv.Activate();
            nv.Show();
        }

        private void KhachHangItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            KhachHang kh = new KhachHang();
            kh.Activate();
            kh.Show();
        }

        private void MenuHangHoa_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            HangHoa hh = new HangHoa();
            hh.Activate();
            hh.Show();
        }

        private void ThongKeiTem_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            ThongKe tk = new ThongKe();
            tk.Activate();
            tk.Show();
        }

        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau frmDoiMK = new DoiMatKhau(email);
            frmDoiMK.Activate();
            frmDoiMK.Show();
        }

        

       
    }
}
