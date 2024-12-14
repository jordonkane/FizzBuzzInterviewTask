namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // create instance of the FizzBuzz class
            var fizzBuzzer = new FizzBuzz();

            // generate FizzBuzz results for the range 1 to 100
            Console.WriteLine("FizzBuzz Results for Range 1-100:");
            foreach (var result in fizzBuzzer.FizzBuzzValuesForRange(1, 100))
            {
                Console.WriteLine(result);
            }

            // wait for user input before closing
            Console.ReadKey();
        }
    }
}
