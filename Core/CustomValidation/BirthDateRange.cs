using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.CustomValidation
{
    public class BirthDateRange : ValidationAttribute
    {
        public DateTime MinDate { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value <= DateTime.Now.AddYears(-18))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Lütfen Geçerli Bir Doğum Tarihi Giriniz");
            }
        }
    }
}
