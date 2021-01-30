using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class OrderDetailsDTO
    {
        public ReceiptDTO Receipt { get; set; }
      
       public ProductWithSku[] ProductsWithSkus { get; set; }
    }

    public class ProductWithSku {

        public ProductDTO Product { get; set; }
        public SkuDTO Sku { get; set; }

    }
}
