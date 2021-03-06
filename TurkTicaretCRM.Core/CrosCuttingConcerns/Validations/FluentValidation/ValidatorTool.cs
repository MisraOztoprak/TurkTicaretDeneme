using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurkTicaretCRM.Core.CrosCuttingConcerns.Validations.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
