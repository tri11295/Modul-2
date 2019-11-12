using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PhongBanRepository : BaseRepository, IPhongBanRepository
    {
        public bool CreatePhongBan(TaoPhongBan phongban)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaPB", phongban.MaPB);
                parameters.Add("@TenPB", phongban.TenPB);                                
                SqlMapper.Execute(con, "CreatePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePhongBan(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            SqlMapper.Execute(con, "DeletePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }      

        public IList<PhongBan> GetAllPhongBan()
        {
            IList<PhongBan> DanhSachPhongBan = SqlMapper.Query<PhongBan>(con, "GetAllPhongBan", commandType: CommandType.StoredProcedure).ToList();
            return DanhSachPhongBan;
        }

        public PhongBan GetPhongBanById(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                return SqlMapper.Query<PhongBan>((SqlConnection)con, "GetPhongBanByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }      

        public bool UpdatePhongBan(SuaPhongBan phongban)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", phongban.ID);
                parameters.Add("@MaPB", phongban.MaPB);
                parameters.Add("@TenPB", phongban.TenPB);                               
                SqlMapper.Execute(con, "UpdatePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
