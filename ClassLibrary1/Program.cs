using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz działanie: 1. Dodawanie 2. Odejmowanie 3. Mnożenie 4. Dzielenie");
            string dzialanie = Console.ReadLine();
            Console.WriteLine("Wpisz pierwszą liczbę:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            double b = Convert.ToDouble(Console.ReadLine());
            
            double wynik = 0;
            switch (dzialanie)
            {
                
                case "1":
                    wynik = a + b;
                    break;
                case "2":
                    wynik = a - b;
                    break;
                case "3":
                    wynik = a * b;
                    break;
                case "4":
                    wynik = a / b;
                    break;

            }
            Console.WriteLine($"Wynik = {wynik}");

        }
    }
}
