// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Traineeclass;

Console.WriteLine("Hello, World!");

ContactClass eldhose=new ContactClass();

eldhose.Name = "Eldhose";
eldhose.Location = "Kanjiramattom";

Console.WriteLine($"{eldhose.Name} - {eldhose.Location}");
