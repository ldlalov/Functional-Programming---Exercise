using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Predicate<string> maxLength = name => name.Length > length;
            names.RemoveAll(maxLength);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
