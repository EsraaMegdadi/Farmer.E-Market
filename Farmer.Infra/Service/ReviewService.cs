using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
  public  class ReviewService: IReviewService
    {
        private readonly IReviewRepository reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }
        public List<Review> GetAll()
        {
            return reviewRepository.GetAll();
        }

        public Review GetById(int id)
        {
            return reviewRepository.GetById(id);
        }
        public Review Create(Review review)
        {
            reviewRepository.Create(review);
            return new Review();
        }
        public Review Update(Review review)
        {
            reviewRepository.Update(review);
            return new Review();
        }
        public Review Delete(int id)
        {
            reviewRepository.Delete(id);
            return new Review();
        }
    }
}
