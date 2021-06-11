using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_ElementAt
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.ElementAt(1);
            Console.WriteLine(MethodSyntax);
            Console.ReadLine();
        }
    }
}
