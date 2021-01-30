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

    // Classes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.3.0")]
    public class Class
    {
        public int Id { get; set; } // Id (Primary key)
        public int DepartmentId { get; set; } // departmentId
        public string Name { get; set; } // name (length: 40)
        public int? Web { get; set; } // web
        public string Description { get; set; } // description (length: 2147483647)
        public string Pictureext { get; set; } // pictureext (length: 3)

        // Reverse navigation

        /// <summary>
        /// Child Products where [Products].[classId] point to this entity (FK_Class_ToProduct)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Product> Products { get; set; } // Products.FK_Class_ToProduct
        /// <summary>
        /// Child SubClasses where [SubClasses].[classId] point to this entity (FK_Class_ToSubClass)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SubClass> SubClasses { get; set; } // SubClasses.FK_Class_ToSubClass

        // Foreign keys

        /// <summary>
        /// Parent Department pointed by [Classes].([DepartmentId]) (FK_Departments_ToTable)
        /// </summary>
        public virtual Department Department { get; set; } // FK_Departments_ToTable

        public Class()
        {
            Products = new System.Collections.Generic.List<Product>();
            SubClasses = new System.Collections.Generic.List<SubClass>();
        }
    }

}
// </auto-generated>
