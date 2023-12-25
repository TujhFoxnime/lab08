using System;
using System.IO;
using System.Xml.Serialization;
using ClassLibrary;


namespace Init
{
    static class Deserializer
    {
        static void Main()
        {
        
            XmlSerializer serializer = new XmlSerializer(typeof(Cow));
            Cow cow = new Cow();
            using (Stream reader = new FileStream(@"C:\Users\gkras\Рабочий стол\Учёба\C++\LabWorkEight\Task1\bin\Debug\net6.0\animal.xml", FileMode.Open))
            {
                cow = (Cow)serializer.Deserialize(reader);
            }
            Console.WriteLine(
                $"HideFromOtherAnimals {cow.HideFromOtherAnimals}\n" +
                $"Name {cow.Name}\n" +
                $"Country {cow.Country}\n" +
                $"WhatAnimal {cow.WhatAnimal}\n"
                );
        }
    }

}