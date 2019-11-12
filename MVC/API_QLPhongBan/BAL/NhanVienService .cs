using BAL.Interface;
using DAL.Interface;
using Domain;
using Domain.NhanVien.Reponse;
using Domain.NhanVien.Request;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class NhanVienService : INhanVienService
    {
        INhanVienRepository _NhanVienRepository;
        public NhanVienService(INhanVienRepository NhanVienRepository)
        {
            _NhanVienRepository = NhanVienRepository;
        }
        public bool CreateNhanVien(TaoNhanVien TaoNhanVien)
        {
            return _NhanVienRepository.CreateNhanVien(TaoNhanVien);
        }

        public bool DeleteNhanVien(int MaNV)
        {
            return _NhanVienRepository.DeleteNhanVien(MaNV);
        }

        public IList<NhanVien> GetAllNhanVien()
        {
            return _NhanVienRepository.GetAllNhanVien();
        }

        public IList<NhanVien> GetAllNhanVienByPBID(int PBID)
        {
            return _NhanVienRepository.GetAllNhanVienByPBID(PBID);
        }

        public NhanVien GetNhanVienById(int MaNV)
        {
            return _NhanVienRepository.GetNhanVienById(MaNV);
        }

        public bool UpdateNhanVien(SuaNhanVien SuaNhanVien)
        {
            return _NhanVienRepository.UpdateNhanVien(SuaNhanVien);
        }
    }
}
