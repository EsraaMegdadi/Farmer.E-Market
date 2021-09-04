using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IAboutUsRepository
    {
        List<AboutUs> GetAll();
        AboutUs Getbyid(int AboutUsId);
        int Create(AboutUs Data);
        int Update(AboutUs Data);
        int Delete(int id);
    }
}
