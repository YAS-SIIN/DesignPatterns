// See https://aka.ms/new-console-template for more information
using DesignPatterns.Singletone;

Console.WriteLine("Hello, World!");


var singleTone1 = Singelton.GetInstance();
var singleTone2 = Singelton.GetInstance();


Console.ReadLine();