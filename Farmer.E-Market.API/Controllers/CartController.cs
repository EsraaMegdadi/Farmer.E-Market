

using Farmer.Core.Data;
using Farmer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Farmer.E_Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartService CartService;
        private readonly IConfiguration _configuration;
        private object errorMessage;

        public CartController(ICartService cartService, IConfiguration configuration)
        {
            _configuration = configuration;
            CartService = cartService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Cart>), StatusCodes.Status200OK)]
        public List<Cart> GetAll()
        {
            return CartService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public Cart getbyid(int id)
        {
            return CartService.GetById(id);
        }

        [HttpPost]

        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Cart Create([FromBody] Cart cart)
        {
            return CartService.Create(cart);
        }



        [HttpPost]
        [Route("order")]
        public Cart order([FromBody] Cart cart)
        {
            return CartService.order1(cart);
        }


        [HttpGet]
       
        public List<Cart> userCart([FromBody] Cart cart)
        {
            return CartService.userCart(cart);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status400BadRequest)]

        public Cart Update([FromBody] Cart cart)
        {
            return CartService.Update(cart);
        }


        [HttpDelete("{id}")]
        public Cart Delete(int id)
        {
            return CartService.Delete(id);

        }
        [HttpGet]
        [Route("userCart1")]
        public JsonResult userCart1()
        {
             string query = @"SELECT * from cart";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DBConnectionString");
                SqlDataReader myReader;
                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader); ;

                        myReader.Close();
                        myCon.Close();
                    }
                }

                return new JsonResult(table);
            }
           

             
        }



    
}

