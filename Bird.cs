using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animals
    {
        public Bird()
        {
            Legs = 2;
            Arms = 0;
            LaysEggs = true;
            Swims = true;
        }

        public bool Fly { get; set; }
        public bool EatsFish { get; set; }
        public bool  HasWings { get; set; }
        public bool HasFeathers { get; set; }

    }
}
