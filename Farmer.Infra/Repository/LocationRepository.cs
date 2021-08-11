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
   public class LocationRepository :ILocationRepository
    {
        private readonly IDBContext DBContext;
        public LocationRepository(IDBContext dBContext)
        {
            DBContext = dBContext;
        }


        public List<Location> GetAll()
        {
            IEnumerable<Location> result = DBContext.Connection.Query<Location>("GetAllLocation", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int Create(Location Data)
        {
            var p = new DynamicParameters();
            p.Add("City", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
           

            var result = DBContext.Connection.ExecuteAsync("CreateLocation", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Location Data)
        {
            var p = new DynamicParameters();
            p.Add("LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("City", Data.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Country", Data.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Street", Data.Street, dbType: DbType.String, direction: ParameterDirection.Input);
          
           
            var result = DBContext.Connection.ExecuteAsync("UpdateLocation", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@LocationId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("DeleteLocation", p, commandType: CommandType.StoredProcedure);
            return 1;

        }

    }
}
