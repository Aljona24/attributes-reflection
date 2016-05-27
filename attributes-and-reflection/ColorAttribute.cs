using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_and_reflection
{

    [AttributeUsage(AttributeTargets.Property)]
    public class ColorAttribute : System.Attribute
    {
        public Colors Color { get; set; }
        //public int Code { get; set; } 
        public ColorAttribute()
        {
        }
        public ColorAttribute(Colors color)
        {
            Color = color;
        }
    }
}
