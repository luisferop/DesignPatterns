﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.State
{
    public class NaoVoar : Comportamento
    {
        public override void Exec()
        {
            Console.WriteLine("Esta ave não voa!");
        }
    }
}
