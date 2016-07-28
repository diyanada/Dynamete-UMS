using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Components;

namespace Core
{
    public class SystemUser
    {
        private FirstName _FirstName;
        public String FirstName
        {
            get
            {
                return this._FirstName.Name;
            }
            set 
            {
                this._FirstName = new FirstName(value);
            }
        }

        private LastName _LastName;
        public String LastName
        {
            get
            {
                return this._LastName.Name;
            }
            set
            {
                this._LastName = new LastName(value);
            }
        }
    }
}
