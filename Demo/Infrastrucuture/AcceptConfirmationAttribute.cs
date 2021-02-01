using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Infrastrucuture
{
    public class AcceptConfirmationAttribute : Attribute, IModelValidator
    {
        public string ErrorMessage { get; set; } = "True Value Is Valid";
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            bool? value = context.Model as bool?;

            if (value==false)
            {
                return new List<ModelValidationResult>
                { new ModelValidationResult("",ErrorMessage)};
            }
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
}
