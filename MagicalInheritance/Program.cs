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


            Console.ReadLine();
        }
    }
}
