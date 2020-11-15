using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm1 = new Storm("wind", false, "Zul'rajas");

            Console.WriteLine(storm1.Announce());

            Pupil pupil1 = new Pupil("Mezil-kree");

            Storm storm2 = pupil1.CastWindStorm();

            Console.WriteLine(storm2.Announce());

            Mage mage1 = new Mage("Gul’dan");

            Storm storm3 = mage1.CastWindStorm();
            Storm storm4 = mage1.CastRainStorm();

            Console.WriteLine(storm3.Announce());
            Console.WriteLine(storm4.Announce());



            Console.ReadLine();
        }
    }
}
