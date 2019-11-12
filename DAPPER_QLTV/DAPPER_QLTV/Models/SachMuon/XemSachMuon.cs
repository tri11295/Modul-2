using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAPPER_QLTV.Models.SachMuon
{
    public class XemSachMuon
    {
        public int ID { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string TheLoai { get; set; }
        public int SoLuongMuon { get; set; }
        public string MaPhieuMuon { get; set; }
        public int IDTaiKhoan { get; set; }

    }
}
