using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Supercalifragilisticexpialidocious";
            var word = "ice";
            if (text.Contains(word))
            {
                Console.WriteLine($"The text contains the {word} word");
            }
            else
            {
                Console.WriteLine($"The text does not contain the {word} word");
            }
        }
    }
}