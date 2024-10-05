using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class AnimalHierarchyTests
    {
        [TestMethod]
        public void Dog_Should_MakeCorrectSound()
        {
            // Arrange
            Dog dog = new Dog();

            // Act
            var sound = dog.MakeSound();

            // Assert
            Assert.AreEqual("Woof!", sound);
        }

        [TestMethod]
        public void Cat_Should_MakeCorrectSound()
        {
            // Arrange
            Cat cat = new Cat();

            // Act
            var sound = cat.MakeSound();

            // Assert
            Assert.AreEqual("Meow!", sound);
        }

        [TestMethod]
        public void Animal_Should_MakeGenericSound()
        {
            // Arrange
            Animal genericAnimal = new Animal();

            // Act
            var sound = genericAnimal.MakeSound();

            // Assert
            Assert.AreEqual("Generic animal sound", sound);
        }

        [TestMethod]
        public void Dog_Should_Inherit_Animal_Properties()
        {
            // Arrange
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Age = 4;
            dog.Breed = "Labrador";

            // Act & Assert
            Assert.AreEqual("Buddy", dog.Name);
            Assert.AreEqual(4, dog.Age);
            Assert.AreEqual("Labrador", dog.Breed);
        }
    }
}
