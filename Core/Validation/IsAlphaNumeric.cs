using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsAlphaNumeric : Validation
    {
        public override String Output
        {
            get 
            {
                this.Input.ToLower();
                this.Input = Regex.Replace(this.Input, @"(^\w)", m => m.Value.ToUpper());
                return base.OutputTrim;
            }
        }

        public IsAlphaNumeric(String Input) : base()
        {
            Regex Regular = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*$");
            ValidationException Error = this.Builder.Build(Errors.AlphaNumeric);

            base.Validate(Input, Regular, Error);
        }

    }
}
