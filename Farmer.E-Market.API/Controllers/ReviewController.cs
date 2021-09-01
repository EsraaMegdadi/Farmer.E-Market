using Farmer.Core.Data;
using Farmer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmer.E_Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewService ReviewService;
        public ReviewController(IReviewService reviewService)
        {
            this.ReviewService = reviewService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Review> GetAll()
        {
            return ReviewService.GetAll();
        }

        [Route("{ReviewID}")]
        [HttpGet]
        public Review getbyid(int ReviewID)
        {
            return ReviewService.getbyid(ReviewID);
        }



        [HttpPost]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Review Create([FromBody] Review review)
        {
            return ReviewService.Create(review);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Review Update([FromBody] Review review)
        {
            return ReviewService.Update(review);
        }

        [HttpDelete("{id}")]
        public Review Delete(int id)
        {
            return ReviewService.Delete(id);
        }

    }
}
