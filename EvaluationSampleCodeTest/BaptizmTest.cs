using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode; 

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class BaptizmTests
    {
        [TestMethod]
        public void CanBeBaptizedBy_WithPriest_ReturnsTrue()
        {
            // Arrange
            var clergyMember = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(new ClergyMember()); 

            // Act
            var result = baptizm.CanBeBaptizedBy(clergyMember);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithPope_ReturnsTrue()
        {
            // Arrange
            var clergyMember = new ClergyMember { IsPope = true };
            var baptizm = new Baptizm(new ClergyMember()); 

            // Act
            var result = baptizm.CanBeBaptizedBy(clergyMember);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithNonPriestOrPope_ReturnsFalse()
        {
            // Arrange
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(new ClergyMember()); 

            // Act
            var result = baptizm.CanBeBaptizedBy(clergyMember);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithSameClergyMember_ReturnsTrue()
        {
            // Arrange
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);

            // Act
            var result = baptizm.CanBeTeachedBy(clergyMember);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithDifferentClergyMember_ReturnsFalse()
        {
            // Arrange
            var clergyMember = new ClergyMember();
            var anotherClergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);

            // Act
            var result = baptizm.CanBeTeachedBy(anotherClergyMember);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
