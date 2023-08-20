// See https://aka.ms/new-console-template for more information
using DesignPatterns.Decorator;


ConcreteComponent concreteComponent = new ConcreteComponent();
//concreteComponent.operation();

//Decorator decorator = new Decorator(concreteComponent);
//decorator.Operation();

ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);
concreteDecorator.Operation();

Console.WriteLine("Hello, World!");

Console.ReadLine();