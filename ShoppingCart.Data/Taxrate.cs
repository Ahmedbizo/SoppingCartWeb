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

    // Taxrates
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class Taxrate
    {
        public int Id { get; set; } // Id (Primary key)
        public int Taxid { get; set; } // taxid
        public decimal Rate { get; set; } // rate
        public decimal StartAmount { get; set; } // start_amount
        public decimal EndAmount { get; set; } // end_amount
        public string Ratetype { get; set; } // ratetype (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent Tax pointed by [Taxrates].([Taxid]) (FK_Tax_ToTaxrate)
        /// </summary>
        public virtual Tax Tax { get; set; } // FK_Tax_ToTaxrate

        public Taxrate()
        {
            Taxid = 0;
            Rate = 0.0000m;
            StartAmount = 0.00m;
            EndAmount = 0.00m;
            Ratetype = "";
        }
    }

}
// </auto-generated>