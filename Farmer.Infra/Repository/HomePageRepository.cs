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
            IEnumerable<HomePage> result = DBContext.connection.Query<HomePage>("GetAllHomePage", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public HomePage Getbyid(int HomePageId)
        {
            var P = new DynamicParameters();
            P.Add("HomePageId", HomePageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.Query<HomePage>("GetByIdHomePage", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public int Create(HomePage Data)
        {
            var p = new DynamicParameters();
            p.Add("logo", Data.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Background", Data.Background, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AboutUsId", Data.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TestimonialId", Data.TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ReviewId", Data.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            

            var result = DBContext.connection.ExecuteAsync("CreateHomePage", p, commandType: CommandType.StoredProcedure);
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

            var result = DBContext.connection.ExecuteAsync("UpdateHomePage", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@HomePageId", id , dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.ExecuteAsync("DeleteHomePage", p, commandType: CommandType.StoredProcedure);
            return 1;

        }

    }
}
