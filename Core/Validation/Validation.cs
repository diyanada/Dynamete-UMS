using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Core.Validation.Exceptions;

namespace Core.Validation
{
    class Validation
    {
        public Boolean Status { get; protected set; }

        public String Input { get; protected set; }

        protected ExceptionBuilder Builder
        {
            get;
            private set;
        } 

        public virtual String Output
        {
            get
            {
                return this.OutputTrim;
            }
        }

        protected String OutputTrim
        {
            get 
            {
                this.Input.Trim();
                return this.Input;
            }
        }

        public Validation()
        {
            this.Builder = new ExceptionBuilder();
        }

        protected void Validate(String Input, Regex Regular, ValidationException Error)
        {
            this.Input = String.Empty;

            this.Status = (Regular.IsMatch(Input) || (Input == String.Empty));

            if (this.Status == false)
            {
                throw Error;
            }

            this.Input = Input;
        }

        protected void Validate(String Input, ValidationException Error)
        {
            this.Input = String.Empty;

            this.Status = String.IsNullOrEmpty(Input);

            if (this.Status == true)
            {
                throw Error;
            }

            this.Input = Input;
        }

        protected void Validate(RelationalOperators Operator, int NumberOne, int NumberTwo, Exception Error)
        {
            switch (Operator)
            {
                case RelationalOperators.Equal:
                    if (NumberOne == NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                case RelationalOperators.NotEqual:
                    if (NumberOne != NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                case RelationalOperators.GreaterThan:
                    if (NumberOne > NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                case RelationalOperators.GreaterThanEqual:
                    if (NumberOne >= NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                case RelationalOperators.LessThan:
                    if (NumberOne < NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                case RelationalOperators.LessThanEqual:
                    if (NumberOne <= NumberTwo)
                    {
                        throw Error;
                    }
                    break;

                default:
                    { 
                        throw this.Builder.Build(Errors.Operator);
                    }
            }
        }
    }
}
