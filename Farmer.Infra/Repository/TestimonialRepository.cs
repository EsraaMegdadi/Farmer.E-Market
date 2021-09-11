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
  public  class TestimonialRepository: ITestimonialRepository
    {
        private readonly IDBContext DBcontext;
        public TestimonialRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Testimonial> GetAll()
        {
            IEnumerable<Testimonial> result = DBcontext.connection.Query<Testimonial>("GetAllTestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Testimonial GetById(int id)
        {
            var P = new DynamicParameters();
            P.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Testimonial>("GetByIdTestimonial", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(Testimonial Data)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptiontext", Data.Descriptiontext, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("CreateTestimonial", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Testimonial Data)
        {
            var p = new DynamicParameters();
            p.Add("@TestimonialID", Data.TestimonialID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Descriptiontext", Data.Descriptiontext, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@img", Data.img, dbType: DbType.String, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("UpdateTestimonial", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var P = new DynamicParameters();
            P.Add("@TestimonialID", Id, DbType.Int32, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("DeleteTestimonial", P, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
