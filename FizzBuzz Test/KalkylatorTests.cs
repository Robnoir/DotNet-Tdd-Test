using FizzBuzz;
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
        [DataRow(2, "2")]
        public void FizzBuzzKalkyl_SkaReturneraKorrektResultat(int nummer, string förväntatResultat)
        {
            // Act
            string resultat = Kalkylator.FizzBuzzKalkyl(nummer);

            // Assert
            Assert.AreEqual(förväntatResultat, resultat);
        }

        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(2, "2")]
        public void SkrivUtFizzBuzz_SkaSkrivaUtKorrektResultat(int testNummer, string förväntatResultat)
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Kalkylator.SkrivUtFizzBuzz(testNummer);

            // Assert
            Assert.AreEqual(förväntatResultat, stringWriter.ToString().Trim(), $"Förväntat resultat för {testNummer}: '{förväntatResultat}'");
        }


        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(2, "2")]
        public void HanteraOchSkrivUtAnvändarInput_NummerInput_SkrivUtRättResultat(int testNummer, string förväntatResultat)
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringReader = new StringReader(testNummer.ToString());
            Console.SetIn(stringReader);

            // Act
            Kalkylator.HanteraOchSkrivUtAnvändarInput();

            // Assert
            string actualOutput = stringWriter.ToString().Trim();
            int index = actualOutput.IndexOf(förväntatResultat);
            if (index >= 0)
            {
                actualOutput = actualOutput.Substring(index);
            }
            Assert.AreEqual(förväntatResultat, actualOutput, $"Förväntat resultat: '{förväntatResultat}', faktiskt resultat: '{actualOutput}'");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HanteraOchSkrivUtAnvändarInput_OgiltigInput_KastarArgumentException()
        {
            // Arrange
            var stringReader = new StringReader("ogiltig_input");
            Console.SetIn(stringReader);

            // Act och Assert
            Kalkylator.HanteraOchSkrivUtAnvändarInput();
        }

    }
}
