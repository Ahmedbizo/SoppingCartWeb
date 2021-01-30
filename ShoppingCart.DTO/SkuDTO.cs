


namespace ShoppingCart.DTO
{

  
    public class SkuDTO
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

        
    }

}
// </auto-generated>
