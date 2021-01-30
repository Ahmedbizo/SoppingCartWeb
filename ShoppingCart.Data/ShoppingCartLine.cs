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

    // ShoppingCartLine
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class ShoppingCartLine
    {
        public int Id { get; set; } // Id (Primary key)
        public int CartId { get; set; } // CartID
        public int SkuId { get; set; } // SkuId
        public int? Quantity { get; set; } // Quantity
        public string LineNo { get; set; } // Line_No (length: 40)
        public int? ParentLineNo { get; set; } // Parent_line_no
        public string Personalization { get; set; } // Personalization (length: 254)
        public string Flags { get; set; } // flags (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent ShoppingCartHeader pointed by [ShoppingCartLine].([CartId]) (FK_ShoppingCartHeader_ToPShoppingCartLine)
        /// </summary>
        public virtual ShoppingCartHeader ShoppingCartHeader { get; set; } // FK_ShoppingCartHeader_ToPShoppingCartLine

        /// <summary>
        /// Parent Sku pointed by [ShoppingCartLine].([SkuId]) (FK_Sku_cartHeader)
        /// </summary>
        public virtual Sku Sku { get; set; } // FK_Sku_cartHeader
    }

}
// </auto-generated>