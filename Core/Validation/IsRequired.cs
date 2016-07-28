using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class IsRequired
    {
        public Boolean Status { get; private set; }

        private String Input;

        public String Format
        {
            get
            {
                this.Input.Trim();
                return this.Input;
            }
        }

        public IsRequired(String Input)
        {
            this.Status = ! String.IsNullOrEmpty(Input);

            if(this.Status == false)
            {
                throw new ExceptionRequired();
            }

            this.Input = Input;
        }
    }
}
