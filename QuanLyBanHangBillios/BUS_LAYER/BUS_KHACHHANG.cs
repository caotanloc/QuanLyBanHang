using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_LAYER;
using DTO_LAYER;

namespace BUS_LAYER
{
    public class BUS_KHACHHANG
    {
        DAL_KHACHHANG dalKhachHang = new DAL_KHACHHANG();

        //Insert Khach Hang
        public bool InsertKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.InsertKhachHang(kh);
        }
        // Danh Sach khach hang
        public DataTable DanhSachKhachHang()
        {
            return dalKhachHang.DanhSachKhachHang();
        }
        //Xoa khach hang
        public bool DeleteKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.DeleteKhachHang(kh);
        }

        //Cap nhat thong tin khach hang
        public bool UpdateKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.CapNhatThongTinKH(kh);
        }

        //Tim kiem khach hang
        public DataTable SearchNhanVien(string dienThoai)
        {
            return dalKhachHang.SearchKhachHang(dienThoai);
        }
    }
}
