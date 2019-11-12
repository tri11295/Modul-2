using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API_QLPhongBan.Controllers
{
    
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        IPhongBanService _PhongBanService;
        public PhongBanController(IPhongBanService PhongBanService)
        {
            _PhongBanService = PhongBanService;
        }
        // GET api/values
        [HttpGet]
        [Route("api/phongban/gets")]
        public IList<PhongBan> Gets()
        {
            return _PhongBanService.GetAllPhongBan();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/phongban/get/{id}")]
        public PhongBan Get(int ID)
        {
            return _PhongBanService.GetPhongBanById(ID);
        }

        // POST api/values
        [HttpPost]
        [Route("api/phongban/create")]
        public bool Create([FromBody] TaoPhongBan phongBan)
        {
            return _PhongBanService.CreatePhongBan(phongBan);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/phongban/update")]
        public bool Update([FromBody] SuaPhongBan phongban)
        {
            return _PhongBanService.UpdatePhongBan(phongban);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/phongban/delete/{id}")]
        public bool Delete(int ID)
        {
            return _PhongBanService.DeletePhongBan(ID);
        }
    }
}
