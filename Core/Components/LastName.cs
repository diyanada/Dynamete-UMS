﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Validation;

namespace Core.Components
{
    public class Lastname : Components
    {
        public Lastname(String Input) : base()
        {
            new IsRequired(Input);

            IsAlphaSpaces Validation = new IsAlphaSpaces(Input);

            this.Contains = Validation.Output;
        }
    }
}
