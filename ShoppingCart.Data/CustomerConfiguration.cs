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
    public class CustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
            : this("dbo")
        {
        }

        public CustomerConfiguration(string schema)
        {
            ToTable("Customers", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pricelevel).HasColumnName(@"pricelevel").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Firstname).HasColumnName(@"firstname").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Lastname).HasColumnName(@"lastname").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Companyname).HasColumnName(@"companyname").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Address1).HasColumnName(@"address_1").HasColumnType("nvarchar").IsOptional().HasMaxLength(55);
            Property(x => x.Address2).HasColumnName(@"address_2").HasColumnType("nvarchar").IsOptional().HasMaxLength(55);
            Property(x => x.City).HasColumnName(@"city").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.State).HasColumnName(@"state").HasColumnType("int").IsOptional();
            Property(x => x.Zipcode).HasColumnName(@"zipcode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Phone).HasColumnName(@"phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("nvarchar").IsOptional().HasMaxLength(55);
            Property(x => x.Maillist).HasColumnName(@"maillist").HasColumnType("int").IsOptional();
            Property(x => x.Providerinfo).HasColumnName(@"providerinfo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Dts).HasColumnName(@"dts").HasColumnType("datetime").IsOptional();
            Property(x => x.Password).HasColumnName(@"password").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Taxable).HasColumnName(@"taxable").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.State_State).WithMany(b => b.Customers).HasForeignKey(c => c.State).WillCascadeOnDelete(false); // FK_State_ToCustomer
        }
    }

}
// </auto-generated>
