using Dapper;
using Farmer.Core.Common;
using Farmer.Core.Data;
using Farmer.Core.DTO;
using Farmer.Core.Repository;
using Farmer.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Farmer.Infra.Repository
{
    public class ProductsRepository : IProductsRepository
    {

        private readonly IDBContext DBcontext;
        public ProductsRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Products> GetAll()
        {
            IEnumerable<Products> result = DBcontext.connection.Query<Products>("GetAllProduct", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Products GetById(int id)
        {
            var P = new DynamicParameters();
            P.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Products>("GetByIdProduct", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(Products Data)
        {
            var p = new DynamicParameters();
            p.Add("ProductName", Data.ProductName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProductPrice", Data.ProductPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("ProductImg", Data.ProductImg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProductQuantity", Data.ProductQuantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserID", Data.UserID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("CreateProduct", p, commandType: CommandType.StoredProcedure);
            return 1;
        }





        public int Update(Products Data)
        {
            var p = new DynamicParameters();
            p.Add("ProductID", Data.ProductID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ProductName", Data.ProductName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProductPrice", Data.ProductPrice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("ProductImg", Data.ProductImg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProductQuantity", Data.ProductQuantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CategoryID", Data.CategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserID", Data.UserID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("UpdateProduct", p, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public int Delete(int Id)
        {
            var P = new DynamicParameters();
            P.Add("ProductID", Id, DbType.Int32, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("DeleteProduct", P, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public List<Products> Search(ProductsDTO productsDTO)
        {
            var p = new DynamicParameters();
            p.Add("ProductName", productsDTO.ProductName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CategoryName", productsDTO.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Products> result = DBcontext.connection.Query<Products>("SearchProducts", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<Products> GetAllProductSoldOut()
        {
            IEnumerable<Products> result = DBcontext.connection.Query<Products>("GetProductSoldOut", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
    }

 }
