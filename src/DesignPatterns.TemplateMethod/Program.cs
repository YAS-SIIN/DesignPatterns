// See https://aka.ms/new-console-template for more information
using DesignPatterns.TemplateMethod;

Console.WriteLine("Hello, World!");

Client.Run(new ConcreteClass());


//-----Sample-----
DesignPatterns.TemplateMethod.Sample.Client.RunTemplateMethod(new DesignPatterns.TemplateMethod.Sample.CocreteClass1());
Console.WriteLine("---------------------------");

Console.ReadLine();