using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        [DataRow(100, 50)]
        [DataRow(1199, 1)]
        public void Subtract_ValidInputs_ReturnsDifference(int numberOne, int numberTwo)
        {
            // Arrange
            var mathOps = new MathOperations();

            // Act
            var result = mathOps.Subtract(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(numberOne - numberTwo, result);
        }

        [TestMethod]
        [DataRow(50, 100)]
        [DataRow(1200, 1)]
        [ExpectedException(typeof(ArgumentException))]
        public void Subtract_InvalidInputs_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            // Arrange
            var mathOps = new MathOperations();

            // Act
            mathOps.Subtract(numberOne, numberTwo);
        }

        [TestMethod]
        [DataRow(2, "Red")]
        [DataRow(1, "Blue")]
        public void GetColorFromOddsNumber_ValidInputs_ReturnsExpectedColor(int number, string expectedColor)
        {
            // Arrange
            var mathOps = new MathOperations();

            // Act
            var result = mathOps.GetColorFromOddsNumber(number);

            // Assert
            Assert.AreEqual(expectedColor, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetColorFromOddsNumber_NegativeInput_ThrowsArgumentException()
        {
            // Arrange
            var mathOps = new MathOperations();

            // Act
            mathOps.GetColorFromOddsNumber(-1);
        }
    }
}
