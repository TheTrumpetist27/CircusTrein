using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCircusTreinLibrary
{
    public class Train
    {
        Random randomNumber = new Random();
        int wagonFullCounter = 0;
        int staticWagonCounter = 0;
        private List<Animal> animals { get; set; }
        public IReadOnlyList<Animal> Animals { get { return animals; } }
        public List<Wagon> Wagons { get; private set; }
        public List<Animal> UnsortedAnimals { get; private set; }
        public int NumOfAnimals { get; private set; }

        public Train()
        {
            Wagons = new List<Wagon>();
            UnsortedAnimals = new List<Animal>();
            animals =  new List<Animal>();
        }

        /// <summary>
        /// Passes the number of animals to be created to an variable to be used.
        /// </summary>
        /// <param name="amount">The number of animals to be created</param>
        public void AddAmountOfAnimals(int amount)
        {
            NumOfAnimals = amount;
        }

        /// <summary>
        /// Creates an set amount of animals specified by the "AddAmountOfAnimals" method. Animals can be of type: Herbivore or Carnivore. And they can have a size of: Small, medium, large.
        /// </summary>
        public void CreateRandomAnimals()
        {
            for (int i = 0; i < NumOfAnimals; i++)
            {
                var size = AnimalSize.small;
                var type = AnimalType.Carnivore;

                int animalSize = randomNumber.Next(3);
                int animalType = randomNumber.Next(2);

                if (animalSize == 0)
                {
                    size = AnimalSize.small;
                }
                else if (animalSize == 1)
                {
                    size = AnimalSize.medium;
                }
                else
                {
                    size = AnimalSize.large;
                }

                if (animalType == 0)
                {
                    type = AnimalType.Carnivore;
                }
                else
                {
                    type = AnimalType.Herbivore;
                }

                Animal animal = new Animal(size, type);
                UnsortedAnimals.Add(animal);
            }

            // Sort the animals from largest size to smallest and put the carnivores first in line
            List<Animal> decendingAnimals = new List<Animal>();

            decendingAnimals = UnsortedAnimals.OrderBy(x => x.Size).ToList();
            decendingAnimals.Reverse();
            animals = decendingAnimals.OrderBy(x => x.Type).ToList();
        }

        public void CreateAnimalScenarioOne()
        {
            // TODO: Wanneer ik alleen een small heb, Verander de volgorde van klein naar groot carnivoor eerst.

            Animal animal = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal2 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal3 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal4 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal5 = new Animal(AnimalSize.medium, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
        }

        public void CreateAnimalScenarioTwo()
        {
            Animal animal = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal2 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal3 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal4 = new Animal(AnimalSize.small, AnimalType.Herbivore);
            Animal animal5 = new Animal(AnimalSize.small, AnimalType.Herbivore);
            Animal animal6 = new Animal(AnimalSize.small, AnimalType.Herbivore);
            Animal animal7 = new Animal(AnimalSize.small, AnimalType.Herbivore);
            Animal animal8 = new Animal(AnimalSize.small, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
        }

        public void CreateAnimalScenarioThree()
        {
            Animal animal = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.medium, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal3 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal4 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal5 = new Animal(AnimalSize.small, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
        }

        public void CreateAnimalScenarioFour()
        {
            Animal animal = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.medium, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal3 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal4 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal5 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal6 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal7 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal8 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal9 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal10 = new Animal(AnimalSize.small, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
        }

        public void CreateAnimalScenarioFive()
        {
            Animal animal = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal2 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal3 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal4 = new Animal(AnimalSize.small, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
        }

        public void CreateAnimalScenarioSix()
        {
            Animal animal = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal3 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal4 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal5 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal6 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal7 = new Animal(AnimalSize.medium, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
        }

        public void CreateAnimalScenarioSeven()
        {
            Animal animal = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Animal animal1 = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Animal animal2 = new Animal(AnimalSize.large, AnimalType.Carnivore);
            Animal animal3 = new Animal(AnimalSize.medium, AnimalType.Carnivore);
            Animal animal4 = new Animal(AnimalSize.medium, AnimalType.Carnivore);
            Animal animal5 = new Animal(AnimalSize.medium, AnimalType.Carnivore);
            Animal animal6 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal7 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal8 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal9 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal10 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal11 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal12 = new Animal(AnimalSize.small, AnimalType.Carnivore);
            Animal animal13 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal14 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal15 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal16 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal17 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal18 = new Animal(AnimalSize.large, AnimalType.Herbivore);
            Animal animal19 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal20 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal21 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal22 = new Animal(AnimalSize.medium, AnimalType.Herbivore);
            Animal animal23 = new Animal(AnimalSize.medium, AnimalType.Herbivore);

            animals.Add(animal);
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
            animals.Add(animal11);
            animals.Add(animal12);
            animals.Add(animal13);
            animals.Add(animal14);
            animals.Add(animal15);
            animals.Add(animal16);
            animals.Add(animal17);
            animals.Add(animal18);
            animals.Add(animal19);
            animals.Add(animal20);
            animals.Add(animal21);
            animals.Add(animal22);
            animals.Add(animal23);
        }

        /// <summary>
        /// Creates a wagon with the given animal inside it.
        /// </summary>
        /// <param name="animal">The Animal to put in the wagon.</param>
        private void CreateWagon(Animal animal)
        {
            Wagon wagon = new Wagon(animal);
            Wagons.Add(wagon);
        }

        /// <summary>
        /// Checks if an animal can be added and ands the animal to the wagon.
        /// </summary>
        /// <param name="animal">The animal to put in the wagon.</param>
        /// <returns>Boolean. True if added, false if animal fails to be added in any of the wagons.</returns>
        private bool AddAnimalToWagon(Animal animal, int counter)
        {
            for (int i = counter; i < Wagons.Count; i++)
            {
                // To check if the animal can be added based on size of the wagon
                bool canBeAdded = Wagons[i].CheckCanBeAdded(animal);

                if (canBeAdded)
                {
                    // To check if the first (usually carnivorious) animal is smaller then the animal to be added
                    if (Wagons[i].Animals[0].Size < animal.Size)
                    {
                        Wagons[i].AddAnimal(animal);
                        return true;
                    }
                    // To check if the first (by now an herbivore) animal is an herbivore so we don't waste space
                    else if (Wagons[i].Animals[0].Type == AnimalType.Herbivore)
                    {
                        Wagons[i].AddAnimal(animal);
                        return true;
                    }
                }
                wagonFullCounter++;
            }
            return false;
        }

        private void OrderLargeCarnivoreFirst()
        {
            List<Animal> tempAnimalsList = new List<Animal>();

            tempAnimalsList = animals.OrderBy(x => x.Size).ToList();
            tempAnimalsList.Reverse();
            animals = tempAnimalsList.OrderBy(x => x.Type).ToList();
        }

        private void OrderSmallCarnivoreFirst()
        {
            List<Animal> tempAnimalsList = new List<Animal>();

            tempAnimalsList = animals.OrderBy(x => x.Size).ToList();
            animals = tempAnimalsList.OrderBy(x => x.Type).ToList();
        }

        /// <summary>
        /// Loops through the Animals list to add each to a wagon. 
        /// </summary>
        /// <param name="counter">The type of counter to use.</param>
        private void FindPlaceForAnimal(string counter)
        {
            if (counter == "dynamic")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.Type == AnimalType.Carnivore)
                    {
                        CreateWagon(animal);
                    }
                    else if (animal.Type == AnimalType.Herbivore)
                    {
                        bool addedAnimal = AddAnimalToWagon(animal, wagonFullCounter);
                        // when the animal can not be stored in any of the existing wagons, we create a new wagon with the animal inside
                        if (!addedAnimal)
                        {
                            CreateWagon(animal);
                        }
                    }
                }
            } 
            else if (counter == "static")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.Type == AnimalType.Carnivore)
                    {
                        CreateWagon(animal);
                    }
                    else if (animal.Type == AnimalType.Herbivore)
                    {
                        bool addedAnimal = AddAnimalToWagon(animal, staticWagonCounter);
                        // when the animal can not be stored in any of the existing wagons, we create a new wagon with the animal inside
                        if (addedAnimal == false)
                        {
                            CreateWagon(animal);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds each of the animals in the Animals list inside a wagon based on multiple checks to ensure this goes as efficient as possible.
        /// </summary>
        public void AddAnimalsToWagons()
        {
            int smallHerbivoreCounter = 0;
            int smallCarnivoreCounter = 0;
            int mediumCounter = 0;
            int largeCounter = 0;
            bool firstItem = true;
            bool smallFirst = false;

            foreach (Animal animal in animals)
            {
                if (animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.medium)
                {
                    mediumCounter++;
                }
                else if (animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.large)
                {
                    largeCounter++;
                }
                else if (animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.small)
                {
                    smallHerbivoreCounter++;
                }
                else if (animal.Type == AnimalType.Carnivore && animal.Size == AnimalSize.small)
                {
                    smallCarnivoreCounter++;
                }

                if (firstItem)
                {
                    if (animal.Type == AnimalType.Carnivore && animal.Size == AnimalSize.medium || animal.Type == AnimalType.Carnivore && animal.Size == AnimalSize.large)
                    {
                        firstItem = false;
                        smallFirst = false;
                    }
                    else if (animal.Type == AnimalType.Carnivore && animal.Size == AnimalSize.small)
                    {
                        firstItem = false;
                        smallFirst = true;

                        OrderSmallCarnivoreFirst();
                    }
                }
            }
            
            if (smallHerbivoreCounter > smallCarnivoreCounter && smallFirst || largeCounter > mediumCounter && smallFirst)
            {
                OrderLargeCarnivoreFirst();
                FindPlaceForAnimal("static");
            }
            else
            {
                FindPlaceForAnimal("dynamic");
            }
        }
    }
}