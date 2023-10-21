// See https://aka.ms/new-console-template for more information
using DesignPatterns.Composite;
using DesignPatterns.Composite.Sample;
using DesignPatterns.Composite.SampleWithEntity;

Console.WriteLine("Hello, World!");

 
Component component = new Composite
         ("Root Item", new Component[]
         {
                    new Leaf("Leaf 1"),
                    new Composite ("Composite 1",new Component[]
                    {
                        new Leaf("Leaf 1-1"),
                        new Leaf("Leaf 1-2"),
                        new Composite("Composite 1-1",new Component[]
                        {
                            new Leaf("Laef 1-1-1-"),
                            new Composite("empty Composite",new Component[]{ }),
                        })
                    }),
                    new Leaf("Leaf 2"),
                    new Leaf("Leaf 3"),
                    new Leaf("Leaf 4"),
         });
component.Display(1);


//Sample 1

IComponent hardDisk = new Part("Hard Disk", 100000);
IComponent ram = new Part("RAM", 100000);
IComponent cpu = new Part("CPU", 200000);
IComponent mouse = new Part("Mouse", 50000);
IComponent keyboard = new Part("Keyboard", 50000);
IComponent Monitor = new Part("Monitor", 400000);

Partition motherBoard = new Partition("MotherBoard", 100000);
Partition Case = new Partition("Case", 70000);
Partition peripherals = new Partition("Peripherals", 0);
Partition computer = new Partition("Computer", 0);

motherBoard.Add(cpu);
motherBoard.Add(ram);

Case.Add(motherBoard);
Case.Add(hardDisk);

peripherals.Add(mouse);
peripherals.Add(keyboard);

computer.Add(Case);
computer.Add(peripherals);
computer.Add(Monitor);

computer.DisplayPrice();


//Sample With Entity

SampleService sampleService = new SampleService();
sampleService.InitializeData();
sampleService.GetResult();

Console.Read();
Console.ReadLine();

