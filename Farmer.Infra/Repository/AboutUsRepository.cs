using Dapper;
using Farmer.Core.Common;
using Farmer.Core.Data;
using Farmer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Farmer.Infra.Repository
{
   public class AboutUsRepository:IAboutUsRepository
    {
        private readonly IDBContext DBContext;
        public AboutUsRepository(IDBContext dBContext)
        {
            DBContext = dBContext;
        }


        public List<AboutUs> GetAll()
        {
            IEnumerable<AboutUs> result = DBContext.connection.Query<AboutUs>("GetAllAboutUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public AboutUs Getbyid(int AboutUsId)
        {
            var P = new DynamicParameters();
            P.Add("AboutUsId", AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.Query<AboutUs>("GetByIdAboutUs", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(AboutUs Data)
        {
            var p = new DynamicParameters();
            p.Add("Description", Data.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DBContext.connection.ExecuteAsync("CreateAboutUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }
        public int Update(AboutUs Data)
        {
            var p = new DynamicParameters();
            p.Add("AboutUsId", Data.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Description", Data.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DBContext.connection.ExecuteAsync("UpdateAboutUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("AboutUsId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.ExecuteAsync("DeleteAboutUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }

       
    }
}
