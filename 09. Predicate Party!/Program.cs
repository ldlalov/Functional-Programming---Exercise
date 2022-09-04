using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            List<Predicate<string>> predicates = new List<Predicate<string>>();
            string input;
            string criteria= "";
            string command = "";
            string whatCase = "";
            while ((input = Console.ReadLine()) != "Party!")
            {
                //Predicate<string> StartsWith = name => name.StartsWith(criteria);
                //Predicate<string> EndsWith = name => name.EndsWith(criteria);
                //Predicate<string> Length = name => name.Length == int.Parse(criteria);

                string[] cmd = input.Split();
                command = cmd[0];
                whatCase = cmd[1];
                criteria = cmd[2];
                switch (command)
                {
                    case "Remove":
                        guests.RemoveAll(WhatCase(cmd));
                        break;
                    case "Double":
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests.FindIndex(i,WhatCase(cmd)) != -1)
                            {
                                i = guests.FindIndex(i, WhatCase(cmd));
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                        break;
                }
            }
            if (guests.Count>0)
            {
            Console.WriteLine($"{String.Join(", ",guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        public static Predicate<string> WhatCase(string[] cmd)
        {
            string criteria = cmd[2];
            switch (cmd[1])
            {
                case "StartsWith":
                    Predicate<string> StartsWith = name => name.StartsWith(criteria);
                    return StartsWith;
                case "EndsWith":
                    Predicate<string> EndsWith = name => name.EndsWith(criteria);
                    return EndsWith;
                case "Length":
                    Predicate<string> Length = name => name.Length == int.Parse(criteria);
                    return Length;
                default:
                    return null;
            }
        }
    }
}
