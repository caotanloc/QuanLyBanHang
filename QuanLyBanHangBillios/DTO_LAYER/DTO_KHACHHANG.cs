using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_LAYER
{
    public class DTO_KHACHHANG
    {
        private string dienThoai;
    
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string email_NhanVien;

        public string DIENTHOAI
        {
            get
            {
                return dienThoai;
            }
            set
            {
                dienThoai = value;
            }
        }

        
        

        public string TENKHACH
        {
            get
            {
                return tenKhach;
            }
            set
            {
                tenKhach = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }

        public string PHAI
        {
            get
            {
                return phai;
            }
            set
            {
                phai = value;
            }
        }

        public string EMAIL_NHANVIEN
        {
            get
            {
                return email_NhanVien;
            }
            set
            {
                email_NhanVien = value;
            }
        }

        public DTO_KHACHHANG() { }
        public DTO_KHACHHANG(string DienThoai, string TenKhach, string DiaChi, string Phai, string Email)
        {
            this.DIENTHOAI = DienThoai;
            this.TENKHACH = TenKhach;
            this.DIACHI = DiaChi;
            this.PHAI = Phai;
            this.EMAIL_NHANVIEN = Email;
        }
        public DTO_KHACHHANG(string dienThoai)
        {

        }

        public DTO_KHACHHANG(string DienThoai, string tenKhach, string diaChi, string Phai)
        {

        }
    }
}
