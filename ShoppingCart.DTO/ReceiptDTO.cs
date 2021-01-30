


namespace ShoppingCart.DTO
{
        
    public class ReceiptDTO
    {
        public int Id { get; set; } // Id (Primary key)
        public int Customerid { get; set; } // customerid
        public System.DateTime Dts { get; set; } // dts
        public decimal? Gsttotal { get; set; } // gsttotal
        public decimal? Psttotal { get; set; } // psttotal
        public int Linecount { get; set; } // linecount
        public decimal? Shippingbasetax { get; set; } // shippingbasetax
        public decimal? Shippingpremiumtax { get; set; } // shippingpremiumtax
        public decimal? Shippingtaxtotal { get; set; } // shippingtaxtotal
        public decimal Subtotal { get; set; } // subtotal
        public decimal Taxtotal { get; set; } // taxtotal
        public string Version { get; set; } // version (length: 8)
        public int Shipmethodid { get; set; } // shipmethodid
        public int Shiprateid { get; set; } // shiprateid
        public string Shipname { get; set; } // shipname (length: 75)
        public decimal Shipstartamount { get; set; } // shipstartamount
        public decimal Shipendamount { get; set; } // shipendamount
        public int Paymentid { get; set; } // paymentid
        public string Paymentname { get; set; } // paymentname (length: 35)
        public string Ccnumber { get; set; } // ccnumber (length: 25)
        public int? Expirationmonth { get; set; } // expirationmonth
        public int? Expirationyear { get; set; } // expirationyear
        public string Orderflags { get; set; } // orderflags (length: 15)
        public string Customernotes { get; set; } // customernotes (length: 2147483647)
        public System.DateTime Lastactivity { get; set; } // lastactivity
        public string Cvv2 { get; set; } // cvv2 (length: 4)
        public string Shipfirstname { get; set; } // shipfirstname (length: 35)
        public string Shiplastname { get; set; } // shiplastname (length: 35)
        public string Shipcompany { get; set; } // shipcompany (length: 45)
        public string Shipaddress1 { get; set; } // shipaddress1 (length: 50)
        public string Shipaddress2 { get; set; } // shipaddress2 (length: 50)
        public string Shipcity { get; set; } // shipcity (length: 35)
        public string Shipstate { get; set; } // shipstate (length: 10)
        public string Shipzipcode { get; set; } // shipzipcode (length: 10)
        public string Shipphone { get; set; } // shipphone (length: 20)
        public string Grid { get; set; } // grid (length: 10)
        public decimal ShippingBase { get; set; } // shipping_base
        public decimal ShippingPremiums { get; set; } // shipping_premiums
        public string InternalNotes { get; set; } // internalNotes (length: 2147483647)
        public string CouponCode { get; set; } // couponCode (length: 15)
        public int? CouponCodeId { get; set; } // couponCodeId
        public decimal? Discounts { get; set; } // discounts

        public ReceiptLineDTO[] ReceiptLines { get; set; }

       
    }

}
// </auto-generated>
