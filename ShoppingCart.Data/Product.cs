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

    // Products
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class Product
    {
        public int Id { get; set; } // Id (Primary key)
        public int? DepartmentId { get; set; } // departmentId
        public int? ClassId { get; set; } // classId
        public int? SubclassId { get; set; } // subclassId
        public string Description { get; set; } // description (length: 45)
        public string Fabric { get; set; } // fabric (length: 15)
        public int? Taxable { get; set; } // taxable
        public int? Web { get; set; } // web
        public int? InStore { get; set; } // in_store
        public int? ManufacturerId { get; set; } // manufacturerId
        public string Stockcheckid { get; set; } // stockcheckid (length: 5)
        public int? Overridestockcheck { get; set; } // overridestockcheck
        public int? Icon1 { get; set; } // icon1
        public System.DateTime? Icon1Start { get; set; } // icon1_start
        public System.DateTime? Icon1End { get; set; } // icon1_end
        public int? Icon2 { get; set; } // icon2
        public System.DateTime? Icon2Start { get; set; } // icon2_start
        public System.DateTime? Icon2End { get; set; } // icon2_end
        public int? Icon3 { get; set; } // icon3
        public System.DateTime? Icon3Start { get; set; } // icon3_start
        public System.DateTime? Icon3End { get; set; } // icon3_end
        public string Shipexcepttype { get; set; } // shipexcepttype (length: 1)
        public decimal? Shipcharge { get; set; } // shipcharge
        public string Linktitle { get; set; } // linktitle (length: 40)
        public string Linkurl { get; set; } // linkurl (length: 100)
        public string Extdescription { get; set; } // extdescription (length: 2147483647)
        public decimal? PriceLow { get; set; } // price_low
        public decimal? PriceHigh { get; set; } // price_high
        public int? Picwidth { get; set; } // picwidth
        public string Pictureext { get; set; } // pictureext (length: 3)
        public int? Picheight { get; set; } // picheight
        public string Personalization { get; set; } // personalization (length: 1)
        public decimal? SpCmpPriceLow { get; set; } // sp_cmp_price_low
        public decimal? SpCmpPriceHigh { get; set; } // sp_cmp_price_high
        public decimal? CmpAtPriceLow { get; set; } // cmp_at_price_low
        public decimal? CmpAtPriceHigh { get; set; } // cmp_at_price_high
        public string Stockstatus { get; set; } // stockstatus (length: 2)
        public int? Salesrankqty { get; set; } // salesrankqty
        public int? ActiveIcon1 { get; set; } // active_icon1
        public int? ActiveIcon2 { get; set; } // active_icon2
        public int? ActiveIcon3 { get; set; } // active_icon3
        public string ProductGroup { get; set; } // product_group (length: 10)
        public string Category { get; set; } // category (length: 15)
        public string Season { get; set; } // season (length: 6)
        public string ModelId { get; set; } // model_id (length: 30)
        public System.DateTime ModifiedDts { get; set; } // modified_dts
        public decimal? ClubPriceLow { get; set; } // club_price_low
        public decimal? ClubPriceHigh { get; set; } // club_price_high
        public System.DateTime ActiveInvDts { get; set; } // active_inv_dts
        public decimal Length { get; set; } // length
        public decimal Width { get; set; } // width
        public decimal Height { get; set; } // height
        public decimal Weight { get; set; } // weight
        public int ShipSeparately { get; set; } // ship_separately
        public int AdditionalHandling { get; set; } // additional_handling
        public string PackageType { get; set; } // package_type (length: 2)
        public string ProductType { get; set; } // product_type (length: 1)
        public int PrintDetail { get; set; } // print_detail
        public System.DateTime? DateReceived { get; set; } // date_received

        // Reverse navigation

        /// <summary>
        /// Child ReceiptLines where [ReceiptLine].[productid] point to this entity (FK_Product_ToReceiptLine)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ReceiptLine> ReceiptLines { get; set; } // ReceiptLine.FK_Product_ToReceiptLine
        /// <summary>
        /// Child Skus where [Skus].[productid] point to this entity (FK_Product_ToSku)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sku> Skus { get; set; } // Skus.FK_Product_ToSku

        // Foreign keys

        /// <summary>
        /// Parent Class pointed by [Products].([ClassId]) (FK_Class_ToProduct)
        /// </summary>
        public virtual Class Class { get; set; } // FK_Class_ToProduct

        /// <summary>
        /// Parent Department pointed by [Products].([DepartmentId]) (FK_Departments_ToProdcut)
        /// </summary>
        public virtual Department Department { get; set; } // FK_Departments_ToProdcut

        /// <summary>
        /// Parent Manufacturer pointed by [Products].([ManufacturerId]) (FK_Manufacturer_ToProduct)
        /// </summary>
        public virtual Manufacturer Manufacturer { get; set; } // FK_Manufacturer_ToProduct

        /// <summary>
        /// Parent SubClass pointed by [Products].([SubclassId]) (FK_SubClass_ToProduct)
        /// </summary>
        public virtual SubClass SubClass { get; set; } // FK_SubClass_ToProduct

        public Product()
        {
            ReceiptLines = new System.Collections.Generic.List<ReceiptLine>();
            Skus = new System.Collections.Generic.List<Sku>();
        }
    }

}
// </auto-generated>
