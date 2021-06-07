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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            LoadGridView_ThongKeHang();
            LoadGridView_ThongkeTonKho();
        }
        private void LoadGridView_ThongKeHang()
        {
            BUS_HANGHOA busHang = new BUS_HANGHOA();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = busHang.ThongKeSanPham();
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Số Lượng Sản Phẩm Nhập";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void LoadGridView_ThongkeTonKho()
        {
            BUS_HANGHOA busHang = new BUS_HANGHOA();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.DataSource = busHang.SanPhamTonKho();
            dataGridView2.Columns[0].HeaderText = "Tên Sản Phẩm";
            dataGridView2.Columns[1].HeaderText = "Số Lượng Tồn";
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form1 f1 = new Form1(DangNhap.Login);
            f1.Activate();
            f1.Show();
        }

        private void ThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
