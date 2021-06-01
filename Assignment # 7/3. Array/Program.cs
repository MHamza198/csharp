using System;

namespace CSharpFundametals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int [5];
            number[0]=1;
            number[1]=4;
            number[2]=5;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);

            var flag = new bool [5];
            flag[0]=true;
            flag[1]=true;
            flag[2]=false;
            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);
            Console.WriteLine(flag[3]);
            Console.WriteLine(flag[4]);
            var name = new string[5] {"Hamza", "Malik", "Ertugrul", "Danish", "Raiz"};
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);
            Console.WriteLine(name[4]);
        }
    }
}
