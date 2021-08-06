using Farmer.Core;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
  public  class UserService :IUserService
    {
        private readonly IUserRepository UserRepository;
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;

        }
        public List<Users> GetAll()
        {
            return UserRepository.GetAll();
        }

        public Users Create(Users users)
        {
            UserRepository.Create(users);
            return new Users();
        }

        public Users Update(Users users)
        {
            UserRepository.Update(users);
            return new Users();
        }

        public Users Delete(int id)
        {
            UserRepository.Delete(id);
            return new Users();
        }
    }
}
