namespace DIMVC.DbClasses
{
    public partial class UnactivatedAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public DateTime ModifiedDate { get; set; } = new DateTime();
        public string ActivationToken { get; set; }
    }
}
