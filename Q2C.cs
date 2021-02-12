using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, Bababadalgharaghtakamminarronnkonn";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}