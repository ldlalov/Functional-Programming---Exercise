using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sequence = new List<int>();
            Predicate<int> canDivide = x => dividers.All(y => x % y == 0);
            for (int i = 1; i <= end; i++)
            {
                if (canDivide(i))
                {
                    sequence.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
