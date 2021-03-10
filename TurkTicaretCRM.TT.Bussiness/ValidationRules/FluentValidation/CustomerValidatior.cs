using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.ValidationRules.FluentValidation
{
    public class CustomerValidatior:AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
            RuleFor(p => p.CustomerID).NotEmpty();
            RuleFor(p => p.CustomerName).NotEmpty();
            RuleFor(p => p.CustomerSurname).NotEmpty();
            RuleFor(p => p.CustomerAddress).NotEmpty();
        }
    }
}
