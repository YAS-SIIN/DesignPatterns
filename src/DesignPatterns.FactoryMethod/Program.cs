// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryMethod;

using FactoryMethod.Sms.FactoryMethod;
using FactoryMethod.Sms;

Console.WriteLine("Hello, World!");
var creator = new ConcreteCreator();
Product p;
p = creator.FactoryMethod(ProductCallEnum.None);
p.Excute();
p = creator.FactoryMethod(ProductCallEnum.ConcreteProduct1);
p.Excute();
p = creator.FactoryMethod(ProductCallEnum.ConcreteProduct2);
p.Excute();


//Sample --------
ISmsManager sms;
ICreatorSample creatorSample = new CreatorSample();
sms = creatorSample.FactoryMethodSample();
sms.Send(new SmsDto
{
    Message = "test",
    Reciver = "0912000000",
});

Console.ReadKey();