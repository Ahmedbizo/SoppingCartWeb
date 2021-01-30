
namespace ShoppingCart.DTO
{

    // Customers
    
    public class CustomerDTO
    {
        public int              Id                  { get; set; } // Id (Primary key)
        public string           Pricelevel              { get; set; } // pricelevel (length: 15)
        public string           Firstname                { get; set; } // firstname (length: 35)
        public string           Lastname                { get; set; } // lastname (length: 35)
        public string           Companyname                 { get; set; } // companyname (length: 50)
        public string           Address1                 { get; set; } // address_1 (length: 55)
        public string           Address2                { get; set; } // address_2 (length: 55)
        public string           City                { get; set; } // city (length: 35)
        public int?             State                   { get; set; } // state
        public string           Zipcode              { get; set; } // zipcode (length: 10)
        public string           Phone                    { get; set; } // phone (length: 20)
        public string           Email               { get; set; } // email (length: 55)
        public int?             Maillist                { get; set; } // maillist
        public string           Providerinfo             { get; set; } // providerinfo (length: 25)
        public System.DateTime? Dts                 { get; set; } // dts
        public string           Password                { get; set; } // password (length: 30)
        public int?             Taxable { get; set; } // taxable

    }

}
// </auto-generated>
