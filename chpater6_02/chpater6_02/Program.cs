using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace chpater6_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            Class1 cal = new Class1();
            string c = cal.removeChars("Battle of the Vowels: Hawaii vs. Grozny", "aeiou");
            Console.WriteLine(c);

    }
    }
}