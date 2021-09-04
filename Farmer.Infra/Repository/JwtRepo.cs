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
   public class JwtRepo: Ijwtrepo
    {
        private readonly IDBContext DBContext;
        public JwtRepo(IDBContext dBContext)
        {
            this.DBContext = dBContext;
        }

      

        public login login1(login login)
        {
            var p = new DynamicParameters();
            p.Add("@username", login.username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", login.password, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<login> result = DBContext.connection.Query<login>("login1", p, commandType: CommandType.StoredProcedure);

            return result.SingleOrDefault();
        }
    }
}
