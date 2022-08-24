using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> Print = PrintNames;
            Print(names);
        }
        static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
