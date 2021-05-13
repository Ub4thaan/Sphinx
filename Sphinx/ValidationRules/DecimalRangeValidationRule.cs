using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sphinx.ValidationRules
{
    public class DecimalRangeValidationRule : ValidationRule
    {
        public decimal Min { get; set; } = Decimal.MinValue;
        public decimal Max { get; set; } = Decimal.MaxValue;
        public bool IncludeExtremes { get; set; } = true;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            decimal number = 0;
            try
            {
                if (((string)value).Length > 0)
                {
                    number = Decimal.Parse((string)value);
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, $"Illegal characters or {ex.Message}");
            }
            if (IncludeExtremes)
            {
                if (number < Min || number > Max)
                {
                    return new ValidationResult(false, $"Please enter a value in the range: {Min} - {Max}, excluding extremes");
                }
            } 
            else
            {
                if (number <= Min || number >= Max)
                {
                    return new ValidationResult(false, $"Please enter a value in the range: {Min} - {Max}, excluding extremes");
                }
            }
            return ValidationResult.ValidResult;
        }
    }
}
