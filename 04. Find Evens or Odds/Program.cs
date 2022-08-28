using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string type = Console.ReadLine();
            Predicate<int> predicate = Even;
            for (int i = numbers[0]; i <= numbers[1];i++)
            {
                switch (type)
                {
                    case "even":
                        Console.WriteLine(predicate(i));
                        break;
                    case "odd":
                        if (!predicate(i))
                        {
                            Console.Write($"{i} ");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static bool Even(int current)
        {
            if (current %2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
