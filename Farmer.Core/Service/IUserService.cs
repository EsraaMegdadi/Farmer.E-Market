﻿using Farmer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Service
{
 public interface IUserService
    {
        List<Users> GetAll();
        Users Create(Users users);
        Users Update(Users users);
        Users Delete(int id);
        Task<bool> CheckUserValidity(UsersLoginDTO customer);

    }
}
