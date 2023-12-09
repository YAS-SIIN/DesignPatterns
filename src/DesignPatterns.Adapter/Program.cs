// See https://aka.ms/new-console-template for more information
using DesignPatterns.Adapter;

Console.WriteLine("Hello, World!");
Target target = new Adapter();
target.Operation();
Console.ReadLine();
