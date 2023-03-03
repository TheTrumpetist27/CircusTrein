using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCircusTreinLibrary
{
    public class Animal
    {
        public AnimalSize Size { get; private set; }
        public AnimalType Type { get; private set; }

        public Animal(AnimalSize size, AnimalType type) 
        {
            Size = new AnimalSize();
            Type = new AnimalType();
            Size = size;
            Type = type;
        }
    }
}
