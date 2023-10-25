#nullable disable

using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class DateEndGreaterThanDateBeginAttribute : ValidationAttribute
{
    public override string FormatErrorMessage(string name)
    {
        return "Date End must be greater than Date Begin.";
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var dateBeginProperty = validationContext.ObjectType.GetProperty("DateBegin");
        var dateBeginValue = (DateTime?)dateBeginProperty?.GetValue(validationContext.ObjectInstance, null);
        var dateEndValue = (DateTime?)value;

        if (dateBeginValue.HasValue && dateEndValue.HasValue && dateEndValue <= dateBeginValue)
        {
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        return ValidationResult.Success;
    }
}