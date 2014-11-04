using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class HelpExtensions
    {
        public static void Dump(this string p)
        {
            Console.WriteLine(p);
        }
        public static void Dump(this Array a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Dump(this object o)
        {
            Console.WriteLine(o.ToString());
        }
    }
}
