using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Validation.Exceptions
{
    class ExceptionAlphaSpaces : Exception
    {
        public ExceptionAlphaSpaces() : base("Cannot include non-alphanumeric characters.") { }
    }
}
