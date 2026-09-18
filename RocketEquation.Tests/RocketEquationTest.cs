namespace RocketEquation.Tests
{
    public class RocketEquationTest
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void FuelForMass_ReturnsExpectedFuel(int mass, int expectedFuel)
        {
            //Arrange
            var sut = new FuelCalculator();
            // Act
            int actualFuel = sut.FuelForMass(mass);
            // Assert
            Assert.Equal(expectedFuel, actualFuel);
        }
        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void TotalFuelForMass_ReturnsExpectedTotal(int mass, int expected)
        {
            // Arrange
            var sut = new FuelCalculator();

            // Act
            var result = sut.TotalFuelForMass(mass);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void SumTotalFuelForAllModules_ReturnsExpectedResult()
        {
            // Arrange
            var sut = new FuelCalculator();
            var masses = new[] { 14, 1969, 100756 };
            int expected = 51314;
            // Act
            var result = sut.SumTotalFuelForAllModules(masses);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
