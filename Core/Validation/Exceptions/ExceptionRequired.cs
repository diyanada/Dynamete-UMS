using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Validation.Exceptions
{
    class ExceptionRequired : Exception
    {
        public ExceptionRequired() : base("Cannot be empty.") { }
    }
}
