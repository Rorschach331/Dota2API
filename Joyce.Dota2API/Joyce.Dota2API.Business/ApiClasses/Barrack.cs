using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2API.Enums;

namespace Dota2API.ApiClasses
{
    public class Barrack
    {
        public BarrackPosition Position { get; set; }
        public bool Alive { get; set; }
    }
}
