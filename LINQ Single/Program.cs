using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_SingleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequence contains one element
            List<int> numbers = new List<int>() { 10 };
            int number = numbers.Single();
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
