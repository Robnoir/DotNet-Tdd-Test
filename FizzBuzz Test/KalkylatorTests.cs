using FizzBuzz;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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

        public void KöraIgenomDataRows(int nummer,string expected)
        {
            // Arrange
            
        
            
            // Act
            string TestResult = Kalkylator.FizzBuzzKalkyl(nummer);

            // Asert
            Assert.AreEqual(expected, TestResult);
        }

        [TestMethod]
        public void GåIgenomLoop()
        {
            // Arrange
            StringBuilder expectedOutput = new StringBuilder();
            for (int i = 1; i <= 15; i++)
            {
                expectedOutput.AppendLine(Kalkylator.FizzBuzzKalkyl(i));
            }
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Kalkylator.KörOchSkrivUtFizzBuzz();

            // Assert
            string actualOutput = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput.ToString().Trim(), actualOutput);

        }

        [TestMethod]
        public void SkrivaUtMeddelandeTillConsol()
        {
            // Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var expectedMessage = "Service AuthService: Det lyckades";

            // Act
            Kalkylator.LogMessage("AuthService", "Det lyckades");

            // Assert
            string actualMessage = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedMessage, actualMessage);

        }

        [TestMethod]
        [DataRow("1", "1")]
        [DataRow("2", "2")]
        [DataRow("3", "Fizz")]
        [DataRow("4", "4")]
        [DataRow("5", "Buzz")]
        [DataRow("6", "Fizz")]
        [DataRow("10", "Buzz")]
        [DataRow("11", "11")]
        [DataRow("15", "FizzBuzz")]
        public void HanteraAnvändarInputGiltigaNummer(string input, string expectedOutput)
        {
            // Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Kalkylator.HanteraAnvändarInput(input);

            // Assert
            string actualOutput = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HanteraAnvändarInputOgiltigInput()
        {
            Kalkylator.HanteraAnvändarInput("inte ett nummer");
        }


    }

}
