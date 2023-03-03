using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircusTreinLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTreinUnitTest
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonCanBeConstructed()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Wagon wagon = new Wagon(animal);


            // Act


            // Assert
            Assert.IsNotNull(wagon);
            Assert.AreEqual(10, wagon.WagonSize);
        }

        [TestMethod]
        public void TestCheckAnimalCanBeAddedFalse()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal2 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animalToBeAdded = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Wagon wagon = new Wagon(animal);
            wagon.AddAnimal(animal2);
            // Act
            bool result = wagon.CheckCanBeAdded(animalToBeAdded);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckAnimalCanBeAddedTrue() 
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animalToBeAdded = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Wagon wagon = new Wagon(animal);
            // Act
            bool result = wagon.CheckCanBeAdded(animalToBeAdded);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
