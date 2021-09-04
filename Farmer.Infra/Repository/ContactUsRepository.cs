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
    public class ContactUsRepository:IContactUsRepository
    {
        private readonly IDBContext DBContext;
        public ContactUsRepository(IDBContext dBContext)
        {
            DBContext = dBContext;
        }


        public List<ContactUs> GetAll()
        {
            IEnumerable<ContactUs> result = DBContext.connection.Query<ContactUs>("GetAllContactUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public ContactUs Getbyid(int ContactUsId)
        {
            var P = new DynamicParameters();
            P.Add("ContactUsId", ContactUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.Query<ContactUs>("GetByIdContactUs", P, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public int Create(ContactUs Data)
        {
            var p = new DynamicParameters();
            p.Add("Paragraph1", Data.Paragraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Paragraph2", Data.Paragraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BackgroundImage", Data.BackgraoundImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PhoneNumber", Data.PhoneNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EmailAddress", Data.EmailAddress, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("HomePageId", Data.HomePageId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DBContext.connection.ExecuteAsync("CreateContactUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }
        public int Update(ContactUs Data)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsId", Data.ContactUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Paragraph1", Data.Paragraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Paragraph2", Data.Paragraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BackgroundImage", Data.BackgraoundImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PhoneNumber", Data.PhoneNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EmailAddress", Data.EmailAddress, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("HomePageId", Data.HomePageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.ExecuteAsync("UpdateContactUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("ContactUsId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.connection.ExecuteAsync("DeleteContactUs", p, commandType: CommandType.StoredProcedure);

            return 1;
        }

    }
}
