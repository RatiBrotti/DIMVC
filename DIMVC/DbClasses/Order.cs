namespace DIMVC.DbClasses
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public bool? PaymentStatus { get; set; }
        public int? OrderNumber { get; set; }
        public int AccountId { get; set; }
        public int ShipToAddressId { get; set; }
        public int? BillToAddressId { get; set; }
        public string ShipMethod { get; set; }
        public decimal Total { get; set; }
        public string? Comment { get; set; }
        public DateTime ModifiedDate { get; set; } = new DateTime();

        public ActivatedAccount ActivatedAccount { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
