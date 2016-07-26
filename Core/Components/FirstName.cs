using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class FirstName
    {
        private String _Name;

        public String Name
        {
            get { return this._Name; }
        }

        public FirstName(String Name)
        {
            IsAlpha Validation = new IsAlpha(Name);

            this._Name = Validation.Format;
        }
    }
}
