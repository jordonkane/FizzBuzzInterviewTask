namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            [Fact]
            public void FizzBuzzifyAnInt_ReturnsNumberAsString()
            {
                var fizzBuzz = new FizzBuzz();
                Assert.Equal("1", fizzBuzz.FizzBuzzifyAnInt(1));
            }

            [Fact]
            public void FizzBuzzifyAnInt_ReturnsFizzForMultiplesOf3()
            {
                var fizzBuzz = new FizzBuzz();
                Assert.Equal("Fizz", fizzBuzz.FizzBuzzifyAnInt(3));
            }

            [Fact]
            public void FizzBuzzifyAnInt_ReturnsBuzzForMultiplesOf5()
            {
                var fizzBuzz = new FizzBuzz();
                Assert.Equal("Buzz", fizzBuzz.FizzBuzzifyAnInt(5));
            }

            [Fact]
            public void FizzBuzzifyAnInt_ReturnsFizzBuzzForMultiplesOf3And5()
            {
                var fizzBuzz = new FizzBuzz();
                Assert.Equal("FizzBuzz", fizzBuzz.FizzBuzzifyAnInt(15));
            }

        }
    }
}
