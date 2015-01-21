using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 23;
            string s = Convert.ToString(result, 2).PadLeft(32, '0');
            Console.WriteLine(s);
            //Console.WriteLine(Convert.ToString((result, 2).PadLeft(32, '0')));

        }
    }
}
