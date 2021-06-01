using System;

namespace CSharpFundametals
{
    class Program
    {
        static void Main(string[] args)
        {
            // By Value Type
           var a = 100;
           var b = a;
           b = 200;
           Console.WriteLine("a = {0}, b = {1}", a,b );  
            //By Reference Type
           var array1 = new int[3] {1,2,3};
           var array2 = array1;
           array1[0]=0;
           Console.WriteLine(string.Format("array1[0] = {0} , array2[0] = {1}", array1[0], array2[0]));
        }
    }
}
