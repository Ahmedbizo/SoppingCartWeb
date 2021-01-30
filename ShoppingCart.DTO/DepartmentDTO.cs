


namespace ShoppingCart.DTO
{

    // Departments
   
    public class DepartmentDTO
    {
        public int      Id { get; set; } // Id (Primary key)
        public string   Name { get; set; } // name (length: 50)
        public int?     Web { get; set; } // web
        public int?     Checkstock { get; set; } // checkstock
        public string   Stockstatusid { get; set; } // stockstatusid (length: 5)
        public string   Description { get; set; } // description (length: 2147483647)
        public string   Pictureext { get; set; } // pictureext (length: 3)
        public int?     Browsestyle { get; set; } // browsestyle
        public int?     Classlisting { get; set; } // classlisting
        public int?     Numproducts { get; set; } // numproducts
        public int?     Numproductsperrow { get; set; } // numproductsperrow
        public int?     Showmanufacturer { get; set; } // showmanufacturer
        public string   Coloralias { get; set; } // coloralias (length: 25)
        public string   Sizealias { get; set; } // sizealias (length: 25)
        public string   Subsizealias { get; set; } // subsizealias (length: 25)
        public int?     Tnheight { get; set; } // tnheight
        public int?     Tnwidth { get; set; } // tnwidth
        public string   Fabricalias { get; set; } // fabricalias (length: 25)
        public string   DeptTitleTag { get; set; } // dept_title_tag (length: 150)
        public string   Flags { get; set; } // flags (length: 15)
        public string   PersCode { get; set; } // pers_code (length: 15)
        public int?     Dontshowdefprodpic { get; set; } // dontshowdefprodpic
        public int?     Pagesbeforeafter { get; set; } // pagesbeforeafter
        public int?     Paginationbottom { get; set; } // paginationbottom
        public int?     Paginationtop { get; set; } // paginationtop
        public string   Pricelabel { get; set; } // pricelabel (length: 30)
        public string CompareAtLabel { get; set; } // compare_at_label (length: 30)
        public string SaleRegpriceLabel { get; set; } // sale_regprice_label (length: 30)
        public string SalepriceLabel { get; set; } // saleprice_label (length: 30)
        public string StockstatusLabel { get; set; } // stockstatus_label (length: 30)
        public int Browsesortstyle { get; set; } // browsesortstyle
        public string Modelidalias { get; set; } // modelidalias (length: 25)
        public int? Productdetailstyle { get; set; } // productdetailstyle
        public decimal DefaultWeight { get; set; } // default_weight
        public string Manufactureralias { get; set; } // manufactureralias (length: 25)
        public int? Showfabric { get; set; } // showfabric
        public string Relateditemsalias { get; set; } // relateditemsalias (length: 75)
        public int? Relateditemsnumperrow { get; set; } // relateditemsnumperrow
        public int? Displaydepartmentimage { get; set; } // displaydepartmentimage
        public int? Displaycolorsavailable { get; set; } // displaycolorsavailable

        public ClassDTO[] Classes { get; set; }

       
    }

}
// </auto-generated>
