﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Class
{
    public class Jacket : Wear
    {
        public Jacket(IHuman human) : base(human)
        {
        }

        public override void PutOn()
        {
            human?.PutOn();
            Console.WriteLine("The person wears a jacket.");
            
        }
    }
}
