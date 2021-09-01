using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
  public interface IAboutUsService
    {
        List<AboutUs> GetAll();
        AboutUs getbyid(int AboutUsId);
        AboutUs Create(AboutUs aboutUs);
        AboutUs Update(AboutUs aboutUs);
        AboutUs Delete(int id);


    }
}
