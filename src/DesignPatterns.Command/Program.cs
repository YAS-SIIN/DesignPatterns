// See https://aka.ms/new-console-template for more information
using DesignPatterns.Command;

Console.WriteLine("Hello, World!");

Reciver reciver = new Reciver();
Command command = new ConcreteCommand(reciver);
Invoker invoker = new Invoker();


invoker.SetCommand(command);
invoker.ExecuteCommand();

Console.ReadLine();
