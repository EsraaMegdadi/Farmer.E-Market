using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
  public  interface ITestimonialService
    {
        List<Testimonial> GetAll();
        Testimonial GetById(int id);
        Testimonial Create(Testimonial testimonial);
        Testimonial Update(Testimonial testimonial);
        Testimonial Delete(int id);
    }
}
