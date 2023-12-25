using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Animal
    {
        public string Country { get; set; }
        public bool HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public Animal() {}
        public abstract (string country, bool hide, string name, string animalType) Deconstruct();
        public abstract eClassificationAnimal GetClassificationAnimal();
        public abstract eFavoriteFood GetFavouriteFood();
        public abstract void SayHello();
    }

    public class Cow : Animal
    {
        public Cow()
        {
            Console.WriteLine("Cow has been created");
        }
        public override (string country, bool hide, string name, string animalType) Deconstruct()
        {
            return (Country, HideFromOtherAnimals, Name, WhatAnimal);
        }
        public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Herbivores;
        public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Plants;
        public override void SayHello() { Console.WriteLine("MUUUUU!"); }
    }

    public class Lion : Animal
    {
        public Lion() : base()
        {
            Console.WriteLine("Lion has been created");
        }

        public override (string country, bool hide, string name, string animalType) Deconstruct()
        {
            return (Country, HideFromOtherAnimals, Name, WhatAnimal);
        }

        public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Carnivores;
        public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Meat;
        public override void SayHello() { Console.WriteLine("MEW!"); }
    }

    public class Pig : Animal
    {
        public Pig() : base()
        {
            Console.WriteLine("Pig has been created");
        }

        public override (string country, bool hide, string name, string animalType) Deconstruct()
        {
            return (Country, HideFromOtherAnimals, Name, WhatAnimal);
        }

        public override eClassificationAnimal GetClassificationAnimal() => eClassificationAnimal.Omnivores;
        public override eFavoriteFood GetFavouriteFood() => eFavoriteFood.Everything;
        public override void SayHello() { Console.WriteLine("HRIU!"); }
    }

    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    public enum eFavoriteFood
    {
        Meat,
        Plants,
        Everything
    }


}
