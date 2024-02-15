// See https://aka.ms/new-console-template for more information
using DesignPatterns.Memento;

Console.WriteLine("Hello, World!");


Originator originator = new Originator();
originator.State = "Green";
Caretaker caretaker = new Caretaker();
caretaker.Memento = originator.CreateMemento();
originator.State = "Red";
originator.State = "Blue ";
originator.State = "Yellow";

originator.SetMemento(caretaker.Memento);

Console.ReadLine();

