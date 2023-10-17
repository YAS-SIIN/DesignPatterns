// See https://aka.ms/new-console-template for more information

using DesignPatterns.Proxy;


ISubject subject = new Proxy();
subject.DoAction();

Console.WriteLine("Hello, World!");

Console.ReadKey();
