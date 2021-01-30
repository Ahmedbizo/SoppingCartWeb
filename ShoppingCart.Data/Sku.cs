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

    // Skus
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class Sku
    {
        public int Id { get; set; } // Id (Primary key)
        public int Productid { get; set; } // productid
        public string Color { get; set; } // color (length: 5)
        public string ColorName { get; set; } // color_name (length: 30)
        public string Size { get; set; } // size (length: 15)
        public string Subsize { get; set; } // subsize (length: 15)
        public int? Nwi { get; set; } // nwi
        public string Stockstatus { get; set; } // stockstatus (length: 1)
        public decimal? Price { get; set; } // price
        public decimal? SpecialPrice { get; set; } // special_price
        public int? InstockQty { get; set; } // instock_qty
        public decimal? RetailPrice { get; set; } // retail_price
        public decimal? Cost { get; set; } // cost
        public int Sizeorder { get; set; } // sizeorder
        public int Subsizeorder { get; set; } // subsizeorder
        public decimal? SpCmpPrice { get; set; } // sp_cmp_price
        public decimal? CmpAtPrice { get; set; } // cmp_at_price
        public string SecondSku { get; set; } // second_sku (length: 20)
        public int DepartmentId { get; set; } // departmentId
        public decimal? ClubPrice { get; set; } // club_price
        public System.DateTime ModifiedDts { get; set; } // modified_dts

        // Reverse navigation

        /// <summary>
        /// Child ShoppingCartLines where [ShoppingCartLine].[SkuId] point to this entity (FK_Sku_cartHeader)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ShoppingCartLine> ShoppingCartLines { get; set; } // ShoppingCartLine.FK_Sku_cartHeader

        // Foreign keys

        /// <summary>
        /// Parent Department pointed by [Skus].([DepartmentId]) (FK_department_ToSkuu)
        /// </summary>
        public virtual Department Department { get; set; } // FK_department_ToSkuu

        /// <summary>
        /// Parent Product pointed by [Skus].([Productid]) (FK_Product_ToSku)
        /// </summary>
        public virtual Product Product { get; set; } // FK_Product_ToSku

        public Sku()
        {
            Sizeorder = 0;
            Subsizeorder = 0;
            ShoppingCartLines = new System.Collections.Generic.List<ShoppingCartLine>();
        }
    }

}
// </auto-generated>
