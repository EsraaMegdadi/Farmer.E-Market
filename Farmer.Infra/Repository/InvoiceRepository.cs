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
   public class InvoiceRepository:IInvoiceRepository
    {
        private readonly IDBContext DBcontext;
        public InvoiceRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<Invoice> GetAll()
        {
            IEnumerable<Invoice> result = DBcontext.connection.Query<Invoice>("GetAllInvoice", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Invoice Getbyid(int InvoiceId)
        {
            var P = new DynamicParameters();
            P.Add("InvoiceId", InvoiceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBcontext.connection.Query<Invoice>("GetByIdInvoice", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public int Create(Invoice Data)
        {
            var par = new DynamicParameters();
            // par.Add("@InvoiceId", Data.InvoiceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@InvoiceNumber", Data.InvoiceNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@InvoiceDate", Data.InvoiceDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@TotalInvoice", Data.TotalInvoice, dbType: DbType.Double, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("CreateInvoice", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Invoice Data)
        {
            var par = new DynamicParameters();
            par.Add("@InvoiceId", Data.InvoiceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@InvoiceNumber", Data.InvoiceNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@InvoiceDate", Data.InvoiceDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            par.Add("@UserId", Data.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@TotalInvoice", Data.TotalInvoice, dbType: DbType.Double, direction: ParameterDirection.Input);

            var Result = DBcontext.connection.ExecuteAsync("UpdateInvoice", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@InvoiceId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.connection.ExecuteAsync("DeleteInvoice", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }
    }
}
