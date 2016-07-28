using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsDateTime : Validation
    {

        public IsDateTime(String Input): base()
        {
            Regex Regular = new Regex(@"\d{2,2}-\d{2,2}-\d{4,4} \d{2,2}:\d{2,2}:\d{2,2}");
            ValidationException Error = this.Builder.Build(Errors.DateTime);

            base.Validate(Input, Regular, Error);
        }

    }
}
