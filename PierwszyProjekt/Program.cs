using System;

namespace PierwszyProjekt
{

    class Program
    {
         public static void Main()
        {
            Console.WriteLine("Enter the number of numbers");
            int numberOfNumbers = ReadNumber();
            var readNumbers = ReadManyNumbers(numberOfNumbers);
        

           int sum = 0;

            for (int i = 0; i < readNumbers.Length; i++)
            {
                sum += readNumbers[i];
            }
            Console.WriteLine("Adding: " + sum); 
        }

        private static int [] ReadManyNumbers(int numbersCount)
        {
            int[] readNumbers = new int[numbersCount];

            for(int i =0; i < numbersCount; i++)
            {
                readNumbers[i] = ReadNumber();
            }
            return readNumbers;

          
        }


        private static int ReadNumber()
        {
            bool isNumberEntered = false;
            int number;

            do
            {
                Console.WriteLine("Enter the number");
                isNumberEntered = int.TryParse(Console.ReadLine(), out number);
            }
            while (!isNumberEntered);
            return number;
            
        }


       


        /* static void SubFunction(int number1 , int number2)
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
         DivFunction(number1 , number2);*/

    }
    

    
}
