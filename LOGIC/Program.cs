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
            int m = 2;
            int a = 4;
            int b = 5;
            int c = 6;
            char ch = '!';
            Console.WriteLine(check = m > 10);
            Console.WriteLine(check = a % 2 == 0 && b % 2 == 0 && c % 2 == 0);
            Console.WriteLine(check = a % 2 == 0 || b % 2 == 0 || c % 2 == 0);
            Console.WriteLine(check = ch >= '0' && ch <= '9');
            Console.WriteLine();

            //thrid block of questions
            int x = 4;
            Console.WriteLine(check = !(m % 2 == 1 && n % 2 == 1));
            Console.WriteLine(check = m < (n + 5));
            Console.WriteLine(check = m % 2 == 0 && n % 2 == 0);
            Console.WriteLine(check = (m % 2 == 0 || x % 2 == 0) && !(m % 2 == 0 && x % 2 == 0));
            Console.WriteLine();





            //fourth block of questions

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
