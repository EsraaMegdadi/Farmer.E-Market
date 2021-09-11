using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
  public  interface IReviewService
    {
        List<Review> GetAll();
        Review GetById(int id);
        Review Create(Review review);
        Review Update(Review review);
        Review Delete(int id);
    }
}
