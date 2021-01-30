using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class ShipRateDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int ShipMethodId { get; set; } // ShipMethodId (Primary key)
        public decimal Amount { get; set; } // Amount (Primary key)
        public decimal StartAmount { get; set; } // StartAmount (Primary key)
        public decimal EndAmount { get; set; } // EndAmount (Primary key)

        // Foreign keys
    }
}
