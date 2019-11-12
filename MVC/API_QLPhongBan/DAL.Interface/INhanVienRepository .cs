using Domain;
using Domain.NhanVien.Reponse;
using Domain.NhanVien.Request;
using System;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface INhanVienRepository
    {
        bool CreateNhanVien(TaoNhanVien TaoNhanVien);
        bool UpdateNhanVien(SuaNhanVien SuaNhanVien);
        bool DeleteNhanVien(int ID);
        IList<NhanVien> GetAllNhanVien();
        IList<NhanVien> GetAllNhanVienByPBID(int PBID);
        NhanVien GetNhanVienById(int ID);
    }
}
