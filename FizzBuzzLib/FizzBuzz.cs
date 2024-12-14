using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {
        // returns "Fizz" if divisible by 3, "Buzz" if divisible by 5,
        // "FizzBuzz" if divisible by both; otherwise, the number as a string
        public string FizzBuzzifyAnInt(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)
                return "Fizz";
            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }

        // returns FizzBuzz results for all numbers in a range
        // throws error if start or end is negative, or if end < start
        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            if (start < 0 || end < 0)
                throw new ArgumentException("Start and end cannot be negative.");
            if (end < start)
                throw new ArgumentException("End cannot be less than start.");

            var results = new List<string>();

            for (int i = start; i <= end; i++)
            {
                results.Add(FizzBuzzifyAnInt(i));
            }

            return results;
        }
    }
}
