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