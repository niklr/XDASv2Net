using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XDASv2Net.Results;

namespace XDASv2Net.Attributes
{
    /// <summary>
    /// Source: http://www.technofattie.com/2011/10/05/recursive-validation-using-dataannotations.html
    /// </summary>
    public class ValidateObjectAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(value, null, null);

            Validator.TryValidateObject(value, context, results, true);

            if (results.Count != 0)
            {
                var compositeResults = new CompositeValidationResult(string.Format("Validation for {0} failed!", validationContext.DisplayName));
                results.ForEach(compositeResults.AddResult);

                return compositeResults;
            }

            return ValidationResult.Success;
        }
    }
}
