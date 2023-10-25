
using System.ComponentModel.DataAnnotations;

namespace GestionEvenementASP.Tools
{
   public class DateRangeAttribute : ValidationAttribute
   {
      private readonly int _maxDays;
      public DateRangeAttribute(int maxdays)
      {
         _maxDays = maxdays;
      }

      protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
      {
         if (value is DateTime endDate)
         {
            var startDateProperty = validationContext.ObjectType.GetProperty("StartDate");
            if (startDateProperty != null)
            {
               var startDate = (DateTime)startDateProperty.GetValue(validationContext.ObjectInstance);

               if ((endDate - startDate).Days >= _maxDays)
               {
                  return new ValidationResult(ErrorMessage);
               }
               return ValidationResult.Success;
            }
         }
         return ValidationResult.Success;
      }
   }
}
