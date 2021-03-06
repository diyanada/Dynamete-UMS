﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsAlphaSpaces : Validation
    {
        public override String Output
        {
            get 
            {
                this.Input.ToLower();
                this.Input = Regex.Replace(this.Input, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
                return base.OutputTrim;
            }
        }

        public IsAlphaSpaces(String Input) : base()
        {
            Regex Regular = new Regex(@"^[a-zA-Z ]+$");
            ValidationException Error = this.Builder.Build(Errors.Alpha);

            base.Validate(Input, Regular, Error);
        }

    }
}
