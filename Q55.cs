// using System;

// namespace ArithmeticOperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a=3,b=4;
//             // ++a*=b++;  -->> This line gererate Error ----->>>(The left-hand side of an assignment must be a variable, property or indexer)
//             ++a;
//             a*=b++;
//             Console.WriteLine(a);
//         }
//     }
// }

// using System;

// namespace ArithmeticOperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a=3,b=4;
//             // ++a*=++b;  -->> This line gererate Error ----->>>(The left-hand side of an assignment must be a variable, property or indexer)
//             ++a;
//             a*=++b;
//             Console.WriteLine(a);
//         }
//     }
// }
using System;

namespace ArithmeticOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3,b=4;
            // ++a*=++b;  -->> This line gererate Error ----->>>(The left-hand side of an assignment must be a variable, property or indexer)
            //    ++a*=++b;  -->> (We can rewrite this statement as, )
               b=b+1;
               a=a+1;
               a=a*b;
            Console.WriteLine(a);
        }
    }
}