using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAYER;
namespace DAL_LAYER
{
    public class DAL_HANGHOA : ConnectString
    {
        //Insert Hang Hoa 
        public bool InsertHangHoa(DTO_HANGHOA HangHoa)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoTblHang]";
                cmd.Parameters.AddWithValue("tenHang", HangHoa.SP_TenHang);
                cmd.Parameters.AddWithValue("soLuong", HangHoa.SP_SoLuong);
                cmd.Parameters.AddWithValue("donGiaNhap", HangHoa.SP_DonGiaNhap);
                cmd.Parameters.AddWithValue("donGiaBan", HangHoa.SP_DonGiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", HangHoa.SP_HinhAnh);
                cmd.Parameters.AddWithValue("ghiChu", HangHoa.SP_GhiChu);
                cmd.Parameters.AddWithValue("email", HangHoa.SP_EmailNV);

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

        //DanhSach Hang Hoa
        public DataTable DanhSachHangHoa()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachHang]";
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }
        }

        //Search Hang Hoa
        public DataTable SearchHangHoa(string tenHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchHang]";
                cmd.Parameters.AddWithValue("tenHang", tenHang);

                DataTable dataHangHoa = new DataTable();

                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }

        }

        //Delete Hang Hoa
        public bool DeleteHangHoa(int maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteDataFromtblHang]";
                cmd.Parameters.AddWithValue("maHang", maHang);

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

        //Update hang hoa
        public bool UpdateHangHoa(DTO_HANGHOA hh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateDataIntoTblHang]";
                cmd.Parameters.AddWithValue("maHang", hh.SP_MaHang);
                cmd.Parameters.AddWithValue("tenHang", hh.SP_TenHang);
                cmd.Parameters.AddWithValue("soLuong", hh.SP_SoLuong);
                cmd.Parameters.AddWithValue("donGiaNhap", hh.SP_DonGiaNhap);
                cmd.Parameters.AddWithValue("donGiaBan", hh.SP_DonGiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", hh.SP_HinhAnh);
                cmd.Parameters.AddWithValue("ghiChu", hh.SP_GhiChu);

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

        //SanPhamTonKho
        public DataTable SanPhamTonKho()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }
        }

        //Thong ke san pham
        public DataTable ThongKeSP()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }
        }


    }
}
