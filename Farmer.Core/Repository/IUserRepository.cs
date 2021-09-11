using Farmer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Repository
{
   public interface IUserRepository
    {
        List<Users> GetAll();
        List<Users> GetAllFarmers();
        List<Users> GetAllTraders();


      public  Users GetById(int id);
        public int Create(Users Data);
      public  int Update(Users Data);

        public int Delete(int id);
        //Task<bool> CheckUserValidity(UsersLoginDTO customer);
    }
}
