


namespace ShoppingCart.DTO
{

    
    public class ShoppingCartHeaderDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public string GiftRegId { get; set; } // GiftRegID (length: 16)
        public string OrderNotes { get; set; } // OrderNotes (length: 2147483647)
        public System.DateTime? Timestamp { get; set; } // timestamp
        public ProductDTO[] Products { get; set; }
        public string SessionId { get; set; }


    }

}
// </auto-generated>
