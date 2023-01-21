
using System;
using System.Collections.Generic;

namespace DIMVC.DbClasses
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string? ProductNumber { get; set; }
        public string? Color { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ShippingPrice { get; set; }
        public string? ShippingDimensions { get; set; }
        public decimal? ShippingWeight { get; set; }
        public int? CategoryId { get; set; }
        public string? Describtion { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? PhotoFileName { get; set; }
        public int AccountId { get; set; }

        public ActivatedAccount ActivatedAccount { get; set; }
        public Category Category { get; set; }
        public List<ShoppingBag> ShoppingBags { get; set; }



    }
}


