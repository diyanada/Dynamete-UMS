using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class Username : Components
    {
        public Username(String Input) : base() 
        {
            new IsRequired(Input);

            IsAlphaNumeric Validation = new IsAlphaNumeric(Input);

            this.Contains = Validation.Output;
        }
    }
}
