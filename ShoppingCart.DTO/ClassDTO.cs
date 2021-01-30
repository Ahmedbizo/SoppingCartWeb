
namespace ShoppingCart.DTO
{

    // Classes
    public class ClassDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int Department { get; set; } // department
        public string Name { get; set; } // name (length: 40)
        public int? Web { get; set; } // web
        public string Description { get; set; } // description (length: 2147483647)
        public string Pictureext { get; set; } // pictureext (length: 3)
         public string DepartmentName { get; set; }


        public SubClassDTO[] SubClasses { get; set; }
    }

}
// </auto-generated>
