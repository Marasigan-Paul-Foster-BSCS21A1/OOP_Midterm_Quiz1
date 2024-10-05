using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TestProject1
{
    [TestClass]
    public class AbstractAndInterfacesTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AbstractShape_Should_Throw_Exception_When_Instantiated()
        {
            // Act & Assert
            Shape shape = new Shape();  // Should throw exception as Shape is abstract
        }

        [TestMethod]
        public void Circle_Should_Override_AbstractMethods_Correctly()
        {
            // Arrange
            Circle circle = new Circle { Radius = 3 };

            // Act
            var area = circle.Area();

            // Assert
            Assert.AreEqual(28.2743, area, 0.0001);
        }

        [TestMethod]
        public void Rectangle_Should_Override_AbstractMethods_Correctly()
        {
            // Arrange
            Rectangle rectangle = new Rectangle { Width = 5, Height = 2 };

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(10, area);
        }
    }
}

