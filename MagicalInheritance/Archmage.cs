using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        // Constructor
        public Archmage(string title) : base(title)
        { }

        // Methods
        public override Storm CastRainStorm()
        {
            Storm castRainStorm = new Storm("rain", true, Title);
            return castRainStorm;
        }

        public Storm CastLightingStorm()
        {
            Storm castRainStorm = new Storm("lightning", true, Title);
            return castRainStorm;
        }
    }
}
