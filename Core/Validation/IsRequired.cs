using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsRequired : Validation
    {
        public IsRequired(String Input)
        {
            ValidationException Error = this.Builder.Build(Errors.Required);

            base.Validate(Input, Error);
        }
    }
}
