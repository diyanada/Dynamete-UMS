using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class CreatedDate : Components
    {
        public CreatedDate(String Input) : base()
        {
            new IsRequired(Input);

            IsDateTime Validation = new IsDateTime(Input);

            this.Contains = Validation.Output;
        }
    }
}
