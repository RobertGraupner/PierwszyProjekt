using System;

namespace PierwszyProjekt
{

    class Program
    {
        public static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Odejmowanie: " + (number1 - number2));
            Console.WriteLine("Dodawanie: " + (number1 + number2));
            Console.WriteLine("Mnożenie: " + (number1 * number2));
            Console.WriteLine("Dzielenie: " + (number1 / number2));
        }
    }
    
}
