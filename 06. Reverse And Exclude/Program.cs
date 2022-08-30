using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> canDivide = x => x % divider == 0;
            numbers.RemoveAll(canDivide);
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
