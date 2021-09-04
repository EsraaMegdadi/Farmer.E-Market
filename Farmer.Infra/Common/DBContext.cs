using Farmer.Core.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Farmer.Infra.Common
{
    public class DBContext : IDBContext
    {
        private DbConnection _connection;
        private readonly IConfiguration Configuration;

        public DBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbConnection connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(Configuration["ConnectionStrings:DBConnectionString"]);
                    _connection.Open();
                }
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();

                }
                return _connection;
            }
        }
    }
}
