namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_UsesDefaultDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("Fizz", fizzBuzz.FizzBuzzifyAnInt(3));
            Assert.Equal("Buzz", fizzBuzz.FizzBuzzifyAnInt(5));
            Assert.Equal("FizzBuzz", fizzBuzz.FizzBuzzifyAnInt(15));
            Assert.Equal("1", fizzBuzz.FizzBuzzifyAnInt(1));
        }

        [Fact]
        public void FizzBuzzifyAnInt_UsesCustomDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.SetDictionary(new Dictionary<int, string> { { 2, "Even" }, { 7, "Lucky" } });

            Assert.Equal("Even", fizzBuzz.FizzBuzzifyAnInt(2));
            Assert.Equal("EvenLucky", fizzBuzz.FizzBuzzifyAnInt(14));
            Assert.Equal("1", fizzBuzz.FizzBuzzifyAnInt(1));
        }

        [Fact]
        public void FizzBuzzifyAnInt_ReturnsCorrectResultsForComplexDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.SetDictionary(new Dictionary<int, string> { { 2, "Quack" }, { 5, "Honk" } });

            var result = fizzBuzz.FizzBuzzValuesForRange(1, 10);
            result.Should().Equal(new List<string>
            {
                "1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk"
            });
        }
    }
}
