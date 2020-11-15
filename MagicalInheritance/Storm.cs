using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    class Storm
    {
        // Properties
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster
        { get; private set; }

        // Constructor
        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        // Methods
        public string Announce()
        {
            if (this.IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }
            return $"{Caster} cast a weak {Essence} storm!";
        }

    }
}
