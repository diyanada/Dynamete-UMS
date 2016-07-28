using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Components;

namespace Core.Credentials
{
    public class Credentials
    {
        private Username username;
        private Password password;
        private Counter counter;
        private LastLogin lastlogin;
        private SecretKey secretkey;
        private IsAdmin isadmin;
        private CreatedDate createddate;

        public String Username
        {
            get
            {
                return this.username.Contains;
            }
            set
            {
                this.username = new Username(value);
            }
        }
    }
}
