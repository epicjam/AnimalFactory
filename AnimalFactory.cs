using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class AnimalFactory
    {
        public string name;
        public string voiceSound;
        public int age;
        public Animals CreateAnimal(AnimalType animalType)
        {
            Animals animal = null;

            switch (animalType)
            {
                case AnimalType.Cow:
                    animal = new Cow(name, voiceSound, age);
                    break;
                case AnimalType.Dog:
                    animal = new Dog(name, voiceSound, age);
                    break;
                case AnimalType.Monkey:
                    animal = new Monkey(name, voiceSound, age);
                    break;
            }
            return animal;
        }
    }
}
