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
   public  class HomePageRepository : IHomePageRepository
    {
        private readonly IDBContext DBContext;
        public HomePageRepository(IDBContext dBContext)
        {
            DBContext = dBContext;

        }
        public List<HomePage> GetAll()
        {
            IEnumerable<HomePage> result = DBContext.Connection.Query<HomePage>("GetAllHomePage", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public int Create(HomePage Data)
        {
            var p = new DynamicParameters();
            p.Add("logo", Data.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Background", Data.Background, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AboutUsId", Data.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TestimonialId", Data.TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ReviewId", Data.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            

            var result = DBContext.Connection.ExecuteAsync("CreateHomePage", p, commandType: CommandType.StoredProcedure);
            return 1;

        }

      
     

        public int Update(HomePage Data)
        {
            var p = new DynamicParameters();
            p.Add("HomePageId", Data.HomePageId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("logo", Data.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Background", Data.Background, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AboutUsId", Data.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TestimonialId", Data.TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ReviewId", Data.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("UpdateHomePage", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@HomePageId", id , dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("DeleteHomePage", p, commandType: CommandType.StoredProcedure);
            return 1;

        }

    }
}
