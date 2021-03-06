// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ShoppingCart.Data
{

    // Customers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class Customer
    {
        public int Id { get; set; } // Id (Primary key)
        public string Pricelevel { get; set; } // pricelevel (length: 15)
        public string Firstname { get; set; } // firstname (length: 35)
        public string Lastname { get; set; } // lastname (length: 35)
        public string Companyname { get; set; } // companyname (length: 50)
        public string Address1 { get; set; } // address_1 (length: 55)
        public string Address2 { get; set; } // address_2 (length: 55)
        public string City { get; set; } // city (length: 35)
        public int? State { get; set; } // state
        public string Zipcode { get; set; } // zipcode (length: 10)
        public string Phone { get; set; } // phone (length: 20)
        public string Email { get; set; } // email (length: 55)
        public int? Maillist { get; set; } // maillist
        public string Providerinfo { get; set; } // providerinfo (length: 50)
        public System.DateTime? Dts { get; set; } // dts
        public string Password { get; set; } // password (length: 30)
        public int? Taxable { get; set; } // taxable

        // Reverse navigation

        /// <summary>
        /// Child Receipts where [Receipts].[customerid] point to this entity (FK_Customer_ToReceipt)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Receipt> Receipts { get; set; } // Receipts.FK_Customer_ToReceipt
        /// <summary>
        /// Child ShipAddresses where [ShipAddresses].[customerid] point to this entity (FK_Customer_ToShipAddress)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ShipAddress> ShipAddresses { get; set; } // ShipAddresses.FK_Customer_ToShipAddress

        // Foreign keys

        /// <summary>
        /// Parent State pointed by [Customers].([State]) (FK_State_ToCustomer)
        /// </summary>
        public virtual State State_State { get; set; } // FK_State_ToCustomer

        public Customer()
        {
            Taxable = 1;
            Receipts = new System.Collections.Generic.List<Receipt>();
            ShipAddresses = new System.Collections.Generic.List<ShipAddress>();
        }
    }

}
// </auto-generated>
