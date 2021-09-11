using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IHomePageRepository
    {
        List<HomePage> GetAll();
        HomePage GetById(int id);
        int Create(HomePage Data);
        int Update(HomePage Data);

        int Delete(int id);
    }
}
