using DIMVC.Models;
using FluentValidation;

namespace DIMVC.Validations
{
    public class RegistrationFormValidation : AbstractValidator<RegistrationForm>
    {
        public RegistrationFormValidation()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty();

            RuleFor(x => x.LastName)
                .NotEmpty();

            RuleFor(x => x.EmailAddress)
                .EmailAddress()
                .NotEmpty();

            RuleFor(x => x.Password)
                .Matches("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")
                .NotEmpty();

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Password and ConfirmPassword is not same.");
        }
    }
}
