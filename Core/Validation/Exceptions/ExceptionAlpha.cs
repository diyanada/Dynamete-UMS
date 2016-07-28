using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Validation.Exceptions
{
    class ExceptionAlpha : Exception
    {
        public ExceptionAlpha() : base("Cannot include non-alphanumeric characters.") { }
    }
}
