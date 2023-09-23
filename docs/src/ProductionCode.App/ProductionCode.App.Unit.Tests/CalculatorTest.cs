namespace ProductionCode.App.Unit.Tests
{
    public class CalculatorTest : IDisposable
    {
        Calculator _sut;
        public CalculatorTest()
        {
            _sut = new Calculator();
        }

        public void Dispose()
        {
            // for Integration test
            // todo clean-up test fixture. clean DB, Files, call DELETE or Compensate API
            _sut.CleanUp();
        }

        [Fact]
        public void Sum_of_two_numbers()
        {
            double first = 10;
            double second = 20;
            double expectedResult = 30;

            double result = _sut.Sum(first, second);

            Assert.Equal(expectedResult, result);
        }

    }
}