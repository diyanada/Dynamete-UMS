using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Components
{
    public class Components
    {
        public Boolean IsAbsent { get; private set; }
        private String Value;

        public String Contains 
        {
            get
            {
                if (this.IsAbsent)
                {
                    throw new ComponentsException();
                }

                return this.Value;
            }
            set
            {
                this.IsAbsent = false;
                this.Value = value;
            }

        }

        public Components()
        {
            this.IsAbsent = true;
        }
    }
}
