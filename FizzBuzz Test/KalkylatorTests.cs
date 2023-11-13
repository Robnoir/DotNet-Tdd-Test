using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
            [DataRow(3, "Fizz")]
            [DataRow(5, "Buzz")]
            [DataRow(15, "FizzBuzz")]
            [DataRow(2,"2")]


        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException(int nummer,string expected)
        {
            // Arrange
        
            
            // Act
            string TestResult = Kalkylator.FizzBuzzKalkyl(nummer);

            // Asert
            Assert.AreEqual(expected, TestResult);
        }
    }

}
