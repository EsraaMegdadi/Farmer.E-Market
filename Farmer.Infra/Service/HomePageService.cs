using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class HomePageService : IHomePageService
    {
        private readonly IHomePageRepository HomePageRepository;

        public HomePageService(IHomePageRepository homePageRepository)
        {
            HomePageRepository = homePageRepository;

        }
        public List<HomePage> GetAll()
        {
            return HomePageRepository.GetAll();
        }
        public HomePage GetById(int id)
        {
            return HomePageRepository.GetById(id);
        }
        public HomePage Create(HomePage homePage)
        {
            HomePageRepository.Create(homePage);
            return new HomePage();
        }
        public HomePage Update(HomePage homePage)
        {
            HomePageRepository.Update(homePage);
            return new HomePage();
        }

        public HomePage Delete(int id)
        {
            HomePageRepository.Delete(id);
            return new HomePage();
        }

        
      
    }
}
