using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
   public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository AboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            AboutUsRepository = aboutUsRepository;

        }
        public List<AboutUs> GetAll()
        {
            return AboutUsRepository.GetAll();
        }

        public AboutUs Create(AboutUs aboutUs)
        {
            AboutUsRepository.Create(aboutUs);
            return new AboutUs();
        }

        public AboutUs Update(AboutUs aboutUs)
        {
            AboutUsRepository.Update(aboutUs);
            return new AboutUs();
        }

        public AboutUs Delete(int id)
        {
            AboutUsRepository.Delete(id);
            return new AboutUs();
        }
    }
}

