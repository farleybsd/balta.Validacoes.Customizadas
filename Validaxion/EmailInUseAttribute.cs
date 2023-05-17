using System.ComponentModel.DataAnnotations;

namespace Validaxion
{
    public class EmailInUseAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return (string)value == "hello@balta.io" ? new ValidationResult("Este Email ja Esta Em Uso") : ValidationResult.Success;
        }
    }
}
