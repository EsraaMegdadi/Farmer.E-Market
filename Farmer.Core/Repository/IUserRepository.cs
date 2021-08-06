using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IUserRepository
    {
        List<Users> GetAll();
       int Create(Users Data);
        int Update(Users Data);

        int Delete(int id);
    }
}
