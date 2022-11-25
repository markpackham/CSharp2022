// See https://aka.ms/new-console-template for more information

using PolymorphShape;

Shape[] shapes =
{
    new Circle(5), new Rectangle(4,5)
};

foreach (Shape shape in shapes)
{
    shape.GetInfo();
    Console.WriteLine("{0} Area : {1:f2}", shape.Name, shape.Area());

    Circle testCirc = shape as Circle;
    if(testCirc == null)
    {
        Console.WriteLine("This is not a Circle");
    }

    if(shape is Circle)
    {
        Console.WriteLine("This is not a Rectangle");
    }

    Console.WriteLine("-----");
}

object circ1 = new Circle(4);

Circle circ2 = (Circle) circ1;
Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());