using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] cmd = input.Split(';');
                string addRemove = cmd[0];
                string filterName = cmd[1];
                string criteria = cmd[2];
                switch (addRemove)
                {
                    case "Add filter":
                        if (!filters.Contains($"{filterName};{criteria}"))
                        {
                            filters.Add($"{filterName};{criteria}");
                        }
                        break;
                    case "Remove filter":
                        if (filters.Contains($"{filterName};{criteria}"))
                        {
                            filters.Remove($"{filterName};{criteria}");
                        }
                        break;
                }
            }
        }
        public static Predicate<string> WhatCase(string[] cmd)
        {
            string criteria = cmd[2];
            switch (cmd[1])
            {
                case "Starts With":
                    Predicate<string> StartsWith = name => name.StartsWith(criteria);
                    return StartsWith;
                case "Ends With":
                    Predicate<string> EndsWith = name => name.EndsWith(criteria);
                    return EndsWith;
                case "Length":
                    Predicate<string> Length = name => name.Length == int.Parse(criteria);
                    return Length;
                case "Contains":
                    Predicate<string> Contains = name => name.Contains(criteria);
                    return Contains;
                default:
                    return null;
            }
        }
    }
}
