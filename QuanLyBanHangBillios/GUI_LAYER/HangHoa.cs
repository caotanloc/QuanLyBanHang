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
using DTO_LAYER;
using BUS_LAYER;
using System.IO;

namespace GUI_LAYER
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        string stremail = DangNhap.email;
        private string PathImage = string.Empty;
        private string LastImage = string.Empty;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtHinh.Enabled = true;
            txtGhiChu.Enabled = true;
            ChooseFile.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnDanhSach.Enabled = true;

            txtMaHang.Text = null;
            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaNhap.Text = null;
            txtDonGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
            picHinh.Image = null;
            txtTenHang.Focus();

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            
        }
        public void SetNameData()
        {
            DgvSanPham.Columns[0].HeaderText = "Mã SP";
            DgvSanPham.Columns[1].HeaderText = "Mã nhân viên";
            DgvSanPham.Columns[2].HeaderText = "Tên SP";
            DgvSanPham.Columns[3].HeaderText = "Hình ảnh";
            DgvSanPham.Columns[4].HeaderText = "Ghi chú";
            DgvSanPham.Columns[5].HeaderText = "Đơn giá nhập";
            DgvSanPham.Columns[6].HeaderText = "Đơn giá bán";
            DgvSanPham.Columns[7].HeaderText = "Số lượng";


        }
        
        private void HangHoa_Load(object sender, EventArgs e)
        {
            BUS_HANGHOA busHang = new BUS_HANGHOA();
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = false;
            ChooseFile.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            DgvSanPham.DataSource = busHang.DanhSachHangHoa();
            DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SetNameData();
            

        }
        string fileName;
        string fileSavePath;
        string fileAdress;
        string checkUrlImage;


        private void ChooseFile_Click(object sender, EventArgs e)
        {
            //Check folder ton tai
            string PathImages = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            if (!File.Exists(PathImages)) //Neu ton tai
            {
                //Tao folder Images
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                Directory.CreateDirectory(path);
            }
            LastImage = txtHinh.Text;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picHinh.Image = Image.FromFile(dlgOpen.FileName);
                    txtHinh.Text = dlgOpen.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            picHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            dlgOpen.Dispose();
        }

        private void HangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_HANGHOA busHang = new BUS_HANGHOA();
            #region Validation data
            int intSoLuong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            float floatDonGiaNhap;
            bool isFloatNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
            float floatDonGiaBan;
            bool isFloatBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out floatDonGiaBan);
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isFloatNhap || float.Parse(txtDonGiaNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isFloatBan || float.Parse(txtDonGiaBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picHinh.Image == null) // Kiểm tra phải nhập hình
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
            else
            {
                string nameImage = string.Empty;
                try
                {
                    //Get name image
                    nameImage = txtHinh.Text.Substring(txtHinh.Text.LastIndexOf('\\') + 2);
                    picHinh.Image.Save(Path.Combine(Directory.GetCurrentDirectory(), "Images", nameImage));
                    DTO_HANGHOA h = new DTO_HANGHOA(
                        txtTenHang.Text,
                        int.Parse(txtSoLuong.Text),
                        float.Parse(txtDonGiaNhap.Text),
                        float.Parse(txtDonGiaBan.Text),
                        Path.Combine("Images", nameImage),
                        txtGhiChu.Text, stremail);
                    if (busHang.InsertHangHoa(h))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        //File.Copy(fileAddress, fileSavePath, true);
                        DgvSanPham.DataSource = busHang.DanhSachHangHoa();
                        DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void SetEnableValue()
        {
            txtTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtHinh.Enabled = true;
            txtGhiChu.Enabled = true;

        }
        
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_HANGHOA busHangHoa = new BUS_HANGHOA();
            if (string.IsNullOrEmpty(txtTimKiem.Text) || string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn cần phải nhập tên sản phẩm để thực hiện tìm kiếm");
            }
            else
            {
                DataTable ds = busHangHoa.SearchHangHoa(txtTimKiem.Text);
                if (ds.Rows.Count > 0)
                {
                    DgvSanPham.DataSource = ds;
                    btnDanhSach.Enabled = true;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnBoQua.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_HANGHOA busHangHoa = new BUS_HANGHOA();

            if (busHangHoa.DeleteHangHoa(int.Parse(txtMaHang.Text)))
            {
                DgvSanPham.DataSource = busHangHoa.DanhSachHangHoa();
                DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                MessageBox.Show("Xóa không thành công");
                DgvSanPham.DataSource = busHangHoa.DanhSachHangHoa();
                DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtTenHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = false;
            ChooseFile.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnDanhSach.Enabled = false;

            txtMaHang.Text = null;
            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaNhap.Text = null;
            txtDonGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
            picHinh.Image = null;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnDanhSach.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void DgvSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                txtMaHang.Text = DgvSanPham.CurrentRow.Cells["maHang"].Value.ToString();
                txtTenHang.Text = DgvSanPham.CurrentRow.Cells["tenHang"].Value.ToString();
                txtSoLuong.Text = DgvSanPham.CurrentRow.Cells["soLuong"].Value.ToString();
                txtDonGiaNhap.Text = DgvSanPham.CurrentRow.Cells["donGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = DgvSanPham.CurrentRow.Cells["donGiaBan"].Value.ToString();
                txtHinh.Text = DgvSanPham.CurrentRow.Cells["hinhAnh"].Value.ToString();
                txtGhiChu.Text = DgvSanPham.CurrentRow.Cells["ghiChu"].Value.ToString();
                picHinh.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), txtHinh.Text));
                picHinh.SizeMode = PictureBoxSizeMode.StretchImage;

                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

            }
            catch (Exception)
            {

            }
            txtTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtHinh.Enabled = true;
            txtGhiChu.Enabled = true;
            ChooseFile.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
            btnDanhSach.Enabled = true;

        }

        

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            BUS_HANGHOA busHangHoa = new BUS_HANGHOA();
            DgvSanPham.DataSource = busHangHoa.DanhSachHangHoa();
            DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS_HANGHOA busHang = new BUS_HANGHOA();
            #region Validation data
            int intSoLuong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            float floatDonGiaNhap;
            bool isFloatNhap = float.TryParse(txtDonGiaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
            float floatDonGiaBan;
            bool isFloatBan = float.TryParse(txtDonGiaBan.Text.Trim().ToString(), out floatDonGiaBan);
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isFloatNhap || float.Parse(txtDonGiaNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isFloatBan || float.Parse(txtDonGiaBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picHinh.Image == null) // Kiểm tra phải nhập hình
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChooseFile.Focus();
                return;
            }
            #endregion
            else
            {
                string nameImage = string.Empty;
                try
                {
                    //Get name image

                    nameImage = txtHinh.Text.Substring(txtHinh.Text.LastIndexOf('\\') + 2);

                    picHinh.Image.Save(Path.Combine(Directory.GetCurrentDirectory(), "Images", nameImage));
                    DTO_HANGHOA h = new DTO_HANGHOA(int.Parse(txtMaHang.Text), txtTenHang.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonGiaNhap.Text), float.Parse(txtDonGiaBan.Text), Path.Combine("Images", nameImage), txtGhiChu.Text);
                    if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (busHang.UpdateHangHoa(h))
                        {
                            MessageBox.Show("Sửa thành công");

                            DgvSanPham.DataSource = busHang.DanhSachHangHoa();
                            DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            picHinh.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công");
                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form1 f1 = new Form1(DangNhap.Login);
            f1.Activate();
            f1.Show();
        }
    }

}
