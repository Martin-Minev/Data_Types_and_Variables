using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            bool isSpecial = false;
            for (int ch = 1; ch <= count; ch++)
            {
                int sum = 0;
                int current = 0;
                current = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", current, isSpecial);
                sum = 0;
                ch = current;
            }
        }
    }
}
