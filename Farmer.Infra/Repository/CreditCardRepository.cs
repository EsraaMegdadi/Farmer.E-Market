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
  public class CreditCardRepository:ICreditCardRepository
    {
        private readonly IDBContext DBcontext;
        public CreditCardRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<CreditCard> GetAll()
        {
            IEnumerable<CreditCard> result = DBcontext.Connection.Query<CreditCard>("GetAllCreditCard", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public int Create(CreditCard Data)
        {
            var par = new DynamicParameters();
            // par.Add("@CreditCardId", Data.CreditCardId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CreditCardNumber", Data.CreditCardNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CVC", Data.CVC, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ExpMonth", Data.ExpMonth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            par.Add("@ExpYear", Data.ExpYear, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("CreateCreditCard", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(CreditCard Data)
        {
            var par = new DynamicParameters();
            par.Add("@CreditCardId", Data.CreditCardId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CreditCardNumber", Data.CreditCardNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@CVC", Data.CVC, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@ExpMonth", Data.ExpMonth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            par.Add("@ExpYear", Data.ExpYear, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("UpdateCreditCard", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@CreditCardId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("DeleteCreditCard", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
