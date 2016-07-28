using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Components
{
    public class ComponentsException : Exception
    {
        public ComponentsException() : base("Arguments are not sufficiently instantiated (internal exception)") { }
    }
}
