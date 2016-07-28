using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class Firstname : Components
    {
        public Firstname(String Input) : base()
        {
            new IsRequired(Input);

            IsAlpha Validation = new IsAlpha(Input);

            this.Contains = Validation.Output;
        }
    }
}
