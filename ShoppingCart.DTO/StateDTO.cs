


namespace ShoppingCart.DTO
{

    
    public class StateDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // name (length: 50)
        public string Providerinfo { get; set; } // providerinfo (length: 25)
        public int Taxid { get; set; } // taxid
        public int? TaxableShipping { get; set; } // taxableShipping

     
    }

}
// </auto-generated>
