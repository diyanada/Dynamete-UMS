using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsPassword : Validation
    {
        const int MinLength = 6;
        const int MaxLength = 15;

        public IsPassword(String Input) : base()
        {
            Regex Regular = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*$");
            ValidationException Error = this.Builder.Build(Errors.AlphaNumeric);
            base.Validate(Input, Regular, Error);

            Error = this.Builder.Build(Errors.PasswordMin);
            base.Validate(RelationalOperators.LessThan, Input.Length, MinLength, Error);

            Error = this.Builder.Build(Errors.PasswordMax);
            base.Validate(RelationalOperators.GreaterThan, Input.Length, MaxLength, Error);

            Regular = new Regex(@"[a-z]");
            Error = this.Builder.Build(Errors.OneLower);
            base.Validate(Input, Regular, Error);

            Regular = new Regex(@"[a-z]");
            Error = this.Builder.Build(Errors.OneNumber);
            base.Validate(Input, Regular, Error);

            Regular = new Regex(@"[A-Z]");
            Error = this.Builder.Build(Errors.OneUpper);
            base.Validate(Input, Regular, Error);
        }

    }
}
