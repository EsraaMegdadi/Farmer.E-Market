using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
 public interface IUserService
    {
        List<Users> GetAll();
        Users Create(Users users);
        Users Update(Users users);
        Users Delete(int id);
    }
}
