namespace FizzBuzzLib.Tests
{
    using System.Collections.Generic;
    using Xunit;

    public class FlexiFizzBuzzTests
    {
        [Fact]
        public void ReplacementPairs_ReturnsDefaultDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            var expected = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } };
            Assert.Equal(expected, fizzBuzz.ReplacementPairs);
        }

        [Fact]
        public void SetDictionary_UpdatesReplacementPairs()
        {
            var fizzBuzz = new FizzBuzz();
            var customDictionary = new Dictionary<int, string> { { 2, "Even" }, { 4, "Quad" } };

            fizzBuzz.SetDictionary(customDictionary);

            Assert.Equal(customDictionary, fizzBuzz.ReplacementPairs);
        }

        [Fact]
        public void FizzBuzzifyAnInt_UsesCustomDictionary()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.SetDictionary(new Dictionary<int, string> { { 2, "Even" }, { 7, "Lucky" } });

            Assert.Equal("EvenLucky", fizzBuzz.FizzBuzzifyAnInt(14));
            Assert.Equal("Even", fizzBuzz.FizzBuzzifyAnInt(2));
            Assert.Equal("1", fizzBuzz.FizzBuzzifyAnInt(1));
        }
    }
}
