using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class LastName
    {
        private String _Name = null;

        public String Name
        {
            get { return this._Name; }
        }

        public LastName(String Name)
        {
            new IsRequired(Name);

            IsAlphaSpaces Validation = new IsAlphaSpaces(Name);

            this._Name = Validation.Format;
        }
    }
}
