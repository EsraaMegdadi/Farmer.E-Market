using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.DTO
{
   public class ProductsCategoryDTO
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImg { get; set; }
        public ICollection<Products> products { get; set; }

    }
}
