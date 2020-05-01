using System;

namespace podzadanie_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę do wyliczenia silni: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Int64 score = 1;
                for(int x=1; x<(number+1); x++)
                {
                    score *= x;
                }
                Console.WriteLine("Wynik dla " + number + "! wynosi: " + score);

            Console.ReadLine();
        }
    }
}
