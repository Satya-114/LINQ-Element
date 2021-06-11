using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_DefaultIf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            IEnumerable<int> result = numbers.DefaultIfEmpty();
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
