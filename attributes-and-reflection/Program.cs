using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_and_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Oleg", "ol458");
            House h = new House("Klochki", 60);
            Print.ColorPrint(u);
            Print.ColorPrint(h);

        }
    }
}
