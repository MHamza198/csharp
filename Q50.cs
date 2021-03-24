/*------->(a)
using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {    
        static void Main(string[] args)
        {
            int x=1;
            Console.WriteLine("The output is "+ (x*x + 5*x -4));
        }
    }
}*/
//  ----------->(b)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {    
        static void Main(string[] args)
        {
            int x=1;
            int y=2;
            Console.WriteLine("The output is "+ (x+y)*x);
        }
    }
}*/

// ----------->(C)
/*using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {    
        static void Main(string[] args)
        {
            int x=1;
            Console.WriteLine("The output is "+ (1/(x*x + x + 3)) );
        }
    }
}*/
// ----------->(d)
using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {    
        static void Main(string[] args)
        {
            int x=0,y=5,z=4;
            x=(3*y)/(5-z);
            Console.WriteLine("The output is "+ (x));
        }
    }
}