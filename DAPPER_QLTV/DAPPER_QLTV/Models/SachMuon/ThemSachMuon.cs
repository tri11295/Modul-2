using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAPPER_QLTV.Models.SachMuon
{
    public class ThemSachMuon
    {
        public int ID { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int IDTheLoai { get; set; }
        public int SoLuongHienCo { get; set; }
        public string GioiThieu { get; set; }
        public int SoTrang { get; set; }
        public string TenTacGia { get; set; }
        public int IDNXB { get; set; }
        public string Anh { get; set; }
        public bool TinhTrang { get; set; }
    }
}
