namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzValuesForRange
    {
        [Fact]
        public void FizzBuzzValuesForRange_ReturnsCorrectResults()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzValuesForRange(1, 5).ToList();
            Assert.Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz" }, result);
        }

        [Fact]
        public void FizzBuzzValuesForRange_ThrowsOnNegativeStartOrEnd()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<ArgumentException>(() => fizzBuzz.FizzBuzzValuesForRange(-1, 10));
        }

        [Fact]
        public void FizzBuzzValuesForRange_ThrowsWhenEndIsLessThanStart()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<ArgumentException>(() => fizzBuzz.FizzBuzzValuesForRange(10, 5));
        }

    }
}
