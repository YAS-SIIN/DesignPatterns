// See https://aka.ms/new-console-template for more information
using DesignPatterns.ChainOfResponsibility;

Console.WriteLine("Hello, World!");


Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();

handler1.SetSuccessor(handler2);

handler1.HandleRequest(10);
handler1.HandleRequest(1000);


Console.ReadLine();