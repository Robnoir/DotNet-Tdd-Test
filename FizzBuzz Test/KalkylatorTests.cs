using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        {
            // Arrange
            int randomNummer = 3;

            // Act
           string TestResult = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Asert
            Assert.AreEqual("Fizz",TestResult);            
        }
    }
}