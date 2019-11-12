using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IPhongBanService
    {
        bool CreatePhongBan(TaoPhongBan phongban);
        bool UpdatePhongBan(SuaPhongBan phongban);
        bool DeletePhongBan(int ID);
        IList<PhongBan> GetAllPhongBan();
        PhongBan GetPhongBanById(int ID);
    }
}
