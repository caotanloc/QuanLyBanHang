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
    public class BUS_HANGHOA
    {
        DAL_HANGHOA dalHangHoa = new DAL_HANGHOA();
        //insert Khach Hang
        public bool InsertHangHoa(DTO_HANGHOA hh)
        {
            return dalHangHoa.InsertHangHoa(hh);
        }
        //Danh sach khach hang
        public DataTable DanhSachHangHoa()
        {
            return dalHangHoa.DanhSachHangHoa();
        }

        //Search khach hang
        public DataTable SearchHangHoa(string tenHang)
        {
            return dalHangHoa.SearchHangHoa(tenHang);
        }

        //Delete hang hoa
        public bool DeleteHangHoa(int maHang)
        {
            return dalHangHoa.DeleteHangHoa(maHang);
        }

        //Update HangHoa
        public bool UpdateHangHoa(DTO_HANGHOA h)
        {
            return dalHangHoa.UpdateHangHoa(h);
        }

        //San pham ton kho
        public DataTable SanPhamTonKho()
        {
            return dalHangHoa.SanPhamTonKho();
        }
        //Thong ke san pham
        public DataTable ThongKeSanPham()
        {
            return dalHangHoa.ThongKeSP();
        }
    }
}
