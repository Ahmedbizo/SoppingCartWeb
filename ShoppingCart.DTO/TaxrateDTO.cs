


namespace ShoppingCart.DTO
{

    public class TaxrateDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int Taxid { get; set; } // taxid
        public decimal Rate { get; set; } // rate
        public decimal StartAmount { get; set; } // start_amount
        public decimal EndAmount { get; set; } // end_amount
        public string Ratetype { get; set; } // ratetype (length: 1)
               
    }

}
// </auto-generated>
