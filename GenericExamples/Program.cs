// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

using GenericExamples;

List<Animal> animalList = new List<Animal>();

List<int> numList = new List<int>();
numList.Add(100);

animalList.Add(new Animal() { Name = "Snarf" });
animalList.Add(new Animal() { Name = "Whiskers" });
animalList.Add(new Animal() { Name = "Rover" });

// use Insert to place at a specific position
animalList.Insert(1,new Animal() { Name = "Lino" });
animalList.RemoveAt(1);
Console.WriteLine(animalList.Count);

foreach (Animal animal in animalList)
{
    Console.WriteLine(animal.Name);
}

int x = 5, y = 4;
Animal.GetSum<int>(ref y, ref x);

string strX = "5", strY = "4";
Animal.GetSum<string>(ref strX, ref strY);