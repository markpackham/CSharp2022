// See https://aka.ms/new-console-template for more information
using ElectronicDeviceInterfaces;

IElectronicDevice TV = TVRemote.GetDevice();

PowerButton powerBut = new PowerButton(TV);

powerBut.Execute();
powerBut.Undo();
powerBut.Execute();
powerBut.Undo();