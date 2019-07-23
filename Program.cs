using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Fizz Buzz Evaluation Results*************");
            DisplayFizzBuzzEvaluationResult();
        }


        private static void DisplayFizzBuzzEvaluationResult()
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService();

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzService.GetFizzBuzzEvaluation(i));
            }
        }
    }
}
