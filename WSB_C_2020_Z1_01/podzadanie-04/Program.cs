using System;

namespace podzadanie_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            float x=0, y, score=0;
            int round = 1;
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");
            Console.WriteLine("x - koniec");
            Console.Write("Wybierz działanie: ");
            choose = Console.ReadLine();
            

            do
            {
                
                if (round == 1) {
                    Console.Write("Podaj pierwszą liczbę: ");
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    y = Convert.ToSingle(Console.ReadLine());
                    round++;
                }
                else
                {
                    Console.Write("Wybierz kolejne działanie: ");
                    choose = Console.ReadLine();
                    if(choose == "x")
                    {
                        Console.WriteLine("Twój wynik to: " + score);
                        return;
                    }
                    Console.Write("Podaj kolejną liczbę: ");
                    y = Convert.ToSingle(Console.ReadLine());
                }
                
                switch (choose)
                {
                    case "1":
                        score = x + y;
                        x = score;
                        break;
                    case "2":
                        score = x - y;
                        x = score;
                        break;
                    case "3":
                        score = x * y;
                        x = score;
                        break;
                    case "4":
                        if (y == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0!");
                        } else
                        {
                            score = x / y;
                        }
                        
                        x = score;
                        break;
                    case "x":
                        Console.WriteLine("Twój wynik to: " + score);
                        return;
                    default:
                        Console.WriteLine("Błędna akcja");
                        Console.Write("Wybierz kolejne działanie: ");
                        choose = Console.ReadLine();
                        break;
                }


            } while (choose != "x");

        }
    }
}
