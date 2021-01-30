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
    public class ShoppingCartLineConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShoppingCartLine>
    {
        public ShoppingCartLineConfiguration()
            : this("dbo")
        {
        }

        public ShoppingCartLineConfiguration(string schema)
        {
            ToTable("ShoppingCartLine", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CartId).HasColumnName(@"CartID").HasColumnType("int").IsRequired();
            Property(x => x.SkuId).HasColumnName(@"SkuId").HasColumnType("int").IsRequired();
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsOptional();
            Property(x => x.LineNo).HasColumnName(@"Line_No").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ParentLineNo).HasColumnName(@"Parent_line_no").HasColumnType("int").IsOptional();
            Property(x => x.Personalization).HasColumnName(@"Personalization").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(254);
            Property(x => x.Flags).HasColumnName(@"flags").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.ShoppingCartHeader).WithMany(b => b.ShoppingCartLines).HasForeignKey(c => c.CartId).WillCascadeOnDelete(false); // FK_ShoppingCartHeader_ToPShoppingCartLine
            HasRequired(a => a.Sku).WithMany(b => b.ShoppingCartLines).HasForeignKey(c => c.SkuId).WillCascadeOnDelete(false); // FK_Sku_cartHeader
        }
    }

}
// </auto-generated>
