using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace attributes_and_reflection
{
    static class Print
    {
        public static void ColorPrint(object o)
        {
            Type t = o.GetType();
            Type cp = typeof(ColorAttribute);
            Console.WriteLine("Свойства объекта типа " + t);
            foreach (PropertyInfo p in t.GetProperties())
            {                
                
                if (Attribute.IsDefined(p, typeof(ColorAttribute)))
                {
                    ColorAttribute attributeValue = (ColorAttribute)Attribute.GetCustomAttribute(p, typeof(ColorAttribute));
                    switch (attributeValue.Color)
                    {
                        case Colors.red:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case Colors.white:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case Colors.blue:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case Colors.green:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.GetValue(o, null));
                    //Console.WriteLine(attributeValue.Color)
                }
                else
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.GetValue(o, null));
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            
        }
    }


         



}
