using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.CustomValidation
{
    public class NegativeNumberCheck : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((int)value > 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Lütfen Geçerli Bir Sayı Giriniz");
            }
        }
    }
}
