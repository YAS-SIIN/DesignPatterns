// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryMethod;

Console.WriteLine("Hello, World!");
var creator = new ConcreteCreator();
Product p;
p = creator.FactoryMethod(ProductCallEnum.None);
p.Excute();
p = creator.FactoryMethod(ProductCallEnum.ConcreteProduct1);
p.Excute();
p = creator.FactoryMethod(ProductCallEnum.ConcreteProduct2);
p.Excute();

Console.ReadKey();