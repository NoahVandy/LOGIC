using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //fisrt block of questions
            bool check;
            int val = 35;
            int n = -5;
            Console.WriteLine(check = val + 3 == 38);
            Console.WriteLine(check = val * 3 > 120);
            Console.WriteLine(check = val - 30 < -5 + 10);
            Console.WriteLine(check = n < 0);
            Console.WriteLine(check = val / n + 8 <= 0);
            Console.WriteLine(check = val % 2 != 0);
            Console.WriteLine();

            //second block of questions
            int m = 3;
            int a = 4;
            int b = 5;
            int c = 6;
            char ch = '!';
            Console.WriteLine(check = m > 10);
            Console.WriteLine(check = a % 2 == 0 && b % 2 == 0 && c % 2 == 0);
            Console.WriteLine(check = a % 2 == 0 || b % 2 == 0 || c % 2 == 0);
            Console.WriteLine(check = ch >= '0' && ch <= '9');
            Console.WriteLine();

            //Third block of questions

            bool p = true;
            bool q = false;
            bool r = false;

            Console.WriteLine(!r);
            Console.WriteLine(r && p);
            Console.WriteLine(!(r || q) && p);
            Console.WriteLine((r && !r) || (p && !p));
            Console.WriteLine((p && !q) || (!p && q));
            Console.WriteLine((r || !r) && (p || !p));

        }
    }
}
