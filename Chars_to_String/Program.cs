using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            char y = char.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());

            Console.WriteLine($"{x}{y}{z}");
        }
    }
}
