using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class Counter : Components
    {
        public Counter(int Input) : base()
        {
            new IsRequired(Input.ToString());

            IsNumeric Validation = new IsNumeric(Input.ToString());

            this.Contains = Validation.Output;
        }
    }
}
