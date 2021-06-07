using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO_LAYER;

namespace DAL_LAYER
{
    public class DAL_KHACHHANG : ConnectString
    {
        //insert khach hang
        public bool InsertKhachHang(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoTblKhach]";
                cmd.Parameters.AddWithValue("dienThoai", kh.DIENTHOAI);
                cmd.Parameters.AddWithValue("tenKhach", kh.TENKHACH);
                cmd.Parameters.AddWithValue("diaChi", kh.DIACHI);
                cmd.Parameters.AddWithValue("phai", kh.PHAI);
                cmd.Parameters.AddWithValue("email", kh.EMAIL_NHANVIEN);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;

        }

        //DanhSachKhachHang
        public DataTable DanhSachKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachKhach]";
                DataTable dataKhachHang = new DataTable();
                dataKhachHang.Load(cmd.ExecuteReader());
                return dataKhachHang;
            }
            finally
            {
                _conn.Close();
            }
            

        }

        //Xoa Khach Hang
        public bool DeleteKhachHang(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteDataFromtblKhach]";
                cmd.Parameters.AddWithValue("dienthoai", kh.DIENTHOAI);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Cap Nhat Thong Tin Khach Hang
        public bool CapNhatThongTinKH(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateDataIntoTblKhach]";
                cmd.Parameters.AddWithValue("dienThoai", kh.DIENTHOAI);
                cmd.Parameters.AddWithValue("tenKhach", kh.TENKHACH);
                cmd.Parameters.AddWithValue("diaChi", kh.DIACHI);
                cmd.Parameters.AddWithValue("phai", kh.PHAI);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Search Khach Hang
        public DataTable SearchKhachHang(string soDienThoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchKhach]";
                cmd.Parameters.AddWithValue("dienthoai", soDienThoai);

                DataTable dataKhachHang = new DataTable();
                dataKhachHang.Load(cmd.ExecuteReader());
                return dataKhachHang;
            }
            finally
            {
                _conn.Close();
            }

        }



    }
}
