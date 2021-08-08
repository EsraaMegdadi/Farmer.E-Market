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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDBContext DBcontext;
        public CategoryRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Category> GetAll()
        {
            IEnumerable<Category> result = DBcontext.Connection.Query<Category>("GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public int Create(Category Data)
        {
            var p = new DynamicParameters();
            //p.Add("@CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryName", Data.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("CreateCategory", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Category Data)
        {
            var p = new DynamicParameters();
            p.Add("CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryName", Data.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("UpdateCategory", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var P = new DynamicParameters();
            P.Add("CategoryID", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("DeleteCategory", P, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
