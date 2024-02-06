// See https://aka.ms/new-console-template for more information
using DesignPatterns.Command;
using DesignPatterns.Command.Sample;

using System.Reflection.Emit;

Console.WriteLine("Hello, World!");

Reciver reciver = new Reciver();
Command command = new ConcreteCommand(reciver);
Invoker invoker = new Invoker();


invoker.SetCommand(command);
invoker.ExecuteCommand();


//----------------Sample----------------
var invokerEditText = new InvokerEditText();
Console.WriteLine(invokerEditText.ExecuteCommand("Text1"));
Console.WriteLine(invokerEditText.ExecuteCommand("Text2"));
Console.WriteLine(invokerEditText.ExecuteCommand("Text3"));
Console.WriteLine(invokerEditText.ExecuteCommand("Text4"));
Console.WriteLine(invokerEditText.ExecuteCommand("Text5"));


Console.WriteLine("Undo :" + invokerEditText.Undo());
Console.WriteLine("Undo :" + invokerEditText.Undo());

Console.WriteLine("Redo :" + invokerEditText.Redo());

Console.ReadLine();
