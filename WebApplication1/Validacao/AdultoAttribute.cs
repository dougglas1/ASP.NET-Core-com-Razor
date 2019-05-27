using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Validacao
{
    public class AdultoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cliente3 cliente = (Cliente3)validationContext.ObjectInstance;

            if (cliente.Idade < 18)
                return new ValidationResult("Apenas Adultos podem se cadastrar");

            return ValidationResult.Success;
        }
    }
}
