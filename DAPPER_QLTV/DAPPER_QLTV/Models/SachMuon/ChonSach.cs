using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAPPER_QLTV.Models.ChonSach
{
    public class ChonSach
    {
        public int ID { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string TheLoai { get; set; }
        public string SoluongMuon { get; set; }
        public string MaSach { get; set; }
    }
}
