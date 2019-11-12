using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.NhanVien.Request
{
    public class SuaNhanVien
    {
        public int MaNV { get; set; }
        public int IDPB { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
    }
}
