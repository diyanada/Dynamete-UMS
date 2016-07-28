using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class SecretKey : Components
    {
        public SecretKey(String Input)
            : base()
        {
            new IsRequired(Input);

            IsAlpha Validation = new IsAlpha(Input);

            this.Contains = Validation.Output;
        }
    }
}
