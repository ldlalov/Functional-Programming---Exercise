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
            List<Filter> filters = new List<Filter>();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] cmd = input.Split(';');
                string addRemove = cmd[0];
                string filterName = cmd[1];
                string criteria = cmd[2];
                Filter filter = new Filter(filterName,criteria);
                switch (addRemove)
                {
                    case "Add filter":
                            filters.Add(filter);
                        break;
                    case "Remove filter":
                        foreach (var filt in filters)
                        {
                            if (filt.Name == filterName && filt.Criteria == criteria)
                            {
                            filters.Remove(filt);
                                break;
                            }
                        }
                        break;
                }

            }
            foreach (var filter in filters)
            {
            guests.RemoveAll(WhatCase(filter));
            }
                Console.WriteLine(String.Join(" ",guests));
        }
        public static Predicate<string> WhatCase(Filter filter)
        {
            switch (filter.Name)
            {
                case "Starts with":
                    Predicate<string> StartsWith = name => name.StartsWith(filter.Criteria);
                    return StartsWith;
                case "Ends with":
                    Predicate<string> EndsWith = name => name.EndsWith(filter.Criteria);
                    return EndsWith;
                case "Length":
                    Predicate<string> Length = name => name.Length == int.Parse(filter.Criteria);
                    return Length;
                case "Contains":
                    Predicate<string> Contains = name => name.Contains(filter.Criteria);
                    return Contains;
                default:
                    return null;
            }
        }
    }
    class Filter
    {
        public string Name { get; set; }
        public string Criteria { get; set; }
        public Filter(string name, string criteria)
        {
            this.Name = name;
            this.Criteria = criteria;
        }
    }
}
