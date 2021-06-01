using System;

namespace CSharpFundametals
{
    public struct RgbColor
    {
        public int Red;
        public int Green;
        public int Blue;
        public void colorname()
        {
            Console.WriteLine("No of Red = " + Red + ", Green = " + Green + " and Blue = " + Blue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var color = new RgbColor();
            color.Red = 1;
            color.Green = 2;
            color.Blue = 3;
            color.colorname();
        }
    }
}
