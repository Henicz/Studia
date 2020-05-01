using System;

namespace podzadanie_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 12, 20 };

            foreach(int number in numbers)
            {
                Int64 score = 1;
                for(int x=1; x<(number+1); x++)
                {
                    score *= x;
                }
                Console.WriteLine("Wynik dla " + number + "! wynosi: " + score);
            }
            Console.ReadLine();
        }
    }
}
