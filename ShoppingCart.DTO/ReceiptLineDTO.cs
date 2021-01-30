


namespace ShoppingCart.DTO
{

     public class ReceiptLineDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int Receiptid { get; set; } // receiptid
        public decimal Cost { get; set; } // cost
        public int? Department { get; set; } // department
        public string Description { get; set; } // description (length: 65)
        public decimal? Gstamount { get; set; } // gstamount
        public decimal? Pstamount { get; set; } // pstamount
        public int Qty { get; set; } // qty
        public decimal? Retailprice { get; set; } // retailprice
        public decimal Sellingprice { get; set; } // sellingprice
        public System.DateTime? Expectedship { get; set; } // expectedship
        public int? Shipqty { get; set; } // shipqty
        public int Sku { get; set; } // sku
        public string Color { get; set; } // color (length: 5)
        public string Size { get; set; } // size (length: 15)
        public string Subsize { get; set; } // subsize (length: 15)
        public decimal Shippingbasetax { get; set; } // shippingbasetax
        public decimal Shippingpremiumtax { get; set; } // shippingpremiumtax
        public decimal Shippingtaxamount { get; set; } // shippingtaxamount
        public decimal Taxamount { get; set; } // taxamount
        public int Taxtableid { get; set; } // taxtableid
        public string Trackingno { get; set; } // trackingno (length: 30)
        public string Flags { get; set; } // flags (length: 15)
        public string PersInfo { get; set; } // pers_info (length: 254)
        public int? Parentlineno { get; set; } // parentlineno
        public System.DateTime? Shipdate { get; set; } // shipdate
        public int Productid { get; set; } // productid
        public System.DateTime? Dts { get; set; } // dts
        public decimal Discount { get; set; } // discount
        public int? SplitParentLineNo { get; set; } // splitParentLineNo
        public string LineType { get; set; } // line_type (length: 1)
        public int KitParentline { get; set; } // kit_parentline

     
    }

}
// </auto-generated>
