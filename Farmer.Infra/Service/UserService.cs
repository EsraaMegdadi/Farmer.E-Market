using Farmer.Core;
using Farmer.Core.DTO;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        public List<Users> GetAllFarmers()
        {
            return UserRepository.GetAllFarmers();
        }
        public List<Users> GetAllTraders()
        {
            return UserRepository.GetAllTraders();
        }
        public Users GetById(int id)
        {
            return UserRepository.GetById(id);
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
        //public async Task<bool> CheckUserValidity(UsersLoginDTO customer)
        //{
        //    return await UserRepository.CheckUserValidity(customer);
        //}
    }
}
