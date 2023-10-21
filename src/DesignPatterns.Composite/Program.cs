// See https://aka.ms/new-console-template for more information
using DesignPatterns.Composite;

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


Console.ReadLine();
