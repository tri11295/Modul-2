using Domain;
using Domain.NhanVien.Reponse;
using Domain.NhanVien.Request;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface INhanVienService
    {
        bool CreateNhanVien(TaoNhanVien TaoNhanVien);
        bool UpdateNhanVien(SuaNhanVien SuaNhanVien);
        bool DeleteNhanVien(int ID);
        IList<NhanVien> GetAllNhanVien();
        IList<NhanVien> GetAllNhanVienByPBID(int PBID);
        NhanVien GetNhanVienById(int ID);
    }
}
