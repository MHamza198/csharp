﻿using System;

namespace CSharpFundamantals
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            // Referance type
            var person = new Person(){Age=20};
            MakeOld(person);
            Console.WriteLine(person.Age);        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}