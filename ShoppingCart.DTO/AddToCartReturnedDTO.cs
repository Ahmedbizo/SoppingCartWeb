using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class AddToCartReturnedDTO
    {
        public string Message {get;set;}
        public string SessionId { get; set; }
        public ProductDTO[] products { get; set; } 
    }
}
