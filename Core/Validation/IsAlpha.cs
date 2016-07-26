using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Exceptions;

namespace Core.Validation
{
    class IsAlpha
    {
        private Regex _Regex = new Regex(@"^[a-zA-Z]+$");

        private Boolean _Status = true;
        public Boolean Status
        {
            get { return this._Status; }
        }

        private String Input;

        public String Format
        {
            get 
            {
                this.Input.ToLower();
                this.Input = this.UppercaseFirst(this.Input);

                return this.Input;
            }
        }

        public IsAlpha(String Input)
        {
            this._Status = this._Regex.IsMatch(Input);

            if(this._Status == false)
            {
                throw new ExceptionAlpha();
            }

            this.Input = Input;
        }

        private string UppercaseFirst(String s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
