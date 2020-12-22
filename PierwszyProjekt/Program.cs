using System;

namespace PierwszyProjekt
{

    class Program
    {
         public static void Main()
        {

            bool ifNumber1 = int.TryParse(Console.ReadLine(), out int number1);
            
            if (!ifNumber1)
            {
                Console.WriteLine("You must enter a number!");
                number1 = int.Parse(Console.ReadLine());
            }

            bool ifNumber2 = int.TryParse(Console.ReadLine(), out int number2);

            if (!ifNumber2)
            {
                Console.WriteLine("You must enter a number!");
                number2 = int.Parse(Console.ReadLine());
            }

            static void SubFunction(int number1 , int number2)
            {
                Console.WriteLine("Substraction: " + (number1 - number2));
            }

            static void AddFunction(int number1, int number2)
            {
                Console.WriteLine("Adding: " + (number1 + number2));
            }

            static void MultiFunction(int number1, int number2)
            {
                Console.WriteLine("Multiply: " + (number1 * number2));
            }

            static void DivFunction(int number1, int number2)
            {
                Console.WriteLine("Dividing: " + (number1 / number2));
            }

            SubFunction(number1 , number2);
            AddFunction(number1 , number2);
            MultiFunction(number1 , number2);
            DivFunction(number1 , number2);
          
        }
    }

    
}
