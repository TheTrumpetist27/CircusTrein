using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCircusTreinLibrary
{
    public class Wagon
    {
        public int WagonSize { get; private set; }
        private List<Animal> animals { get; set; }
        public IReadOnlyList<Animal> Animals { get { return animals; } }

        public Wagon(Animal animal, int wagonSize = 10)
        {
            animals = new List<Animal>
            {
                animal
            };
            WagonSize = wagonSize;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public bool CheckCanBeAdded(Animal animal)
        {
            int totalSize = (int)animal.Size;
            foreach (Animal animal1 in animals)
            {
                totalSize += (int)animal1.Size;
            }
            if (totalSize <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
