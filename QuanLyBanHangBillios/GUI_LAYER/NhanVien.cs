using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_LAYER;
using DTO_LAYER;
using System.Net.Mail;
namespace GUI_LAYER
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN busNV = new BUS_NHANVIEN();

        private void DanhSach_Click(object sender, EventArgs e)
        {
            dataGridViewNhanVien.DataSource = busNV.getNhanVien();
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ResetValue()
        {
            txtHoTen.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            
            vaiTro1.Enabled = false;
            VaiTro2.Enabled = false;
            tinhTrang1.Enabled = false;
            tinhTrang2.Enabled = false;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnDanhSach.Enabled = false;
            btnBoQua.Enabled = false;
            txtHoTen.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            

        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            ResetValue();
            dataGridViewNhanVien.DataSource = busNV.getNhanVien();
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SetNameData();

        }
        //Check Email
        public bool CheckEmail(string EmailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(EmailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        //Set Name Data
        public void SetNameData()
        {
            dataGridViewNhanVien.Columns[0].HeaderText = "Email";
            dataGridViewNhanVien.Columns[1].HeaderText = "Họ tên";
            dataGridViewNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNhanVien.Columns[3].HeaderText = "Vai trò";
            dataGridViewNhanVien.Columns[4].HeaderText = "Tình trạng";
        }


        //Them nhan vien
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnDanhSach.Enabled = true;
            btnBoQua.Enabled = true;
            btnThoat.Enabled = true;

            vaiTro1.Enabled = true;
            VaiTro2.Enabled = true;
            tinhTrang1.Enabled = true;
            tinhTrang2.Enabled = true;
            txtEmail.Focus();
            txtHoTen.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            vaiTro1.Checked = false;
            VaiTro2.Checked = false;
            tinhTrang1.Checked = false;
            tinhTrang2.Checked = false;
        }

        //Luu nhan vien
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ///Set Value
            int role = 0;
            if (VaiTro2.Checked)
            {
                role = 1;
            }
            int tinhTrang = 0;
            if (tinhTrang2.Checked)
            {
                tinhTrang = 1;
            }

            //Check Checkbox
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Email");
                return;
            }
            else if (!CheckEmail(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không đúng định dạng");
                return;
            }

            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return;

            }
            else if(txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return;
            }

            if(vaiTro1.Checked == false && VaiTro2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái vai trò");
                return;
            }
            else if (tinhTrang1.Checked == false && tinhTrang2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái vai trò");
                return;
            }
            else
            {
                if (busNV.ThemNhanVien(txtEmail.Text, txtHoTen.Text, txtDiaChi.Text, role, tinhTrang))
                {
                    MessageBox.Show("Đã thêm nhân viên");
                    dataGridViewNhanVien.DataSource = busNV.getNhanVien();

                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }


            
            

        }
        public void SetEnabelValue()
        {
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            vaiTro1.Enabled = true;
            VaiTro2.Enabled = true;
            tinhTrang1.Enabled = true;
            tinhTrang2.Enabled = true;
        }
        private void dataGridViewNhanVien_Click(object sender, EventArgs e)
        {
            if(dataGridViewNhanVien.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                txtTimKiem.Enabled = true;  
                btnTimKiem.Enabled = true;
                SetEnabelValue();
                try
                {
                    txtEmail.Text = dataGridViewNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                    txtHoTen.Text = dataGridViewNhanVien.CurrentRow.Cells["tenNv"].Value.ToString();
                    txtDiaChi.Text = dataGridViewNhanVien.CurrentRow.Cells["diaChi"].Value.ToString();
                    if(int.Parse(dataGridViewNhanVien.CurrentRow.Cells["vaiTro"].Value.ToString()) == 0)
                    {
                        vaiTro1.Checked = true;
                    }
                    else
                    {
                        VaiTro2.Checked = true;
                    }
                    
                    if(int.Parse(dataGridViewNhanVien.CurrentRow.Cells["tinhTrang"].Value.ToString()) == 0)
                    {
                        tinhTrang1.Checked = true;
                    }
                    else
                    {
                        tinhTrang2.Checked = true;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text);
            BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
            try
            {
                if (busNhanVien.XoaNhanVien(nv))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewNhanVien.DataSource = busNV.getNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int vaiTro = 0;
            if (VaiTro2.Checked)
            {
                vaiTro = 1;
            }

            int tinhTrang = 0;
            if (tinhTrang2.Checked)
            {
                tinhTrang = 1;
            }

            //Check Checkbox
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Email");
                return;
            }
            else if (!CheckEmail(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không đúng định dạng");
                return;
            }

            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return;

            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return;
            }

            if (vaiTro1.Checked == false && VaiTro2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái vai trò");
                return;
            }
            else if (tinhTrang1.Checked == false && tinhTrang2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái vai trò");
                return;
            }
            else
            {
                if (busNV.CapNhatNhanVien(txtEmail.Text,txtHoTen.Text, txtDiaChi.Text, vaiTro, tinhTrang))
                {
                    MessageBox.Show("Cập nhật thành công nhân viên");
                    dataGridViewNhanVien.DataSource = busNV.getNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTimKiem.Text;
            DataTable ds = busNV.SearchNhanVien(tenNhanVien);
            if(ds.Rows.Count > 0)
            {
                dataGridViewNhanVien.DataSource = ds;
                btnDanhSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form1 frm1 = new Form1(DangNhap.Login);
            frm1.Activate();
            frm1.Show();
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
