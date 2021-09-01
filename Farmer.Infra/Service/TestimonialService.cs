using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
   public class TestimonialService: ITestimonialService
    {
        private readonly ITestimonialRepository testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }
        public List<Testimonial> GetAll()
        {
            return testimonialRepository.GetAll();
        }
        public Testimonial getbyid(int TestimonialID)
        {
            testimonialRepository.Getbyid(TestimonialID);
            return new Testimonial();
        }
        public Testimonial Create(Testimonial testimonial)
        {
            testimonialRepository.Create(testimonial);
            return new Testimonial();
        }
        public Testimonial Update(Testimonial testimonial)
        {
            testimonialRepository.Update(testimonial);
            return new Testimonial();
        }
        public Testimonial Delete(int id)
        {
            testimonialRepository.Delete(id);
            return new Testimonial();
        }

    }
}
