using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Components;

namespace Core
{
    public class SystemUser
    {
        private Firstname _Firstname;
        public String Firstname
        {
            get
            {
                return this._Firstname.Contains;
            }
            set 
            {
                this._Firstname = new Firstname(value);
            }
        }

        private Lastname _Lastname;
        public String Lastname
        {
            get
            {
                return this._Lastname.Contains;
            }
            set
            {
                this._Lastname = new Lastname(value);
            }
        }
    }
}
