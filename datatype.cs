using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        struct Point
        {
            public int X;
            public int Y;
        }

        class Person
        {
            public string Name;
            public int Age;
        }

        static void Main(string[] args)
        {
            int integerNumber = 10;
            double floatingPointNumber = 3.14;
            decimal decimalNumber = 123.456m;
            bool isTrue = true;
            char character = 'A';
            string text = "Hello, World!";
            object obj = new object();
            Days today = Days.Monday;
            Point p;
            p.X = 10;
            p.Y = 20;
            int? nullableInteger = null;
            int[] numbers = { 1, 2, 3, 4, 5 };

            Person person = new Person();
            person.Name = "John";
            person.Age = 30;

            Console.WriteLine($"integerNumber: {integerNumber}");
            Console.WriteLine($"floatingPointNumber: {floatingPointNumber}");
            Console.WriteLine($"decimalNumber: {decimalNumber}");
            Console.WriteLine($"isTrue: {isTrue}");
            Console.WriteLine($"character: {character}");
            Console.WriteLine($"text: {text}");
            Console.WriteLine($"obj: {obj}");
            Console.WriteLine($"today: {today}");
            Console.WriteLine($"p.X: {p.X}, p.Y: {p.Y}");
            Console.WriteLine($"nullableInteger: {nullableInteger}");
            Console.WriteLine($"numbers: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"person.Name: {person.Name}, person.Age: {person.Age}");
        }
    }
}

