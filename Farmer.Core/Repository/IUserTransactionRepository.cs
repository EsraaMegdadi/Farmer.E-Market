﻿using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
    public interface IUserTransactionRepository
    {
        List<UserTransaction> GetAll();
        int Create(UserTransaction Data);
        int Update(UserTransaction Data);
        int Delete(int Id);
    }
}
