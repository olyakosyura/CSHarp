using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Input string: ");
            s = Console.ReadLine();
            string a, b;
            Console.Write("Input first symbol: ");
            a = Console.ReadLine();
            Console.Write("Input second symbol: ");
            b = Console.ReadLine();
            int acount, bcount, i, l;
            l = s.Length;
            acount = 0;
            bcount = 0;
            for (i = 0; i<l; i++)
            {
                if (s[i] == a[0]){acount++;}
                if (s[i] == b[0]){bcount++;}
            
            }

            Console.WriteLine(a+'='+(acount.ToString()));
            Console.WriteLine(b+'='+(bcount.ToString()));
            Console.ReadKey();
        }
    }
}
