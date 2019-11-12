using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAPPER_QLTV.Models
{
    public class TaoPhieuMuon
    {
        [Display(Name ="Mã Phiếu Mượn")]
        public string MaPhieuMuon { get; set; }
        [Display(Name = "ID Tài Khoản")]
        public int IDTaiKhoan { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ngày Mượn")]
        public DateTime NgayMuon { get; set; }
        [Display(Name = "Ngày Trả")]
        [DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }
        [Display(Name = "ID Nhân Viên")]
        public int IDNhanVien { get; set; }
    }
}
