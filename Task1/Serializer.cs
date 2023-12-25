using ClassLibrary;
using System;
using System.IO;
using System.Xml.Serialization;


namespace Init
{
    static class Serializer
    {
        static void Main()
        {
            Cow korova = new Cow
            {
                Country = "Russia",
                HideFromOtherAnimals = false,
                Name = "Burenka",
                WhatAnimal = "What-what?"
            };
            XmlSerializer serializer = new XmlSerializer(typeof(Cow));

            using (TextWriter writer = new StreamWriter("animal.xml"))
            {
                serializer.Serialize(writer, korova);
            }
           
        }
    }

}