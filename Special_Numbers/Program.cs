using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digitSum = 0;
                bool isSpecial;
                int digit = i;

                while (digit > 0)
                {
                    digitSum += digit % 10;
                    digit /= 10;
                }

                isSpecial = (digitSum == 5 || digitSum == 7 || digitSum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
