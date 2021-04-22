// -------------->>(a)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=20,y=35;
            x=y++ + x++;
            y=++y + ++x;
            Console.WriteLine((x+""+y));
        }
    }
}*/

// -------------->>(b)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10,y=15;
            x=x++;
            y=++y;
            Console.WriteLine((x+" "+y));
        }
    }
}*/

// -------------->>(c)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            x++;
            Console.WriteLine(x);
        }
    }
}*/


// -------------->>(d)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            Console.WriteLine(x++);
        }
    }
}*/

// -------------->>(e)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10;
            int x=0;
            x=n--;
            Console.WriteLine(x);
        }
    }
}*/

// -------------->>(f)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=5,j=6,k=7,n=3;
            Console.WriteLine(i+j*k-k%n);
            Console.WriteLine(i/n);
        }
    }
}*/

// -------------->>(g)
// using System;
/*namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float x=3.8F;
            n=(int)x;
            Console.WriteLine("n = "n);
        }
    }
}*/

// -------------->>(h)
using System;
namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=6;
            Console.Write(a);
            a=a+3;
            Console.Write(a);
            a-=5;
            Console.Write(a);
            a++;
            Console.Write(a);
        }
    }
}
