using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class PhongBanService : IPhongBanService
    {
        IPhongBanRepository _PhongBanRepository;
        public PhongBanService(IPhongBanRepository phongBanRepository)
        {
            _PhongBanRepository = phongBanRepository;
        }
        public bool CreatePhongBan(TaoPhongBan phongban)
        {
            return _PhongBanRepository.CreatePhongBan(phongban);
        }

        public bool DeletePhongBan(int ID)
        {
            return _PhongBanRepository.DeletePhongBan(ID);
        }

        public IList<PhongBan> GetAllPhongBan()
        {
            return _PhongBanRepository.GetAllPhongBan();
        }

        public PhongBan GetPhongBanById(int ID)
        {
            return _PhongBanRepository.GetPhongBanById(ID);
        }

        public bool UpdatePhongBan(SuaPhongBan phongban)
        {
            return _PhongBanRepository.UpdatePhongBan(phongban);
        }
    }
}
