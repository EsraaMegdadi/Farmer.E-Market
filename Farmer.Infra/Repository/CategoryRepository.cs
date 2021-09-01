using Dapper;
using Farmer.Core.Common;
using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IEnumerable<Category> result = DBcontext.connection.Query<Category>("GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Category Getbyid(int CategoryId)
        {
            var P = new DynamicParameters();
            P.Add("CategoryId", CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Category>("GetByIdCategory", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(Category Data)
        {
            var p = new DynamicParameters();
            //p.Add("@CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryName", Data.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("CreateCategory", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Category Data)
        {
            var p = new DynamicParameters();
            p.Add("CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryName", Data.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("UpdateCategory", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var P = new DynamicParameters();
            P.Add("CategoryID", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("DeleteCategory", P, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public async Task<List<Category>> GetAllCategoryProducts()
        {
            var p = new DynamicParameters();
            var result = await DBcontext.connection.QueryAsync<Category, Products, Category>
            ("GetAllCategoryProducts", (category, product) =>
            {
                category.products = category.products ?? new List<Products>();
                category.products.Add(product);
                return category;
            }, splitOn: "ProductID"
            , param: null
            , commandType: CommandType.StoredProcedure
            );
            var finalResult = result.AsList<Category>().GroupBy(p => p.CategoryID).Select(
            g =>
            {
                Category category = g.First();
                category.products = g.Where(g => g.products.Any() && g.products.Count > 0).Select(
    p => p.products.Single()).GroupBy(product => product.ProductID).Select(product => new Products
    {
        ProductID = product.First().ProductID,
        ProductName = product.First().ProductName

    }
    ).ToList();
                return category;

            }

            ).ToList();
            return finalResult;
        }



    }
}

