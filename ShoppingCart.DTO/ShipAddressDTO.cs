


namespace ShoppingCart.DTO
{

    public class ShipAddressDTO
    {
        public int                   Id                      { get; set; } // Id (Primary key)
        public int                   Customerid                 { get; set; } // customerid
        public string                Firstname               { get; set; } // firstname (length: 35)
        public string                Lastname                { get; set; } // lastname (length: 35)
        public string                Companyname                { get; set; } // companyname (length: 50)
        public string                Address1               { get; set; } // address_1 (length: 50)
        public string                Address2               { get; set; } // address_2 (length: 50)
        public string                City               { get; set; } // city (length: 35)
        public int?                  State                  { get; set; } // state
        public string                Zipcode                    { get; set; } // zipcode (length: 10)
        public System.DateTime?      Dts                     { get; set; } // dts
        public string                Phone               { get; set; } // phone (length: 20)

       
    }

}
// </auto-generated>
