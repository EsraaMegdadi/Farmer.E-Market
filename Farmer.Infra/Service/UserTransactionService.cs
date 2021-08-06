using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class UserTransactionService:IUserTransactionService
    {
        private readonly IUserTransactionRepository UserTransactionRepository;
        public UserTransactionService(IUserTransactionRepository userTransactionRepository)
        {
            UserTransactionRepository = userTransactionRepository;

        }
        public List<UserTransaction> GetAll()
        {
            return UserTransactionRepository.GetAll();
        }

        public UserTransaction Create(UserTransaction userTransaction)
        {
            UserTransactionRepository.Create(userTransaction);
            return new UserTransaction();
        }

        public UserTransaction Update(UserTransaction userTransaction)
        {
            UserTransactionRepository.Update(userTransaction);
            return new UserTransaction();
        }

        public UserTransaction Delete(int id)
        {
            UserTransactionRepository.Delete(id);
            return new UserTransaction();
        }

    }
}
