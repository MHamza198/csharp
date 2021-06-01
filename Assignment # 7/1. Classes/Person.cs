using System;

namespace CSharpFundametals
{

    public class Person
    {
        public string FirstName;
        public string LastName;
        
        public void Introduce()
         {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
         }
    }
}