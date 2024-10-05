using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;

namespace TestProject1
{
    [TestClass]
    public class MammalHierarchyTests
    {
        [TestMethod]
        public void Mammal_Should_Inherit_Animal_Methods()
        {
            // Arrange
            Mammal mammal = new Mammal();

            // Act
            var eatResult = mammal.Eat();

            // Assert
            Assert.AreEqual("Animal is eating.", eatResult);
        }

        [TestMethod]
        public void Human_Should_Inherit_Mammal_Methods()
        {
            // Arrange
            Human human = new Human();

            // Act
            var talkResult = human.Talk();

            // Assert
            Assert.AreEqual("Human is talking.", talkResult);
        }

        [TestMethod]
        public void Human_Should_Have_MultiLevel_Inheritance()
        {
            // Arrange
            Human human = new Human();

            // Act
            var eatResult = human.Eat();          // Method from Animal
            var birthResult = human.GiveBirth();  // Method from Mammal

            // Assert
            Assert.AreEqual("Animal is eating.", eatResult);
            Assert.AreEqual("Mammal is giving birth.", birthResult);
        }
    }
}
