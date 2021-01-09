using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = 0.00;

            Console.Write("Length: ");

            Console.Write("Width: ");

            Console.Write("Height: ");

            volume = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
