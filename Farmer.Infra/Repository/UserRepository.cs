﻿using Dapper;
using Farmer.Core;
using Farmer.Core.Common;
using Farmer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Farmer.Infra.Repository
{
  public  class UserRepository:IUserRepository
    {
        private readonly IDBContext DBContext;
        public UserRepository(IDBContext dBContext)
        {
            DBContext = dBContext;
        }

    
        public List<Users> GetAll()
        {
            IEnumerable<Users> result = DBContext.Connection.Query<Users>("GetAllUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int Create(Users Data)
        {
            var p = new DynamicParameters();
            p.Add("UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Age", Data.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("RoleId", Data.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DBContext.Connection.ExecuteAsync("CreateUser", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Update(Users Data)
        {
            var p = new DynamicParameters();
            p.Add("UserId", Data.UserID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserName", Data.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email", Data.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", Data.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Gender", Data.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LocationId", Data.LocationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Age", Data.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("RoleId", Data.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("UpdateUsers", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public int Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DBContext.Connection.ExecuteAsync("DeleteUsers", p, commandType: CommandType.StoredProcedure);
            return 1;

        }

        //public List<Course> Search(CourseDTO courseDTO)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@CourseName", courseDTO.CourseName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    p.Add("@CategoryName", courseDTO.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    p.Add("@DateFrom", courseDTO.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
        //    p.Add("@DateTo", courseDTO.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
        //    IEnumerable<Course> result = DBContext.Connection.Query<Course>("SearchCourse", p, commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}
    }
}
