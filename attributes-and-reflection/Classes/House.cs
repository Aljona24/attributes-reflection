using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_and_reflection
{
    class House
    {
        public House(string street, int area)
        {
            Street = street;
            Area = area;
        }
        [Color(Colors.blue)]
        public string Street { get; set; }
        [Color(Colors.green)]
        public int Area { get; set; }

    }
}
