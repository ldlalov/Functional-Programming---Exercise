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
                Predicate<string> StartsWith = name => name.StartsWith(criteria);
                Predicate<string> EndsWith = name => name.EndsWith(criteria);
                Predicate<string> Length = name => name.Length == int.Parse(criteria);

                string[] cmd = input.Split();
                command = cmd[0];
                whatCase = cmd[1];
                criteria = cmd[2];
                switch (command)
                {
                    case "Remove":
                        switch (whatCase)
                        {
                            case "StartsWith":
                                guests.RemoveAll(StartsWith);
                                    break;
                            case "EndsWith":
                                guests.RemoveAll(EndsWith);
                                    break;
                            case "Length":
                                guests.RemoveAll(Length);
                                    break;
                        }
                        break;
                    case "Double":
                        switch (whatCase)
                        {
                            case "StartsWith":
                                for (int i = 0; i < guests.Count; i++)
                                {
                                    if (guests[i].StartsWith(criteria))
                                    {
                                        guests.Insert(i, guests[i]);
                                        i++;
                                    }
                                }
                                break;
                            case "EndsWith":
                                for (int i = 0; i < guests.Count; i++)
                                {
                                    if (guests[i].EndsWith(criteria))
                                    {
                                        guests.Insert(i, guests[i]);
                                        i++;
                                    }
                                }
                                break;
                            case "Length":
                                for (int i = 0; i < guests.Count; i++)
                                {
                                    if (guests[i].Length == int.Parse(criteria))
                                    {
                                        guests.Insert(i, guests[i]);
                                        i++;
                                    }
                                }
                                break;
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
    }
}
