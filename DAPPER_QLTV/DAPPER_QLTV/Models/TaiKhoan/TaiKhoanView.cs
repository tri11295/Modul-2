using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAPPER_QLTV.Models.TaiKhoan
{
    public class TaiKhoanView
    {
        public int ID { get; set; }

        [Display(Name = "Tên Đăng Nhập")]
        public string TenDangNhap { get; set; }

        [Display(Name = "ID Sinh Viên")]
        public int IDSinhVien { get; set; }
      
    }
}
