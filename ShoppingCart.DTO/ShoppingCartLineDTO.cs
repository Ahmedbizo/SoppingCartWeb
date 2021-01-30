


namespace ShoppingCart.DTO
{

   
    public class ShoppingCartLineDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int CartId { get; set; } // CartID
        public int SkuId { get; set; } // SkuId
        public int? Quantity { get; set; } // Quantity
        public string LineNo { get; set; } // Line_No (length: 40)
        public int? ParentLineNo { get; set; } // Parent_line_no
        public string Personalization { get; set; } // Personalization (length: 254)
        public string Flags { get; set; } // flags (length: 10)

      
    }

}
// </auto-generated>
