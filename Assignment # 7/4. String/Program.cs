using System;
namespace CSharpFundametals
{
    class Program
    {
         static void Main(string[] args)
        {
            var FirstName = "Muhammad";
            var LastName = "Hamza";
            var fullname = FirstName + " " + LastName;
            var myFullName = string.Format("My name is {0} {1}", FirstName , LastName );

            var names = new string [3] {"Malik", "Muhammad", "Hamza"};
            var formattedName = string.Join(", ", names);
            Console.WriteLine(formattedName);

            // var text = "Hi Malik\nLook into the following paths\nc: \\folder1\\foler2\nc: \\folder3\\folder4"; 
            var text = @"Hi Malik
Look into the following paths
nc: \folder1\foler2
nc: \folder3\folder4"; 
            Console.WriteLine(text);


        }
    }
}