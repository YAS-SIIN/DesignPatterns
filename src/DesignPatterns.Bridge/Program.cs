// See https://aka.ms/new-console-template for more information
using BridgeSample.MailService;

using DesignPatterns.Bridge.Abstractions;

Console.WriteLine("Hello, World!");

// Run
Abstraction abstraction = new RefinedAbstraction();

abstraction.Function();

// Run Sample
RefinedMailService mailService = new RefinedMailService();
mailService.Send(new EmailInformationDto
{
    Message = "this is a message from my app ",
    Reciver = "bugeto@gmail.com",
    Title = "Alert mail"
});


Console.ReadKey();
