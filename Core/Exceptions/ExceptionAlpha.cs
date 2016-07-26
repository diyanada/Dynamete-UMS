using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Exceptions
{
    class ExceptionAlpha : Exception
    {
        public ExceptionAlpha() : base("Cannot include non-alphanumeric characters.") { }
    }
}
