using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Validation.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(String Message) : base(Message) { }
    }

    class ExceptionBuilder
    {
        public ValidationException Build(Errors Error)
        {
            String Message = this.ErrorMessage(Error);

            return new ValidationException(Message);
        }

        private String ErrorMessage(Errors Error)
        {
            switch (Error)
            {
                case Errors.Alpha:
                    return "Cannot include non-alphabetic characters.";
                
                case Errors.AlphaNumeric:
                    return "Cannot include non-alphanumeric characters.";

                case Errors.Numeric:
                    return "Cannot include non-numeric characters.";
                
                case Errors.Asterisk:
                    return "*";
                
                case Errors.Operator:
                    return "Invalid operator (internal exception).";
                
                case Errors.Required:
                    return "Cannot include empty.";
                
                case Errors.PasswordMin:
                    return "Cannot include less than 6 characters.";
                
                case Errors.PasswordMax:
                    return "Cannot include more than 15 characters.";

                case Errors.DateTime:
                    return "Cannot include not valid date and time.";
                
                case Errors.OneLower:
                    return "Must contain at least one character";
                
                case Errors.OneNumber:
                    return "must contain at least one numeric character.";
                
                case Errors.OneUpper:
                    return "must contain at least one uppercase character.";
                
                default:
                    return "Invalid Error Name (internal exception).";
            }
        }
    }

    enum Errors
    {
        Alpha,
        AlphaNumeric,
        Numeric,
        Required,
        Operator,
        Asterisk,
        PasswordMin,
        PasswordMax,
        OneNumber,
        OneLower,
        OneUpper,
        DateTime
    }
}
