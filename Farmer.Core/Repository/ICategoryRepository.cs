using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        int Create(Category Data);
        int Update(Category Data);
        int Delete(int Id);

    }
}
