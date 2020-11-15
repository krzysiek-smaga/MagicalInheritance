using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    class Pupil
    {
        // Properties
        public string Title
        { get; private set; }

        // Constructor
        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm stormObject = new Storm("wind", false, Title);
            return stormObject;
        }

    }
}
