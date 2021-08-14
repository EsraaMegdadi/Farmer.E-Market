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
       int Create(Users Data);
        int Update(Users Data);

        int Delete(int id);
        Task<bool> CheckUserValidity(UsersLoginDTO customer);
    }
}
