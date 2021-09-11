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
  public  class ReviewRepository: IReviewRepository
    {
        private readonly IDBContext DBcontext;
        public ReviewRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Review> GetAll()
        {
            IEnumerable<Review> result = DBcontext.connection.Query<Review>("GetAllReview", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Review GetById(int id)
        {
            var P = new DynamicParameters();
            P.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Review>("GetByIdReview", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(Review Data)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptiontext", Data.Descriptiontext, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Rate", Data.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("CreateReview", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Review Data)
        {
            var p = new DynamicParameters();
            p.Add("@ReviewID", Data.ReviewID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptiontext", Data.Descriptiontext, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Rate", Data.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("UpdateReview", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var P = new DynamicParameters();
            P.Add("@ReviewID", Id, DbType.Int32, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("DeleteReview", P, commandType: CommandType.StoredProcedure);
            return 1;
        }

    }
}
