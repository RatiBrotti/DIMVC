namespace DIMVC.DbClasses
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime ModifiedDate { get; set; } = new DateTime();
        public int AccountId { get; set; }

        public ActivatedAccount ActivatedAccount { get; set; }

        public List<Order> Orders { get; set; }
    }
}
