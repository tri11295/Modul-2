using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAPPER_QLTV.Models.TaiKhoan
{
    public class TaiKhoanSachMuon
    {       
        
        public int IDSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongMuon { get; set; }
        public string MaPhieuMuon { get; set; }       
        [DataType(DataType.Date)]
        public DateTime NgayMuon { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }
        [Display(Name ="IDPhieuMuon")]
        public int ID { get; set; }

    }
}
