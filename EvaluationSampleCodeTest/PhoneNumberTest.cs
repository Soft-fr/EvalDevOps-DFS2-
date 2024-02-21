using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        [DataRow("0123456789", "012", "345", "6789")]
        public void Parse_ValidInput_ReturnsPhoneNumberObject(string input, string expectedArea, string expectedMajor, string expectedMinor)
        {
            // Act
            var phoneNumber = PhoneNumber.Parse(input);

            // Assert
            Assert.IsNotNull(phoneNumber);
            Assert.AreEqual(expectedArea, phoneNumber.Area);
            Assert.AreEqual(expectedMajor, phoneNumber.Major);
            Assert.AreEqual(expectedMinor, phoneNumber.Minor);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("123456789")] 
        [DataRow("01234567890")] 
        [ExpectedException(typeof(ArgumentException))]
        public void Parse_InvalidInput_ThrowsArgumentException(string input)
        {
            // Act
            PhoneNumber.Parse(input);
        }

        [TestMethod]
        public void ToString_ValidPhoneNumber_ReturnsFormattedString()
        {
            // Arrange
            var phoneNumber = PhoneNumber.Parse("0123456789");

            // Act
            var result = phoneNumber.ToString();

            // Assert
            Assert.AreEqual("(012)345-6789", result);
        }
    }
}
