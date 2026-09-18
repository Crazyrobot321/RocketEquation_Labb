namespace RocketEquation.Tests
{
    public class RocketEquationTest
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CalculateFuelRequirement_ShouldReturnCorrectFuel(int mass, int expectedFuel)
        {
            //Arrange
            var sut = new FuelCalculator();
            // Act
            int actualFuel = sut.SumFuelForAllModules(mass);
            // Assert
            Assert.Equal(expectedFuel, actualFuel);
        }
    }
}
