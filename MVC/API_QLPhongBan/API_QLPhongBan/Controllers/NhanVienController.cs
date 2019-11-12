using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain.NhanVien.Reponse;
using Domain.NhanVien.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_QLPhongBan.Controllers
{
  
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        INhanVienService _NhanVienService;
        public NhanVienController(INhanVienService NhanVienService)
        {
            _NhanVienService = NhanVienService;
        }
        // GET api/values
        [HttpGet]
        [Route("api/nhanvien/getall")]
        public IList<NhanVien> GetAllNV()
        {
            return _NhanVienService.GetAllNhanVien();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PBID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/nhanvien/getnvbypbid/{PBID}")]
        public IList<NhanVien> GetNVByPBID(int PBID)
        {
            return _NhanVienService.GetAllNhanVienByPBID(PBID);
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/nhanvien/get/{MaNV}")]
        public NhanVien GetNVByID(int MaNV)
        {
            return _NhanVienService.GetNhanVienById(MaNV);
        }

        // POST api/values
        [HttpPost]
        [Route("api/nhanvien/create")]
        public bool CreateNV([FromBody] TaoNhanVien TaoNhanVien)
        {
            return _NhanVienService.CreateNhanVien(TaoNhanVien);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/nhanvien/update")]
        public bool UpdateNV([FromBody] SuaNhanVien SuaNhanVien)
        {
            return _NhanVienService.UpdateNhanVien(SuaNhanVien);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/nhanvien/delete/{MaNV}")]
        public bool DeleteNV(int MaNV)
        {
            return _NhanVienService.DeleteNhanVien(MaNV);
        }
    }
}