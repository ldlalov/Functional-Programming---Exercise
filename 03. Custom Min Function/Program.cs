using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> Smalest = SmalestNumber;
            Console.WriteLine(Smalest(integers));
        }
        static int SmalestNumber(int[] integers)
        {
            return integers.Min();
        }
    }
}
