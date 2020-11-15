using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        // Constructor
        public Mage(string title) : base(title)
        { }

        // Methods
        public Storm CastRainStorm()
        {
            Storm castRainStorm = new Storm("rain", false, Title);
            return castRainStorm;
        }
    }
}
