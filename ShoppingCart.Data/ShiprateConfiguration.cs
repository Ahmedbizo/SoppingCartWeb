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

    // shiprates
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class ShiprateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shiprate>
    {
        public ShiprateConfiguration()
            : this("dbo")
        {
        }

        public ShiprateConfiguration(string schema)
        {
            ToTable("shiprates", schema);
            HasKey(x => new { x.Id, x.ShipMethodId, x.Amount, x.StartAmount, x.EndAmount });

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ShipMethodId).HasColumnName(@"ShipMethodId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Amount).HasColumnName(@"Amount").HasColumnType("decimal").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartAmount).HasColumnName(@"StartAmount").HasColumnType("decimal").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EndAmount).HasColumnName(@"EndAmount").HasColumnType("decimal").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.ShipMethod).WithMany(b => b.Shiprates).HasForeignKey(c => c.ShipMethodId).WillCascadeOnDelete(false); // FK_ShipMethod_ToShipRates
        }
    }

}
// </auto-generated>