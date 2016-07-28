using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class IsAdmin : Components
    {
        public IsAdmin(Boolean Input) : base()
        {
            IsRequired Validation = new IsRequired(Input.ToString());

            this.Contains = Validation.Output;
        }
    }
}
