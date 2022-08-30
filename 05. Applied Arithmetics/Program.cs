using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunk = (x) => x + 1;
            Func<int, int> multiplyFunk = (x) => x * 2;
            Func<int, int> subtractFunk = (x) => x - 1;
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(addFunk).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiplyFunk).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractFunk).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(String.Join(' ', numbers));
                        break;
                }
            }
        }
    }
}
