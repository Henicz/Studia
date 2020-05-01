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
            Console.WriteLine("3 - mnożenie");
            int variant = Convert.ToInt32(Console.ReadLine());
            int first_number, second_number;

            switch (variant)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    first_number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    second_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(first_number + " + " + second_number + " = " + (first_number+second_number));
                    break;
                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    first_number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    second_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(first_number + " - " + second_number + " = " + (first_number-second_number));
                    break;
                case 3:
                    Console.Write("Podaj pierwszą liczbę: ");
                    first_number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    second_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(first_number + " * " + second_number + " = " + (first_number*second_number));
                    break;
                default:
                    Console.WriteLine("Brak wybranej opcji");
                    break;
            } 
           

            

            Console.ReadLine();
        }
    }
}
