using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsNumeric : Validation
    {

        public IsNumeric(String Input) : base()
        {
            Regex Regular = new Regex(@"^[0-9]*$");
            ValidationException Error = this.Builder.Build(Errors.Numeric);

            base.Validate(Input, Regular, Error);
        }

    }
}
