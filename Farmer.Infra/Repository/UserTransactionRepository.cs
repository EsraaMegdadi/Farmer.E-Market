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
    public class UserTransactionRepository: IUserTransactionRepository
    {
        private readonly IDBContext DBcontext;
        public UserTransactionRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<UserTransaction> GetAll()
        {
            IEnumerable<UserTransaction> result = DBcontext.Connection.Query<UserTransaction>("GetAllUserTransaction", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public int Create(UserTransaction Data)
        {
            var par = new DynamicParameters();
            // par.Add("@TransactionsId", Data.TransactionsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            par.Add("@TransactionDate", Data.TransactionDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var Result = DBcontext.Connection.ExecuteAsync("CreateUserTransaction", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(UserTransaction Data)
        {
            var par = new DynamicParameters();
            par.Add("@TransactionsId", Data.TransactionsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CartId", Data.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@Amount", Data.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            par.Add("@TransactionDate", Data.TransactionDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("UpdateUserTransaction", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@TransactionsId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("DeleteUserTransaction", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
