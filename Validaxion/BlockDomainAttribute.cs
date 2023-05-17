using System.ComponentModel.DataAnnotations;

namespace Validaxion
{
    public class BlockDomainAttribute : ValidationAttribute
    {
        public BlockDomainAttribute(string domain)
        {
            Domain = domain;
        }

        public string Domain { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ((string) value).Contains(Domain) ? new ValidationResult("Doninio Invalido") : ValidationResult.Success;
        }
    }
    }

