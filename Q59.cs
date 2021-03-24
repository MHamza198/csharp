// --------------------------->>(a)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=22/8;
            Console.WriteLine(n);
        }
    }
}*/

// --------------------------->>(b)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=4,b=3,p=8,q=2;
            double n = q/a - p/b;
            Console.WriteLine(n);
        }
    }
}*/
// --------------------------->>(c)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3.3,b=2.7,p=8.7,q=5.4;
            double n = p/b + q/a;
            Console.WriteLine(n);
        }
    }
}*/
// Error
//  Cannot implicitly convert type 'double' to 'int'

// --------------------------->>(d)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=11 +7/4 +98%6*3;
            Console.WriteLine(n);
        }
    }
}*/


// --------------------------->>(e)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=11 / 31 % 8 *5 -12;
            Console.WriteLine(n);
        }
    }
}*/


// --------------------------->>(f)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=8;
            int q=5;
            int n= q*p+3*p*p-(q%3)*p*p*p;
            Console.WriteLine(n);
        }
    }
}*/

// --------------------------->>(i)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double p=5;
            int q=9;
            int n=(q%2)*p+6.0*p*(q%3)+(q%4)*p*p*p;
            Console.WriteLine(n);
        }
    }
}*/

// Error CS0266: Cannot implicitly convert type 'double' to 'int'.

// --------------------------->>(j)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=3,a=6,b=2;
            n*=a+b;
            a--;
            n%=a;
            Console.WriteLine(n);
        }
    }
}*/


// --------------------------->>(k)
using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,n=5;
            ++n;
            a=--n;
            n=n-a;
            Console.WriteLine(n);
        }
    }
}