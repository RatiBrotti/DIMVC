using System.Net;

namespace DIMVC.DbClasses
{
    public partial class ActivatedAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserLevel { get; set; }
        public bool? AcaountStatus { get; set; }
        public string DeactivationComment { get; set; }


        public List<Address> Addresses { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<ShoppingBag> ShoppingBags { get; set; }
    }
}
