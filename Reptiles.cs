using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptiles : Animals
    {
        public Reptiles()
        {
            Legs = 4;
            Arms = 0;
            LaysEggs = true;
            Swims = true;
        }

        public bool HasScales { get; set; }
        public bool HasTail { get; set; }
        public bool ColdBlooded { get; set; }
        public bool ActiveAtNight {get; set; }

    }
}
