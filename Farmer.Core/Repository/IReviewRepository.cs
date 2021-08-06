﻿using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IReviewRepository
    {
        List<Review> GetAll();
        int Create(Review Data);
        int Update(Review Data);
        int Delete(int id);
    }
}