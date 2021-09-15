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

namespace Farmer.Infra.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly IDBContext DBcontext;
        public CartRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Cart> GetAll()
        {
            IEnumerable<Cart> result = DBcontext.connection.Query<Cart>("GetAllCarts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Cart GetById(int id)
        {
            var P = new DynamicParameters();
            P.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Cart>("GetByIdCart", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }


        public int Create(Cart Data)
        {
            var par = new DynamicParameters();
            // par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ProuductId", Data.ProuductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Quantity", Data.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("CreateCarts", par, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public int order1(Cart Data)
        {
            var par = new DynamicParameters();
            // par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@username", Data.username, dbType: DbType.String, direction: ParameterDirection.Input);
            par.Add("@ProuductId", Data.ProuductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Quantity", Data.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("OrderP", par, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public List<Cart> userCart(Cart Data)
        {
            var par = new DynamicParameters();
            // par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@username", Data.username, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Cart> result = DBcontext.connection.Query<Cart>("ConfirmPayment", par, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int Update(Cart Data)
        {
            var par = new DynamicParameters();
            par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ProuductId", Data.ProuductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Quantity", Data.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("UpdateCarts", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@CartId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("DeleteCarts", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Cart> payment()
        {
            IEnumerable<Cart> result = DBcontext.connection.Query<Cart>("GetAllCarts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
