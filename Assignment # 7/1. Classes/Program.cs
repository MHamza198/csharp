using System;
using CSharpFundametals.Math;

namespace CSharpFundametals
{
        class Program
    {
        static void Main(string[] args)
        {
            var Hamza = new Person();
            Hamza.FirstName = "Muhammad";
            Hamza.LastName = "Hamza";
            Hamza.Introduce();
            var calculater = new Calculater();
            var result = calculater.Add (1,2);
            Console.WriteLine("The result of Add Method of Calculater class = " + result);
        }
    }
}
