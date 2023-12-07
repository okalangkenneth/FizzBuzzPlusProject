using FizzBuzzPlusProject;

namespace FizzBuzzPlusServiceTests
{
    public class FizzBuzzPlusServiceTests
    {
        private readonly FizzBuzzPlusService _plusFizzBuzzPlusService;

        public FizzBuzzPlusServiceTests()
        {
            _plusFizzBuzzPlusService = new FizzBuzzPlusService();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(13)]
        [InlineData(31)]
        public void Execute_ReturnsFizzForMultiplesOrContainsThree(int number)
        {
            // Act
            var result = _plusFizzBuzzPlusService.Execute(number, number);

            // Assert
            Assert.Equal($"Fizz{Environment.NewLine}", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(52)]
        public void Execute_ReturnsBuzzForMultiplesOrContainsFive(int number)
        {
            // Act
            var result = _plusFizzBuzzPlusService.Execute(number, number);

            // Assert
            Assert.Equal($"Buzz{Environment.NewLine}", result);
        }

        // Additional tests... ?!
    }
}
