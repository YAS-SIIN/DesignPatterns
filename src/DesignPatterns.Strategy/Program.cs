// See https://aka.ms/new-console-template for more information
using DesignPatterns.Strategy;

Console.WriteLine("Hello, World!");


Context context;

//Injection
context = new Context(new ConcreteStrategyA());
context.ContextInterface();

//Injection
context = new Context(new ConcreteStrategyB());
context.ContextInterface();

//Injection
context = new Context(new ConcreteStrategyC());
context.ContextInterface();

Console.ReadLine();