using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface IUserTransactionService
    {
        List<UserTransaction> GetAll();
        UserTransaction GetById(int id);
        UserTransaction Create(UserTransaction Data);
        UserTransaction Update(UserTransaction Data);
        UserTransaction Delete(int Id);
    }
}
