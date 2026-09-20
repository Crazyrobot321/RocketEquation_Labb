namespace RocketEquation.Tests
{
    public class RocketEquationTest
    {
        [Test]
        [Arguments(12, 2)]
        [Arguments(14, 2)]
        [Arguments(1969, 654)]
        [Arguments(100756, 33583)]
        public async Task FuelForMass_ReturnsExpectedFuel(int mass, int expectedFuel)
        {
            //Arrange
            var sut = new FuelCalculator();
            // Act
            int actualFuel = sut.FuelForMass(mass);
            // Assert
            await Assert.That(actualFuel).IsEqualTo(expectedFuel);
        }
        [Test]
        [Arguments(14, 2)]
        [Arguments(1969, 966)]
        [Arguments(100756, 50346)]
        public async Task TotalFuelForMass_ReturnsExpectedTotal(int mass, int expected)
        {
            // Arrange
            var sut = new FuelCalculator();

            // Act
            var result = sut.TotalFuelForMass(mass);

            // Assert
            await Assert.That(result).IsEqualTo(expected);
        }
        [Test]
        public async Task SumTotalFuelForAllModules_ReturnsExpectedResult()
        {
            // Arrange
            var sut = new FuelCalculator();
            var masses = new[] { 14, 1969, 100756 };
            int expected = 51314;
            // Act
            var result = sut.SumTotalFuelForAllModules(masses);

            // Assert
            await Assert.That(result).IsEqualTo(expected);
        }
    }
}
