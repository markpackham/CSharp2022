// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

using GenericExamples;
using static GenericExamples.ArithmaticClass;

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

Rectangle<int> rect1 = new Rectangle<int>(2, 5);
Console.WriteLine(rect1.GetArea());

Rectangle<long> rect2 = new Rectangle<long>(20, 50);
Console.WriteLine(rect2.GetArea());

Rectangle<string> rect3 = new Rectangle<string>("2", "3");
Console.WriteLine(rect3.GetArea());


Arithmatic add, sub, addSub;
add = new Arithmatic(Add);
sub = new Arithmatic(Subtract);
addSub = add + sub;

Console.WriteLine($"Add {6} & {10}");
add(6, 10);
Console.WriteLine($"Add & Subtract {10} & {4}");
addSub(10, 4);



public struct Rectangle<T>
{
    private T width; 
    private T length;

    public T Width
    {
        get { return width; }
        set { width = value;}
    }

    public T Length
    {
        get { return length; }
        set { length = value; }
    }

    public Rectangle(T width, T length)
    {
        this.width = width;
        this.length = length;
    }

    public string GetArea()
    {
        double dblWidth = Convert.ToDouble(Width);
        double dblLength = Convert.ToDouble(Length);

        return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
    }
}



