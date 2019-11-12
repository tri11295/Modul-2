using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=TRI;Initial Catalog=QLPhongBanNew;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
