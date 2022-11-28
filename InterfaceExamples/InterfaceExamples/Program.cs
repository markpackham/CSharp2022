// See https://aka.ms/new-console-template for more information
using InterfaceExamples;

Vehicle buick = new Vehicle("Buick",4,160);

if(buick is IDrivable)
{
    buick.Move();
    buick.Stop();
}
else
{
    Console.WriteLine("The {0} is faulty and can't be driven", buick.Brand);
}