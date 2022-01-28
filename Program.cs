using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Fizz Buzz Evaluation Results*************");
            Console.WriteLine("Fizz Buzz modeled in an abstracted manner more closely aligned with OOP practices...");
            DisplayFizzBuzzEvaluationResult();
            Console.WriteLine("Fizz Buzz modeled in a single method in an inline-procedural manner");
            FizzBuzz();
        }


        private static void DisplayFizzBuzzEvaluationResult()
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService();

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzService.GetFizzBuzzEvaluation(i));
            }
        }

        private static void FizzBuzz()
        {
            const byte None = 0;
            const byte DivByThree = 1;
            const byte DivByFive = 2;
            const byte DivByThreeAndFive = 3;

            Console.WriteLine("FizzBuzz Evaluation For Numbers Divisible by 3, 5, and 3 and 5......");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(getFizzBuzzEvaluation(i));
            }

            string getFizzBuzzEvaluation(int fizzBuzzInput)
                => translateFizzBuzzMatchResult(evaluateInput(fizzBuzzInput), fizzBuzzInput);

            string translateFizzBuzzMatchResult(byte inputEvalResult, int fizzBuzzInput)
            {
                const string FIZZ = "Fizz";
                const string BUZZ = "Buzz";
                string result = string.Empty;

                if (inputEvalResult == DivByThree)
                {
                    result = FIZZ;
                }
                else if (inputEvalResult == DivByFive)
                {
                    result = BUZZ;
                }
                else if (inputEvalResult == DivByThreeAndFive)
                {
                    result = $"{FIZZ} {BUZZ}";
                }
                else if (inputEvalResult == None)
                {
                    result = fizzBuzzInput.ToString();
                }

                return $"InputValue: {fizzBuzzInput} FizzBuzzResult: {result}";
            }

            byte evaluateInput(int input)
            {
                byte inputEvalResult = 0;

                if (input % 3 == 0)
                {
                    inputEvalResult |= DivByThree;
                }

                if (input % 5 == 0)
                {

                    inputEvalResult |= DivByFive;
                }

                return inputEvalResult;
            }
        }
    }
}
