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
    public class ContactInboxRepository:IContactInboxRepository
    {
        private readonly IDBContext DBcontext;
        public ContactInboxRepository(IDBContext dBContext)
        {
            this.DBcontext = dBContext;
        }
        public List<ContactInbox> GetAll()
        {
            IEnumerable<ContactInbox> result = DBcontext.Connection.Query<ContactInbox>("GetAllContactInbox", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public int Create(ContactInbox Data)
        {
            var par = new DynamicParameters();
           
            par.Add("@FullName", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            par.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            par.Add("@Message", Data.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            
            var Result = DBcontext.Connection.ExecuteAsync("CreateContactInbox", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(ContactInbox Data)
        {
            var par = new DynamicParameters();
            par.Add("@InboxId", Data.InboxId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            par.Add("@FullName", Data.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            par.Add("@Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            par.Add("@Message", Data.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = DBcontext.Connection.ExecuteAsync("UpdateContactInbox", par, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int Id)
        {
            var Par = new DynamicParameters();
            Par.Add("@InboxId", Id, DbType.Int32, direction: ParameterDirection.Input);
            var Result = DBcontext.Connection.ExecuteAsync("DeleteContactInbox", Par, commandType: CommandType.StoredProcedure);
            return 1;
        }

    }
}
