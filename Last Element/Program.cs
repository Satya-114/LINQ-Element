﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_LastElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.Last();
            Console.WriteLine(MethodSyntax);
            Console.ReadLine();
        }
    }
}
