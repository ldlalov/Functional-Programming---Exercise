using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> checkName = CheckName;
            foreach (var name in names)
            {
                if (checkName(name,target))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
        static bool CheckName(string name,int target)
        {
            if (name.ToCharArray().Sum(n => n)>= target)
            {
                return true;
            }
            return false;
        }
    }
}
