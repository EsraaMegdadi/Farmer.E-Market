﻿using Dapper;
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
    public class CartRepository:ICartRepository
    {
        private readonly IDBContext DBcontext;
        public CartRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Cart> GetAll()
        {
            IEnumerable<Cart> result = DBcontext.Connection.Query<Cart>("GetAllCarts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public int Create(Cart Data)
        {
            var par = new DynamicParameters();
            // par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ProuductId", Data.ProuductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Quantity", Data.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("CreateCarts", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Cart Data)
        {
            var par = new DynamicParameters();
            par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ProuductId", Data.ProuductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Quantity", Data.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("UpdateCarts", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@CartId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("DeleteCart", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
