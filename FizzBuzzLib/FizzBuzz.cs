using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {
        // field for ReplacementPairs property
        private Dictionary<int, string> _replacementPairs = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        // property for ReplacementPairs dictionary
        public Dictionary<int, string> ReplacementPairs
        {
            get => _replacementPairs;
            private set => _replacementPairs = value;
        }

        // set a custom dictionary for replacements
        public void SetDictionary(Dictionary<int, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentException("Dictionary cannot be null or empty.");
            }

            ReplacementPairs = dictionary;
        }

        // implements basic fizzvuzz logic using the ReplacementPairs dictionary
        public string FizzBuzzifyAnInt(int input)
        {
            string result = string.Empty;

            foreach (var pair in ReplacementPairs)
            {
                if (input % pair.Key == 0)
                {
                    result += pair.Value;
                }
            }

            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }

        // implement fizzbuzz logic for a range
        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            if (start < 0 || end < 0)
            {
                throw new ArgumentException("Start and end values must be non-negative.");
            }
            if (end < start)
            {
                throw new ArgumentException("End value must not be less than the start value.");
            }

            var results = new List<string>();
            for (int i = start; i <= end; i++)
            {
                results.Add(FizzBuzzifyAnInt(i));
            }

            return results;
        }
    }
}
