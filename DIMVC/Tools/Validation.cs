//using System.ComponentModel.DataAnnotations;
//using System.Text.RegularExpressions;

//namespace DIMVC.Tools
//{
//    public class Validation
//    {
//        protected  bool IsValid(object value, ValidationContext context)
//        {
//            bool validPassword = false;
//            string reason = String.Empty;
//            string Password = value == null ? String.Empty : value.ToString();
//            if (String.IsNullOrEmpty(Password) || Password.Length < 8)
//            {
//                reason = "Your new password must be at least 8 characters long. ";
//            }
//            else
//            {
//                Regex reSymbol = new Regex("[^a-zA-Z0-9]");
//                if (!reSymbol.IsMatch(Password))
//                {
//                    reason += "Your new password must contain at least 1 symbol character.";
//                }
//                else
//                {
//                    validPassword = true;
//                }
//            }
//            if (validPassword)
//            {
//                return ValidationResult.Success;
//            }
//            else
//            {
//                return new ValidationResult(reason);
//            }
//        }
//    }
//}
