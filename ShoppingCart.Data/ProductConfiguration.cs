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
    public class ProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
            : this("dbo")
        {
        }

        public ProductConfiguration(string schema)
        {
            ToTable("Products", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DepartmentId).HasColumnName(@"departmentId").HasColumnType("int").IsOptional();
            Property(x => x.ClassId).HasColumnName(@"classId").HasColumnType("int").IsOptional();
            Property(x => x.SubclassId).HasColumnName(@"subclassId").HasColumnType("int").IsOptional();
            Property(x => x.Description).HasColumnName(@"description").HasColumnType("nvarchar").IsOptional().HasMaxLength(45);
            Property(x => x.Fabric).HasColumnName(@"fabric").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Taxable).HasColumnName(@"taxable").HasColumnType("int").IsOptional();
            Property(x => x.Web).HasColumnName(@"web").HasColumnType("int").IsOptional();
            Property(x => x.InStore).HasColumnName(@"in_store").HasColumnType("int").IsOptional();
            Property(x => x.ManufacturerId).HasColumnName(@"manufacturerId").HasColumnType("int").IsOptional();
            Property(x => x.Stockcheckid).HasColumnName(@"stockcheckid").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.Overridestockcheck).HasColumnName(@"overridestockcheck").HasColumnType("int").IsOptional();
            Property(x => x.Icon1).HasColumnName(@"icon1").HasColumnType("int").IsOptional();
            Property(x => x.Icon1Start).HasColumnName(@"icon1_start").HasColumnType("datetime").IsOptional();
            Property(x => x.Icon1End).HasColumnName(@"icon1_end").HasColumnType("datetime").IsOptional();
            Property(x => x.Icon2).HasColumnName(@"icon2").HasColumnType("int").IsOptional();
            Property(x => x.Icon2Start).HasColumnName(@"icon2_start").HasColumnType("datetime").IsOptional();
            Property(x => x.Icon2End).HasColumnName(@"icon2_end").HasColumnType("datetime").IsOptional();
            Property(x => x.Icon3).HasColumnName(@"icon3").HasColumnType("int").IsOptional();
            Property(x => x.Icon3Start).HasColumnName(@"icon3_start").HasColumnType("datetime").IsOptional();
            Property(x => x.Icon3End).HasColumnName(@"icon3_end").HasColumnType("datetime").IsOptional();
            Property(x => x.Shipexcepttype).HasColumnName(@"shipexcepttype").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shipcharge).HasColumnName(@"shipcharge").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.Linktitle).HasColumnName(@"linktitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Linkurl).HasColumnName(@"linkurl").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Extdescription).HasColumnName(@"extdescription").HasColumnType("text").IsOptional().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.PriceLow).HasColumnName(@"price_low").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.PriceHigh).HasColumnName(@"price_high").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.Picwidth).HasColumnName(@"picwidth").HasColumnType("int").IsOptional();
            Property(x => x.Pictureext).HasColumnName(@"pictureext").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Picheight).HasColumnName(@"picheight").HasColumnType("int").IsOptional();
            Property(x => x.Personalization).HasColumnName(@"personalization").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.SpCmpPriceLow).HasColumnName(@"sp_cmp_price_low").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.SpCmpPriceHigh).HasColumnName(@"sp_cmp_price_high").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CmpAtPriceLow).HasColumnName(@"cmp_at_price_low").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CmpAtPriceHigh).HasColumnName(@"cmp_at_price_high").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.Stockstatus).HasColumnName(@"stockstatus").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Salesrankqty).HasColumnName(@"salesrankqty").HasColumnType("int").IsOptional();
            Property(x => x.ActiveIcon1).HasColumnName(@"active_icon1").HasColumnType("int").IsOptional();
            Property(x => x.ActiveIcon2).HasColumnName(@"active_icon2").HasColumnType("int").IsOptional();
            Property(x => x.ActiveIcon3).HasColumnName(@"active_icon3").HasColumnType("int").IsOptional();
            Property(x => x.ProductGroup).HasColumnName(@"product_group").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Category).HasColumnName(@"category").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Season).HasColumnName(@"season").HasColumnType("nvarchar").IsOptional().HasMaxLength(6);
            Property(x => x.ModelId).HasColumnName(@"model_id").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ModifiedDts).HasColumnName(@"modified_dts").HasColumnType("datetime").IsRequired();
            Property(x => x.ClubPriceLow).HasColumnName(@"club_price_low").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.ClubPriceHigh).HasColumnName(@"club_price_high").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.ActiveInvDts).HasColumnName(@"active_inv_dts").HasColumnType("datetime").IsRequired();
            Property(x => x.Length).HasColumnName(@"length").HasColumnType("decimal").IsRequired().HasPrecision(15,2);
            Property(x => x.Width).HasColumnName(@"width").HasColumnType("decimal").IsRequired().HasPrecision(15,2);
            Property(x => x.Height).HasColumnName(@"height").HasColumnType("decimal").IsRequired().HasPrecision(15,2);
            Property(x => x.Weight).HasColumnName(@"weight").HasColumnType("decimal").IsRequired().HasPrecision(15,2);
            Property(x => x.ShipSeparately).HasColumnName(@"ship_separately").HasColumnType("int").IsRequired();
            Property(x => x.AdditionalHandling).HasColumnName(@"additional_handling").HasColumnType("int").IsRequired();
            Property(x => x.PackageType).HasColumnName(@"package_type").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.ProductType).HasColumnName(@"product_type").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.PrintDetail).HasColumnName(@"print_detail").HasColumnType("int").IsRequired();
            Property(x => x.DateReceived).HasColumnName(@"date_received").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Class).WithMany(b => b.Products).HasForeignKey(c => c.ClassId).WillCascadeOnDelete(false); // FK_Class_ToProduct
            HasOptional(a => a.Department).WithMany(b => b.Products).HasForeignKey(c => c.DepartmentId).WillCascadeOnDelete(false); // FK_Departments_ToProdcut
            HasOptional(a => a.Manufacturer).WithMany(b => b.Products).HasForeignKey(c => c.ManufacturerId).WillCascadeOnDelete(false); // FK_Manufacturer_ToProduct
            HasOptional(a => a.SubClass).WithMany(b => b.Products).HasForeignKey(c => c.SubclassId).WillCascadeOnDelete(false); // FK_SubClass_ToProduct
        }
    }

}
// </auto-generated>
