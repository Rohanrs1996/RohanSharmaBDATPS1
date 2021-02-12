using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Berlioz");
            names.Add("Borodin");
            names.Add("Brian");
            names.Add("Bartok");
            names.Add("Bellini");
            names.Add("Buxtehude");
            names.Add("Bernstein");
            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}