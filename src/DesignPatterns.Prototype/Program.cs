// See https://aka.ms/new-console-template for more information
using DesignPatterns.Prototype;

Console.WriteLine("Hello, World!");

ConcretePrototype1 Service1 = new ConcretePrototype1(1500, "test");
ConcretePrototype1 Service2 = (ConcretePrototype1)Service1.Clone();
Console.WriteLine(Service1.value);
Console.WriteLine(Service2.valueName);
Console.WriteLine(Service1 == Service2);

ConcretePrototype2 serviceComplex1 = new ConcretePrototype2(Service1);
var serviceComplex2 = (ConcretePrototype2)serviceComplex1.Clone();
Console.WriteLine(serviceComplex1.myApplicationService.value);
Console.WriteLine(serviceComplex2.myApplicationService.valueName);
Console.WriteLine(serviceComplex1 == serviceComplex2);
Console.WriteLine(serviceComplex1 == serviceComplex1);

Console.ReadKey();