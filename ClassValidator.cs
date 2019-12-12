using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ClassValidator
{
    public ClassValidator(object objectToValidate)
    {
        objectBeingValidated = objectToValidate;
    }

    private static object objectBeingValidated { get; set; }

    public List<ValidationResult> ValidationErrors { get; private set; }

    public bool IsValid()
    {
        if (objectBeingValidated != null)
        {
            ValidationErrors = new List<ValidationResult>();
            var context = new ValidationContext(objectBeingValidated, 
                null, 
                null);

            bool isValid = Validator.TryValidateObject(objectBeingValidated, 
                context, 
                ValidationErrors,true);

            if (!isValid)
            {
                return false;
            }
            return true;
        }
        return false;
    }
}