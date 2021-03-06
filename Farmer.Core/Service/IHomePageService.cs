using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface IHomePageService
    {
        List<HomePage> GetAll();
        HomePage GetById(int id);
        HomePage Create(HomePage homePage);
        HomePage Update(HomePage homePage);
        HomePage Delete(int id);
    }
}
