using System;

namespace podzadanie_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            int choose = Convert.ToInt32(Console.ReadLine());
            int first_number, second_number, score;

            if (choose == 1)
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                first_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę: ");
                second_number = Convert.ToInt32(Console.ReadLine());
                score = first_number + second_number;
                Console.WriteLine("Wynik " + first_number + " + " + second_number + " = " + score);
            }
            else if (choose == 2)
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                first_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę: ");
                second_number = Convert.ToInt32(Console.ReadLine());
                score = first_number - second_number;
                Console.WriteLine("Wynik " + first_number + " - " + second_number + " = " + score);
            }
            else
            {
                Console.WriteLine("Nieobsługiwane");
            }         
           

            

            Console.ReadLine();
        }
    }
}
