using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DIMVC.Models
{
    public class RegistrationForm
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string Phone { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
