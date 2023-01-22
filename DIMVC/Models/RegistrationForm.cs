using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DIMVC.Models
{
    public class RegistrationForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        []
        public string Password { get; set; }
        [Required]
        [DataType(dataType:Password)]
        public string ConfirmPassword { get; set; }
    }
}
