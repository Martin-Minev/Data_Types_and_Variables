using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());

            decimal distanceKm = distanceMeters / 1000.0M;

            Console.WriteLine($"{distanceKm:F2}");
        }
    }
}
