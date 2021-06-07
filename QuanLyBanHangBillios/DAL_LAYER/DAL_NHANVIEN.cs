using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAYER;


namespace DAL_LAYER
{
    public class DAL_NHANVIEN : ConnectString
    {
        
        // Dang Nhap He Thong
        public bool DangNhapHeThong(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("email", nv.NV_Email);
                cmd.Parameters.AddWithValue("matKhau", nv.NV_MatKhau);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
        //Lay Vai Tro Nhan Vien
        public DataTable LayVaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroNV]";
                cmd.Parameters.AddWithValue("email", email);
                DataTable dataNhanVien = new DataTable();
                dataNhanVien.Load(cmd.ExecuteReader());
                return dataNhanVien;
            }
            finally
            {
                _conn.Close();
            }
        }
        //Lay Danh Sach Nhan Vien
        public DataTable getNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachNV]";
                DataTable dataNhanVien = new DataTable();
                dataNhanVien.Load(cmd.ExecuteReader());
                return dataNhanVien;
            }
            finally
            {
                _conn.Close();
            }
            
        }

        //Them Nhan Vien
        public bool themNhanVien(string email, string hoTen, string diaChi, int vaiTro, int tinhTrang)
        {
            
            try
            {
                _conn.Open();
                string query = string.Format("Exec dbo.InsertDataIntoTblNhanVien @email,@hoTen,@diaChi,@vaiTro,@tinhTrang");
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@hoTen", hoTen);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);
                cmd.Parameters.AddWithValue("@vaiTro", vaiTro);
                cmd.Parameters.AddWithValue("tinhTrang", tinhTrang);
                
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Doi Mat Khau
        public bool DoiMatKhau(string email, string opass, string npass )
        {
            try
            {
                _conn.Open();
                string query = string.Format("exec dbo.chgpwd @email,@mkc,@mkm");
                SqlCommand cmd = new SqlCommand(query,_conn);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@mkc",opass);
                cmd.Parameters.AddWithValue("@mkm", npass);
                if ((int)cmd.ExecuteNonQuery() > 0)
                {
                    return true;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Quen Mat Khau
        public bool QuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                _conn.Close();

            }
            return false;
        }

        //Tao Mat Khau Moi
        public bool TaoMatKhauMoi(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email", nv.NV_Email);
                cmd.Parameters.AddWithValue("matkhau", nv.NV_MatKhau);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();

            }
            return false;
        }

        //Xoa Nhan Vien
        public bool XoaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblNhanVien";
                cmd.Parameters.AddWithValue("email", nv.NV_Email);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch(Exception)
            {
                
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }


        //Cap Nhat Nhan Vien
        public bool UpdateInfoNhanVien(string Email,string TenNV, string DiaChi, int VaiTro, int TinhTrang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateDataIntoTblNhanVien]";
             
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("tenNv", TenNV);
                cmd.Parameters.AddWithValue("diaChi", DiaChi);
                cmd.Parameters.AddWithValue("vaiTro", VaiTro);
                cmd.Parameters.AddWithValue("tinhTrang", TinhTrang);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        //Tim Kiem Nhan Vien
        public DataTable SearchNhanVien(string hoTen)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchNhanVien]";
                cmd.Parameters.AddWithValue("tenNv", hoTen);

                DataTable dataNhanVien = new DataTable();
                dataNhanVien.Load(cmd.ExecuteReader());
                return dataNhanVien;
            }
            finally
            {
                _conn.Close();
            }
            
        }

    }
}
