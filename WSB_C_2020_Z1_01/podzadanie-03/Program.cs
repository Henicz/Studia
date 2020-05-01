using System;

namespace podzadanie_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int score = first_number * second_number;
            Console.WriteLine("Wynik " + first_number + "*" + second_number + " wynosi: " + score);

            Console.ReadLine();
        }
    }
}
