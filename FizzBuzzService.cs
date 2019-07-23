using System;

namespace FizzBuzzApp
{
    public sealed class FizzBuzzService
    {
        public string GetFizzBuzzEvaluation(int input)
        {
            return TranslateFizzBuzzMatchResult(EvaluateInput(input), input);
        }

        private string TranslateFizzBuzzMatchResult(FizzBuzzMatch fizzBuzzMatchResult, int input)
        {
            const string FIZZ = "Fizz";
            const string BUZZ = "Buzz";
            string result = string.Empty;

            if (fizzBuzzMatchResult == FizzBuzzMatch.DivByThree)
            {
                result = FIZZ;
            }
            else if (fizzBuzzMatchResult == FizzBuzzMatch.DivByFive)
            {
                result = BUZZ;
            }
            else if(fizzBuzzMatchResult == FizzBuzzMatch.DivByThreeAndFive)
            {
                result = string.Format("{0} {1}", FIZZ, BUZZ);
            }
            else if(fizzBuzzMatchResult == FizzBuzzMatch.None)
            {
                result = input.ToString();
            }

            return result;
        }       

        private FizzBuzzMatch EvaluateInput(int input)
        {
            FizzBuzzMatch fizzBuzzMatchResult = FizzBuzzMatch.None;            

            if (input % 3 == 0)
            {
                fizzBuzzMatchResult |= FizzBuzzMatch.DivByThree;                
            }

            if (input % 5 == 0)
            {
               
                fizzBuzzMatchResult |= FizzBuzzMatch.DivByFive;
            }

            return fizzBuzzMatchResult;
        }
    }

    [Flags()]
    public enum FizzBuzzMatch : byte
    {
        None = 0,
        DivByThree = 1,
        DivByFive = 2,    
        DivByThreeAndFive = 3
    }
}
