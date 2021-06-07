using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAYER;
using DAL_LAYER;
using System.Data;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;

namespace BUS_LAYER
{
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN dalNhanVien = new DAL_NHANVIEN();
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        //Dang nhap
        public bool NhanVienDangNhap(DTO_NhanVien nv)   
        {
            return dalNhanVien.DangNhapHeThong(nv);

        }
        //them nhan vien
        public bool ThemNhanVien(string email, string hoTen, string diaChi, int vaiTro, int tinhTrang)
        {
            return dalNhanVien.themNhanVien(email,hoTen,diaChi,vaiTro,tinhTrang);
        }

        //doi mat khau
        public bool DoiMatKhau(string email, string opass, string npass)
        {
            return dalNhanVien.DoiMatKhau(email, opass, npass);
        }

        // quen mat khau
        public bool QuenMatKhau(string email)
        {
            return dalNhanVien.QuenMatKhau(email);
        }

        //ma hoa md5
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        //tao mat khau moi
        public bool TaoMatKhauMoi(DTO_NhanVien nv)
        {
            return dalNhanVien.TaoMatKhauMoi(nv);
        }

        //Gui mail
        public void SendMail(string email, string matKhau)
        {
            
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("tanloccao456@gmail.com", "Loc123456789");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("tanloccao456@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là: " + matKhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
           

        }
        //Tao Chuoi Ngau Nhien
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);

            }
            if (lowerCase) return builder.ToString().ToLower();
            return builder.ToString();
        }
        //Tao So Ngau Nhien
        public int RanDomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //Xoa nhan vien
        public bool XoaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.XoaNhanVien(nv);
        }

        //Cap nhat nhan vien
        public bool CapNhatNhanVien(string Email,string TenNV, string DiaChi, int VaiTro, int TinhTrang)
        {
            return dalNhanVien.UpdateInfoNhanVien(Email, TenNV, DiaChi, VaiTro, TinhTrang);
        }

        //Tim Kiem Nhan Vien
        public DataTable SearchNhanVien(string hoTen)
        {
            return dalNhanVien.SearchNhanVien(hoTen);
        }

        //LayVaiTro
        public DataTable LayVaiTro(string email)
        {
            return dalNhanVien.LayVaiTroNhanVien(email);
        }

    }
}
