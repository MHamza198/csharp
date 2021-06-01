using System;

namespace CSharpFundametals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 2;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express"; //Answer will be true But if we assign any value that is not in Enum answer will False. 
            ShippingMethod getParse; 
            bool checkParse = Enum.TryParse (methodName, out getParse);
    	    Console.WriteLine(checkParse);
        }
    }
}