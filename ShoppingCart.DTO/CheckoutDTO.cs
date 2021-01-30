using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class CheckoutDTO
    {
      public bool IsNewCustomer { get; set; }
        public bool BillingIsShipping { get; set; }
        public string sessionId { get; set; }
       public string Id                 { get;set;}
       public string Pricelevel         { get;set;}
       public string Firstname          { get;set;}
       public string Lastname           { get;set;}
       public string Companyname        { get;set;}
       public string Address1           { get;set;}
       public string Address2           { get;set;}
       public string City               { get;set;}
       public string State              { get;set;}
       public string Zipcode            { get;set;}
       public string Phone              { get;set;}
       public string Email              { get;set;}
       public string Maillist           { get;set;}
       public string Providerinfo       { get;set;}
       public string Dts                { get;set;}
       public string Password           { get;set;}
       public string Taxable            { get;set;}
       public string ship_Id            { get;set;}
       public string ship_Customerid    { get;set;}
       public string ship_Firstname     { get;set;}
       public string ship_Lastname      { get;set;}
       public string ship_Companyname   { get;set;}
       public string ship_Address1      { get;set;}
       public string ship_Address2      { get;set;}
       public string ship_City          { get;set;}
       public string ship_State         { get;set;}
       public string ship_Zipcode       { get;set;}
       public string ship_Dts           { get;set;}
       public string ship_Phone         { get;set;}
       public string confirmPassword    { get;set;}
       public string shipMethod         { get;set;}
       public string orderNotes         { get;set;}
       public string totalCartPrice     { get;set;}
       public string Tax                { get;set;}
       public string ShipRate           { get;set;}
       public string priceWithTax       { get;set;}
       public string CartType           { get;set;}
       public string ccnumber           { get;set;}
       public string Month              { get;set;}
       public string Year               { get;set;}
       public string cvccode            { get;set;}
       public string cashOnDelivery { get; set; }
       public int customerId { get; set; }
    }
}
