using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class ShoppingCartWithCompleteInfoDTO
    {
      public   ShoppingCartHeaderDTO CartHeader { get; set; }
      public  ShoppingCartProductWithSkuDTO[] CartLines { get; set; }
      public decimal TotalCartPrice { get; set; }
        
    }

    public class ShoppingCartProductWithSkuDTO
    {
        public ShoppingCartLineDTO CartLine { get; set; }
        public ProductDTO Product { get; set; }
        public SkuDTO Sku { get; set; }
        public decimal ItemPrice { get; set; }

    }
}
