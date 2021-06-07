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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            
        }
        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Bạn cần phải nhập số điện thoại");
            }
            else if(txtDienThoai.Text.Trim().Length <10 || txtDienThoai.Text.Trim().Length >10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }
            else if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn cần phải nhập tên khách hàng");
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn cần phải nhập địa chỉ");
            }
            else if (CheckNam.Checked == false && CheckNu.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn giới tính");
            }
            else
            {
                BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();

                string GioiTinh = "Nữ";
                if (CheckNam.Checked)
                {
                    GioiTinh = "Nam";
                }
                DTO_KHACHHANG kh = new DTO_KHACHHANG(txtDienThoai.Text, txtHoTen.Text, txtDiaChi.Text, GioiTinh, DangNhap.email);
                
                if (busKhachHang.InsertKhachHang(kh))
                {
                    MessageBox.Show("Insert Successfully");
                    DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
                    DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    Btn_Luu.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            
        }

        

         private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
         {
            Application.Exit();
         }

        public void SetDisableValue()
        {
            txtHoTen.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            CheckNam.Enabled = false;
            CheckNu.Enabled = false;
        }
        public void SetNameDataKhachHang()
        {
            DgvKhachHang.Columns[0].HeaderText = "Số điện thoại";
            DgvKhachHang.Columns[1].HeaderText = "Mã nhân viên";
            DgvKhachHang.Columns[2].HeaderText = "Tên khách hàng";
            DgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            DgvKhachHang.Columns[4].HeaderText = "Giới tính";
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();
            SetDisableValue();
            btnDelete.Enabled = false;
            btnSua.Enabled = false;
            Btn_Luu.Enabled = false;
            btnBoQua.Enabled = false;
            btnDanhSach.Enabled = false;
            
            

            DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
            DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SetNameDataKhachHang();

        }

        public void SetEnableValue()
        {
            txtHoTen.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            CheckNam.Enabled = true;
            CheckNu.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetEnableValue();
            Btn_Luu.Enabled = true;
            btnBoQua.Enabled = true;
            btnDelete.Enabled = false;
            btnSua.Enabled = false;
            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
            txtHoTen.Text = null;
            txtDienThoai.Focus();
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            SetDisableValue();
            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
            txtHoTen.Text = null;
            btnDelete.Enabled = false;
            btnSua.Enabled = false;
            
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();

            DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
            DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Form1 frm1 = new Form1(DangNhap.Login);
            frm1.Activate();
            frm1.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();
            DTO_KHACHHANG kh = new DTO_KHACHHANG();
            kh.DIENTHOAI = txtDienThoai.Text;

            if (busKhachHang.DeleteKhachHang(kh))
            {
                MessageBox.Show("Xóa thành công");
                DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
                DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
                DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void DgvKhachHang_Click(object sender, EventArgs e)
        {
            if(DgvKhachHang.Rows.Count > 1)
            {
                SetEnableValue();
                Btn_Luu.Enabled = false;
                btnBoQua.Enabled = true;
                btnDanhSach.Enabled = true;
                btnDelete.Enabled = true;
                btnSua.Enabled = true;

                try
                {
                    txtDienThoai.Text = DgvKhachHang.CurrentRow.Cells["dienthoai"].Value.ToString();
                    txtHoTen.Text = DgvKhachHang.CurrentRow.Cells["tenKhach"].Value.ToString();
                    txtDiaChi.Text = DgvKhachHang.CurrentRow.Cells["diaChi"].Value.ToString();

                    if (DgvKhachHang.CurrentRow.Cells["phai"].Value.ToString() == "Nam")
                    {
                        CheckNam.Checked = true;
                    }
                    else
                    {
                        CheckNu.Checked = true;
                    }

                    txtDienThoai.Enabled = false;

                }
                catch (Exception)
                {

                }


            }
        }

        //Cap nhat thong tin
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Bạn cần phải nhập số điện thoại");
            }
            else if(string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn cần phải nhập tên khách hàng");
            }
            else if(string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn cần phải nhập địa chỉ");
            }
            else if (CheckNam.Checked == false && CheckNu.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn giới tính");
            }
            else
            {
                BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();

                string GioiTinh = "Nữ";
                if (CheckNam.Checked)
                {
                    GioiTinh = "Nam";
                }
                DTO_KHACHHANG kh = new DTO_KHACHHANG();
                kh.DIENTHOAI = txtDienThoai.Text;
                kh.TENKHACH = txtHoTen.Text;
                kh.DIACHI = txtDiaChi.Text;
                kh.PHAI = GioiTinh;

                if (busKhachHang.UpdateKhachHang(kh))
                {
                    MessageBox.Show("Update Info Successfully");
                    DgvKhachHang.DataSource = busKhachHang.DanhSachKhachHang();
                    DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();
            if(string.IsNullOrEmpty(txtTimKiem.Text) || string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn cần phải nhập số điện thoại để thực hiện tìm kiếm");
            }
            else
            {
                DataTable ds = busKhachHang.SearchNhanVien(txtTimKiem.Text);
                if (ds.Rows.Count > 0)
                {
                    DgvKhachHang.DataSource = ds;
                    btnDanhSach.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                }
            }
        }
    }
}
