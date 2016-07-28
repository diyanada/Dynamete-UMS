using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class FirstName
    {
        public String Name {  get; private set; }

        public FirstName(String Name)
        {
            new IsRequired(Name);

            IsAlpha Validation = new IsAlpha(Name);

            this.Name = Validation.Format;
        }
    }
}
