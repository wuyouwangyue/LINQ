using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 什么是LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 12, 5, 15 };

            var lowNumbers = from n in numbers where n < 10 select n;

            foreach (var number in lowNumbers)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
