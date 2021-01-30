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

    // Taxes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class TaxConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tax>
    {
        public TaxConfiguration()
            : this("dbo")
        {
        }

        public TaxConfiguration(string schema)
        {
            ToTable("Taxes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Taxtype).HasColumnName(@"taxtype").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Name).HasColumnName(@"name").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(30);
        }
    }

}
// </auto-generated>