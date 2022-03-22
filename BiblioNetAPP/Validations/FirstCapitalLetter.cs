﻿using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Validations
{
    public class FirstCapitalLetter: ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext validationcontext)
        {
            //eliminar
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var firstLetter = value.ToString()[0].ToString();

            if (firstLetter != firstLetter.ToUpper())
            {
                return new ValidationResult("The first letter must be in uppercase");
            }
            return ValidationResult.Success;
        }
    }
}
