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

Rectangle<int> rect1 = new Rectangle<int>(2, 5);
Console.WriteLine(rect1.GetArea());

Rectangle<long> rect2 = new Rectangle<long>(20, 50);
Console.WriteLine(rect2.GetArea());

Rectangle<string> rect3 = new Rectangle<string>("2", "3");
Console.WriteLine(rect3.GetArea());

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

    // A delegate is a type that represents references to methods with a particular parameter list and return type.
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

    public delegate void Arithmatic(double num1, double num2);

    public static void Add(double num1, double num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
    }

    public static void Subtract(double num1, double num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }
}