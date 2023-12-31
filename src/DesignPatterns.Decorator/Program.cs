﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Sample;

ConcreteComponent concreteComponent = new ConcreteComponent();
//concreteComponent.operation();

//Decorator decorator = new Decorator(concreteComponent);
//decorator.Operation();

ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);

concreteDecorator.Operation();

SendEmail sendEmail = new SendEmail();

SendEmailDecorator sendEmailDecorator = new SendEmailDecorator(sendEmail);
sendEmailDecorator.Send();
sendEmailDecorator.SaveLog();

Console.WriteLine("Hello, World!");

Console.ReadLine();