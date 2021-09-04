﻿using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
  public  interface ITestimonialRepository
    {
        List<Testimonial> GetAll();
        Testimonial Getbyid(int TestimonialID);
        int Create(Testimonial Data);
        int Update(Testimonial Data);
        int Delete(int id);
    }
}
