using System;

namespace podzadanie_03
{
    public class Kalkulator
    {
        public float first_number;
        public float second_number;
        public int variant;
        public float Dodawanie()
        {
            return first_number + second_number;
        }
        public float Odejmowanie()
        {
            return first_number - second_number;
        }
        public float Mnozenie()
        {
            return first_number * second_number;
        }
        public float Dzielenie()
        {
            return first_number / second_number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");

            Kalkulator Dzialanie1 = new Kalkulator();
            

            Console.Write("Podaj pierwszą liczbę: ");
            Dzialanie1.first_number = Convert.ToSingle(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            Dzialanie1.second_number = Convert.ToSingle(Console.ReadLine());

            Console.Write("Wybierz działanie: ");
            Dzialanie1.variant = Convert.ToInt32(Console.ReadLine());

            switch (Dzialanie1.variant)
            {
                case 1:
                    
                    Console.WriteLine(Dzialanie1.first_number + " + " + Dzialanie1.second_number + " = " + Dzialanie1.Dodawanie());
                    break;
                case 2:
                    Console.WriteLine(Dzialanie1.first_number + " - " + Dzialanie1.second_number + " = " + Dzialanie1.Odejmowanie());
                    break;
                case 3:
                    Console.WriteLine(Dzialanie1.first_number + " * " + Dzialanie1.second_number + " = " + Dzialanie1.Mnozenie());
                    break;
                case 4:
                    if(Dzialanie1.second_number == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    else
                    {
                        Console.WriteLine(Dzialanie1.first_number + " / " + Dzialanie1.second_number + " = " + Dzialanie1.Dzielenie());
                    }
                    break;
                default:
                    Console.WriteLine("Brak wybranej opcji");
                    break;
            } 
            Console.ReadKey();
        }
    }
}
