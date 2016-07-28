using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class Password : Components
    {
        public Password(String Input) : base() 
        {
            new IsRequired(Input);

            IsPassword Validation = new IsPassword(Input);

            this.Contains = Validation.Output;
        }
    }
}
