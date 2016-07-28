using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsAlphaSpaces
    {
        private Regex _Regex = new Regex(@"^[a-zA-Z ]+$");

        public Boolean Status { get; private set; }

        private String Input;

        public String Format
        {
            get 
            {
                this.Input.Trim();
                this.Input.ToLower();
                this.Input = Regex.Replace(this.Input, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
                return this.Input;
            }
        }

        public IsAlphaSpaces(String Input)
        {
            this.Status = (this._Regex.IsMatch(Input) || (Input == String.Empty));

            if(this.Status == false)
            {
                throw new ExceptionAlphaSpaces();
            }

            this.Input = Input;
        }

    }
}
