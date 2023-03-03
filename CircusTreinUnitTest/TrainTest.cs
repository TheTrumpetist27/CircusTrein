using ClassLibraryCircusTreinLibrary;

namespace CircusTreinUnitTest
{
    [TestClass]
    public class TrainTest
    {
        Train train;
        [TestInitialize]
        public void Setup()
        {
            train = new Train();
            train.AddAmountOfAnimals(100);
        }
        [TestMethod]
        public void TestCreateRandomAnimals()
        {
            // Arrange
            train.CreateRandomAnimals();

            // Act


            // Assert
            Assert.IsNotNull(train.Animals);
        }
        [TestMethod]
        public void TestAddAnimalsToWagons()
        {
            // Arrange
            train.CreateRandomAnimals();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.IsNotNull(train.Wagons);
            for (int i = 0; i < train.Wagons.Count; i++)
            {
                Assert.IsNotNull(train.Wagons[i].Animals);
            }
        }

        [TestMethod]
        public void TestScenarioOne()
        {
            // Arrange
            train.CreateAnimalScenarioOne();

            // Act
            train.AddAnimalsToWagons();

            // Assert
            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioTwo() 
        {
            train.CreateAnimalScenarioTwo();

            train.AddAnimalsToWagons();

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioThree()
        {
            train.CreateAnimalScenarioThree();

            train.AddAnimalsToWagons();

            Assert.AreEqual(4, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioFour()
        {
            train.CreateAnimalScenarioFour();

            train.AddAnimalsToWagons();

            Assert.AreEqual(5, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioFive()
        {
            train.CreateAnimalScenarioFive();

            train.AddAnimalsToWagons();

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioSix()
        {
            train.CreateAnimalScenarioSix();

            train.AddAnimalsToWagons();

            Assert.AreEqual(3, train.Wagons.Count);
        }

        [TestMethod]
        public void TestScenarioSeven()
        {
            train.CreateAnimalScenarioSeven();
            
            train.AddAnimalsToWagons();

            Assert.AreEqual(13, train.Wagons.Count);
        }
    }
}