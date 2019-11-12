using DAL.Interface;
using Dapper;
using Domain;
using Domain.NhanVien.Reponse;
using Domain.NhanVien.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class NhanVienRepository : BaseRepository, INhanVienRepository
    {
        public bool CreateNhanVien(TaoNhanVien TaoNhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();                
                parameters.Add("@IDPB",TaoNhanVien.IDPB);
                parameters.Add("@HoTen", TaoNhanVien.HoTen);
                parameters.Add("@SoDienThoai", TaoNhanVien.SoDienTHoai);
                SqlMapper.Execute(con, "CreateNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteNhanVien(int MaNV)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaNV", MaNV);
            SqlMapper.Execute(con, "DeleteNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }      

        public IList<NhanVien> GetAllNhanVien()
        {
            IList<NhanVien> DanhSachNhanVien = SqlMapper.Query<NhanVien>(con, "GetAllNhanVien", commandType: CommandType.StoredProcedure).ToList();
            return DanhSachNhanVien;
        }

        public IList<NhanVien> GetAllNhanVienByPBID(int PBID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PBID", PBID);
            IList<NhanVien> DanhSachNhanVien = SqlMapper.Query<NhanVien>(con, "GetAllNhanVienByPBID", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            return DanhSachNhanVien;

        }

        public NhanVien GetNhanVienById(int MaNV)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", MaNV);
                return SqlMapper.Query<NhanVien>((SqlConnection)con, "GetNhanVienByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }      

        public bool UpdateNhanVien(SuaNhanVien SuaNhanVien)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNV", SuaNhanVien.MaNV);
                parameters.Add("@IDPB", SuaNhanVien.IDPB);
                parameters.Add("@HoTen",SuaNhanVien.HoTen);
                parameters.Add("@SoDienThoai", SuaNhanVien.SoDienThoai);
                SqlMapper.Execute(con, "UpdateNhanVien", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
