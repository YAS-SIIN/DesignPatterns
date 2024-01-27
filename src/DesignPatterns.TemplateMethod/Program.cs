// See https://aka.ms/new-console-template for more information
using DesignPatterns.TemplateMethod;

Console.WriteLine("Hello, World!");

Client.Run(new ConcreteClass());


//-----Sample-----
DesignPatterns.TemplateMethod.Sample.Client.RunTemplateMethod(new DesignPatterns.TemplateMethod.Sample.ConcreteClass1());
Console.WriteLine("---------------------------");
DesignPatterns.TemplateMethod.Sample.Client.RunTemplateMethod(new DesignPatterns.TemplateMethod.Sample.ConcreteClass2());
Console.ReadLine();