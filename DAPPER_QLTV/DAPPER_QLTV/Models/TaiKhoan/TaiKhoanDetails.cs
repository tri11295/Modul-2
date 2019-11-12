using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAPPER_QLTV.Models.TaiKhoan
{
    public class TaiKhoanDetails
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public int IDSinhVien { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public bool GioiTinh { get; set; }
        public string gioitinh => GioiTinh ? "Nam" : "Nữ";
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int SoLanViPham { get; set; }
    }
}
